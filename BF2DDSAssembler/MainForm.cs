using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BF2DDSAssembler
{

    public partial class MainForm : Form
    {
        PictureBox[,] pictureBoxes = new PictureBox[8, 8];

        private enum IMAGESIZE : int
        {
            COLORMAP = 512,
            DETAILMAP = 256,
            EDITORCOLORMAP = 512,
            EDITORDETAILMAP = 512,
        };

        private enum NVProgram : int
        {
            Compress = 0,
            Decompress = 1,
        };

        private string GetNVProgram(NVProgram p)
        {
            if (p == NVProgram.Compress)
                return "nvcompress.exe";
            if (p == NVProgram.Decompress)
                return "nvdecompress.exe";
            throw new InvalidEnumArgumentException();
        }

        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine(GetSuffix);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox pBox = (pictureBoxes[i, j] = new PictureBox());
                    pBox.Margin = Padding.Empty;
                    pBox.BorderStyle = BorderStyle.None;
                    pBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    previewPanel.Controls.Add(pBox);

                    Point desiredLocation = new Point(0, 0);
                    desiredLocation.X = (previewPanel.Width / 8) * i;
                    desiredLocation.Y = (previewPanel.Height / 8) * j;
                    pBox.Location = desiredLocation;

                    Size desiredSize = new Size(0, 0);
                    desiredSize.Width = previewPanel.Width / 8;
                    desiredSize.Height = previewPanel.Height / 8;
                    pBox.Size = desiredSize;

                    Label coordinateLabel = new Label();
                    coordinateLabel.Text = string.Format("tx{0:00}x{1:00}", i, j);
                    coordinateLabel.Parent = pBox;
                    pBox.Controls.Add(coordinateLabel);

                    coordinateLabel.BackColor = Color.Transparent;
                    Font f = new Font("Microsoft Sans Serif", 6.5f, FontStyle.Regular);
                    coordinateLabel.Font = f;

                    coordinateLabel.BringToFront();
                    coordinateLabel.Visible = false;

                }
            }
        }

        private void selectFolderClick(object sender, EventArgs e)
        {
            DialogResult result = loadFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ActivateButtons(true);
                LoadDDSImages();
            }
        }

        private void ActivateButtons(bool activeState)
        {
            saveSeperateImagesButton.Enabled = activeState;
            combineButton.Enabled = activeState;
        }

        private void LoadDDSImages()
        {
            string[] files = Directory.GetFiles(loadFolderDialog.SelectedPath, string.Format("tx??x??{0}.dds", GetSuffix));

            if (files.Length > 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    string fullFilePath = files[i];
                    string file = files[i];
                    Console.WriteLine(file);
                    file = file.Replace(loadFolderDialog.SelectedPath + "\\", "");

                    file = file.Replace("tx", "");
                    file = file.Replace(".dds", "");
                    if (file.Contains("_"))
                    {
                        file = file.Remove(file.IndexOf('_'), 2);
                    }
                    string[] splitName = file.Split(new char[] { 'x' });

                    int x = int.Parse(splitName[0]);
                    int y = int.Parse(splitName[1]);

                    StartCompressProcess(NVProgram.Decompress, fullFilePath);
                    string decompressedTGA = fullFilePath.Replace(".dds", ".tga");

                    Image image = Paloma.TargaImage.LoadTargaImage(decompressedTGA);

                    File.Delete(decompressedTGA);
                    pictureBoxes[x, y].Image = image;
                    pictureBoxes[x, y].Refresh();
                }
            }
            else
            {
                string mapType = GetSuffix == "" ? "color" : ("detail" + GetSuffix);
                MessageBox.Show(string.Format("Error: Selected folder does not contain any {0} maps.", mapType), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void combineClick(object sender, EventArgs e)
        {
            DialogResult result = saveLargeFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap largeImage = new Bitmap(GetImageSize * 8, GetImageSize * 8);
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        using (Graphics g = Graphics.FromImage(largeImage))
                        {
                            g.DrawImage(pictureBoxes[x, y].Image, x * GetImageSize, y * GetImageSize);
                        }
                    }
                }
                largeImage.Save(saveLargeFileDialog.FileName);
            }
        }

        private void splitImageButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openLargeFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ActivateButtons(true);
                Bitmap largeImage = new Bitmap(openLargeFileDialog.FileName);
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        Bitmap subimage = new Bitmap(GetImageSize, GetImageSize);
                        using (Graphics g = Graphics.FromImage(subimage))
                        {
                            g.DrawImage(largeImage,
                                new Rectangle(0, 0, GetImageSize, GetImageSize),
                                new Rectangle(x * GetImageSize, y * GetImageSize, GetImageSize, GetImageSize),
                                GraphicsUnit.Pixel);
                        }
                        pictureBoxes[x, y].Image = subimage;
                        pictureBoxes[x, y].Refresh();
                    }
                }
            }
        }

        private void StartCompressProcess(NVProgram p, string fullPath, string additionalOptions = "")
        {
            string options = "";
            if (p == NVProgram.Compress)
            {
                if (!useCudaBox.Checked)
                    options += "-nocuda ";

                if (editorFolderBox.Checked)
                {
                    //Editor-Colormap
                    if (GetSuffix == "")
                        options += "-bc1 ";
                    //Editor-Details
                    else
                        options += "-rgb ";
                }
                else
                {
                    //Non-Editor Colormap
                    if (GetSuffix == "")
                        options += "-bc1  ";
                    else
                        options += "-rgb ";

                }
            }

            ProcessStartInfo cmdsi = new ProcessStartInfo(GetNVProgram(p), string.Format("{1} {2}\"{0}\"", fullPath, options, additionalOptions));
            Console.WriteLine("OPTIONS: {0}", cmdsi.Arguments);
            cmdsi.UseShellExecute = false;
            Process cmd = Process.Start(cmdsi);
            cmd.WaitForExit();
        }

        private void saveImages_Click(object sender, EventArgs e)
        {
            DialogResult result = loadFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        string fileName = string.Format("tx{0:00}x{1:00}{2}.png", x, y, GetSuffix);
                        string fullPath = Path.Combine(loadFolderDialog.SelectedPath, fileName);

                        pictureBoxes[x, y].Image.Save(Path.GetFullPath(fullPath));
                        StartCompressProcess(NVProgram.Compress, fullPath);
                        File.Delete(fullPath);
                    }
                }
            }
        }

        #region Getter & Setters
        private int GetImageSize
        {
            get
            {
                if (editorFolderBox.Checked)
                {
                    if (colormapRadio.Checked)
                        return (int)IMAGESIZE.EDITORCOLORMAP;
                    else if (detailmapRadio.Checked)
                        return (int)IMAGESIZE.EDITORDETAILMAP;
                }
                else
                {
                    if (colormapRadio.Checked)
                        return (int)IMAGESIZE.COLORMAP;
                    else if (detailmapRadio.Checked)
                        return (int)IMAGESIZE.DETAILMAP;
                }
                return 0;
            }
        }

        private string GetSuffix
        {
            get
            {
                string text;
                if (detailSuffixBox.Enabled)
                {
                    var checkedButton = detailSuffixBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    if (checkedButton != null)
                        text = checkedButton.Text;
                    else
                        throw new ArgumentNullException(checkedButton.Name);
                }
                else
                    text = "";
                return text;
            }
        }
        #endregion

        private void colormapRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (colormapRadio.Checked)
                detailSuffixBox.Enabled = false;
            else
                detailSuffixBox.Enabled = true;
        }
        
        private void detailSuffixBox_EnabledChanged(object sender, EventArgs e)
        {
            if (detailSuffixBox.Enabled)
                detailSuffixBox.Controls
                    .OfType<RadioButton>()
                    .ToList()
                    .ForEach(r => 
                    {
                        r.Enabled = true;
                        r.Refresh();
                    }
                );
            else
                detailSuffixBox.Controls.OfType<RadioButton>().ToList().ForEach(r => { r.Enabled = false; r.Refresh(); });
        }

        #region Preview controls
        private void showTextBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCoordinateBox.Checked)
                previewPanel.Controls
                    .OfType<PictureBox>()
                    .ToList()
                    .ForEach(p => p.Controls.OfType<Label>()
                        .ToList()
                        .ForEach(l => l.Visible = true)
                    );
            else
                previewPanel.Controls
                    .OfType<PictureBox>()
                    .ToList()
                    .ForEach(p => p.Controls.OfType<Label>()
                        .ToList()
                        .ForEach(l => l.Visible = false)
                    );
        }

        private void showGridBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showGridBox.Checked)
                previewPanel.Controls
                    .OfType<PictureBox>()
                    .ToList()
                    .ForEach(pb => 
                        {
                            pb.BorderStyle = BorderStyle.FixedSingle;
                            pb.Refresh();
                        }
                    );
            else
                previewPanel.Controls
                    .OfType<PictureBox>()
                    .ToList()
                    .ForEach(pb => 
                        {
                            pb.BorderStyle = BorderStyle.None;
                            pb.Refresh();
                        }
                    );
        }

        private void invertTextColorBox_CheckedChanged(object sender, EventArgs e)
        {
            if (invertTextColorBox.Checked)
                previewPanel.Controls.OfType<PictureBox>()
                    .ToList()
                    .ForEach(p => p.Controls
                        .OfType<Label>()
                        .ToList()
                        .ForEach(l => 
                        {
                            l.ForeColor = SystemColors.HighlightText;
                            l.Refresh();
                        })
                    );
            else
                previewPanel.Controls
                    .OfType<PictureBox>()
                    .ToList()
                    .ForEach(p => p.Controls
                        .OfType<Label>()
                        .ToList()
                        .ForEach(l => 
                        {
                            l.ForeColor = SystemColors.ControlText;
                            l.Refresh();
                        })
                    );
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

