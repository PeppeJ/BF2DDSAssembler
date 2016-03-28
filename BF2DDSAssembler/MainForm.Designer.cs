namespace BF2DDSAssembler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.loadFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.combineButton = new System.Windows.Forms.Button();
            this.saveLargeFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.openLargeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveSeperateImagesButton = new System.Windows.Forms.Button();
            this.colormapRadio = new System.Windows.Forms.RadioButton();
            this.imageOptionsBox = new System.Windows.Forms.GroupBox();
            this.editorFolderBox = new System.Windows.Forms.CheckBox();
            this.detailmapRadio = new System.Windows.Forms.RadioButton();
            this.detailSuffixBox = new System.Windows.Forms.GroupBox();
            this.suffix6radio = new System.Windows.Forms.RadioButton();
            this.suffix5radio = new System.Windows.Forms.RadioButton();
            this.suffix4radio = new System.Windows.Forms.RadioButton();
            this.suffix3radio = new System.Windows.Forms.RadioButton();
            this.suffix2radio = new System.Windows.Forms.RadioButton();
            this.suffix1radio = new System.Windows.Forms.RadioButton();
            this.loadSaveLabel = new System.Windows.Forms.Label();
            this.displayOptionsGroup = new System.Windows.Forms.GroupBox();
            this.showCoordinateBox = new System.Windows.Forms.CheckBox();
            this.showGridBox = new System.Windows.Forms.CheckBox();
            this.invertTextColorBox = new System.Windows.Forms.CheckBox();
            this.useCudaBox = new System.Windows.Forms.CheckBox();
            this.imageOptionsBox.SuspendLayout();
            this.detailSuffixBox.SuspendLayout();
            this.displayOptionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(632, 327);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(102, 81);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Load folder..";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderClick);
            // 
            // previewPanel
            // 
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPanel.Location = new System.Drawing.Point(12, 12);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(512, 512);
            this.previewPanel.TabIndex = 1;
            // 
            // combineButton
            // 
            this.combineButton.Enabled = false;
            this.combineButton.Location = new System.Drawing.Point(530, 472);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(202, 52);
            this.combineButton.TabIndex = 2;
            this.combineButton.Text = "Combine to single image";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineClick);
            // 
            // saveLargeFileDialog
            // 
            this.saveLargeFileDialog.FileName = "output";
            this.saveLargeFileDialog.Filter = "PNG File|*.png";
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(530, 327);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(100, 81);
            this.loadImageButton.TabIndex = 3;
            this.loadImageButton.Text = "Load image..";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.splitImageButton_Click);
            // 
            // openLargeFileDialog
            // 
            this.openLargeFileDialog.Filter = "PNG Image|*.png";
            // 
            // saveSeperateImagesButton
            // 
            this.saveSeperateImagesButton.Enabled = false;
            this.saveSeperateImagesButton.Location = new System.Drawing.Point(530, 414);
            this.saveSeperateImagesButton.Name = "saveSeperateImagesButton";
            this.saveSeperateImagesButton.Size = new System.Drawing.Size(204, 52);
            this.saveSeperateImagesButton.TabIndex = 4;
            this.saveSeperateImagesButton.Text = "Save as seperate images";
            this.saveSeperateImagesButton.UseVisualStyleBackColor = true;
            this.saveSeperateImagesButton.Click += new System.EventHandler(this.saveImages_Click);
            // 
            // colormapRadio
            // 
            this.colormapRadio.AutoSize = true;
            this.colormapRadio.Checked = true;
            this.colormapRadio.Location = new System.Drawing.Point(6, 19);
            this.colormapRadio.Name = "colormapRadio";
            this.colormapRadio.Size = new System.Drawing.Size(69, 17);
            this.colormapRadio.TabIndex = 5;
            this.colormapRadio.TabStop = true;
            this.colormapRadio.Text = "Colormap";
            this.colormapRadio.UseVisualStyleBackColor = true;
            this.colormapRadio.CheckedChanged += new System.EventHandler(this.colormapRadio_CheckedChanged);
            // 
            // imageOptionsBox
            // 
            this.imageOptionsBox.Controls.Add(this.useCudaBox);
            this.imageOptionsBox.Controls.Add(this.editorFolderBox);
            this.imageOptionsBox.Controls.Add(this.detailmapRadio);
            this.imageOptionsBox.Controls.Add(this.colormapRadio);
            this.imageOptionsBox.Location = new System.Drawing.Point(530, 185);
            this.imageOptionsBox.Name = "imageOptionsBox";
            this.imageOptionsBox.Size = new System.Drawing.Size(100, 136);
            this.imageOptionsBox.TabIndex = 6;
            this.imageOptionsBox.TabStop = false;
            this.imageOptionsBox.Text = "Image Options";
            // 
            // editorFolderBox
            // 
            this.editorFolderBox.AutoSize = true;
            this.editorFolderBox.Checked = true;
            this.editorFolderBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editorFolderBox.Location = new System.Drawing.Point(6, 113);
            this.editorFolderBox.Name = "editorFolderBox";
            this.editorFolderBox.Size = new System.Drawing.Size(85, 17);
            this.editorFolderBox.TabIndex = 7;
            this.editorFolderBox.Text = "Editor Folder";
            this.editorFolderBox.UseVisualStyleBackColor = true;
            // 
            // detailmapRadio
            // 
            this.detailmapRadio.AutoSize = true;
            this.detailmapRadio.Location = new System.Drawing.Point(6, 42);
            this.detailmapRadio.Name = "detailmapRadio";
            this.detailmapRadio.Size = new System.Drawing.Size(72, 17);
            this.detailmapRadio.TabIndex = 6;
            this.detailmapRadio.Text = "Detailmap";
            this.detailmapRadio.UseVisualStyleBackColor = true;
            // 
            // detailSuffixBox
            // 
            this.detailSuffixBox.Controls.Add(this.suffix6radio);
            this.detailSuffixBox.Controls.Add(this.suffix5radio);
            this.detailSuffixBox.Controls.Add(this.suffix4radio);
            this.detailSuffixBox.Controls.Add(this.suffix3radio);
            this.detailSuffixBox.Controls.Add(this.suffix2radio);
            this.detailSuffixBox.Controls.Add(this.suffix1radio);
            this.detailSuffixBox.Enabled = false;
            this.detailSuffixBox.Location = new System.Drawing.Point(634, 185);
            this.detailSuffixBox.Name = "detailSuffixBox";
            this.detailSuffixBox.Size = new System.Drawing.Size(100, 136);
            this.detailSuffixBox.TabIndex = 7;
            this.detailSuffixBox.TabStop = false;
            this.detailSuffixBox.Text = "Detail Channel";
            this.detailSuffixBox.EnabledChanged += new System.EventHandler(this.detailSuffixBox_EnabledChanged);
            // 
            // suffix6radio
            // 
            this.suffix6radio.AutoSize = true;
            this.suffix6radio.Enabled = false;
            this.suffix6radio.Location = new System.Drawing.Point(49, 65);
            this.suffix6radio.Name = "suffix6radio";
            this.suffix6radio.Size = new System.Drawing.Size(37, 17);
            this.suffix6radio.TabIndex = 5;
            this.suffix6radio.Text = "_6";
            this.suffix6radio.UseVisualStyleBackColor = true;
            // 
            // suffix5radio
            // 
            this.suffix5radio.AutoSize = true;
            this.suffix5radio.Enabled = false;
            this.suffix5radio.Location = new System.Drawing.Point(6, 65);
            this.suffix5radio.Name = "suffix5radio";
            this.suffix5radio.Size = new System.Drawing.Size(37, 17);
            this.suffix5radio.TabIndex = 4;
            this.suffix5radio.Text = "_5";
            this.suffix5radio.UseVisualStyleBackColor = true;
            // 
            // suffix4radio
            // 
            this.suffix4radio.AutoSize = true;
            this.suffix4radio.Enabled = false;
            this.suffix4radio.Location = new System.Drawing.Point(49, 42);
            this.suffix4radio.Name = "suffix4radio";
            this.suffix4radio.Size = new System.Drawing.Size(37, 17);
            this.suffix4radio.TabIndex = 3;
            this.suffix4radio.Text = "_4";
            this.suffix4radio.UseVisualStyleBackColor = true;
            // 
            // suffix3radio
            // 
            this.suffix3radio.AutoSize = true;
            this.suffix3radio.Enabled = false;
            this.suffix3radio.Location = new System.Drawing.Point(6, 42);
            this.suffix3radio.Name = "suffix3radio";
            this.suffix3radio.Size = new System.Drawing.Size(37, 17);
            this.suffix3radio.TabIndex = 2;
            this.suffix3radio.Text = "_3";
            this.suffix3radio.UseVisualStyleBackColor = true;
            // 
            // suffix2radio
            // 
            this.suffix2radio.AutoSize = true;
            this.suffix2radio.Enabled = false;
            this.suffix2radio.Location = new System.Drawing.Point(49, 19);
            this.suffix2radio.Name = "suffix2radio";
            this.suffix2radio.Size = new System.Drawing.Size(37, 17);
            this.suffix2radio.TabIndex = 1;
            this.suffix2radio.Text = "_2";
            this.suffix2radio.UseVisualStyleBackColor = true;
            // 
            // suffix1radio
            // 
            this.suffix1radio.AutoSize = true;
            this.suffix1radio.Checked = true;
            this.suffix1radio.Enabled = false;
            this.suffix1radio.Location = new System.Drawing.Point(6, 19);
            this.suffix1radio.Name = "suffix1radio";
            this.suffix1radio.Size = new System.Drawing.Size(37, 17);
            this.suffix1radio.TabIndex = 0;
            this.suffix1radio.TabStop = true;
            this.suffix1radio.Text = "_1";
            this.suffix1radio.UseVisualStyleBackColor = true;
            // 
            // loadSaveLabel
            // 
            this.loadSaveLabel.AutoSize = true;
            this.loadSaveLabel.Location = new System.Drawing.Point(527, 169);
            this.loadSaveLabel.Name = "loadSaveLabel";
            this.loadSaveLabel.Size = new System.Drawing.Size(137, 13);
            this.loadSaveLabel.TabIndex = 8;
            this.loadSaveLabel.Text = "Loading and saving options";
            // 
            // displayOptionsGroup
            // 
            this.displayOptionsGroup.Controls.Add(this.showCoordinateBox);
            this.displayOptionsGroup.Controls.Add(this.showGridBox);
            this.displayOptionsGroup.Controls.Add(this.invertTextColorBox);
            this.displayOptionsGroup.Location = new System.Drawing.Point(530, 12);
            this.displayOptionsGroup.Name = "displayOptionsGroup";
            this.displayOptionsGroup.Size = new System.Drawing.Size(209, 100);
            this.displayOptionsGroup.TabIndex = 9;
            this.displayOptionsGroup.TabStop = false;
            this.displayOptionsGroup.Text = "Preview Options";
            // 
            // showCoordinateBox
            // 
            this.showCoordinateBox.AutoSize = true;
            this.showCoordinateBox.Location = new System.Drawing.Point(6, 19);
            this.showCoordinateBox.Name = "showCoordinateBox";
            this.showCoordinateBox.Size = new System.Drawing.Size(75, 17);
            this.showCoordinateBox.TabIndex = 2;
            this.showCoordinateBox.Text = "Show X/Y";
            this.showCoordinateBox.UseVisualStyleBackColor = true;
            this.showCoordinateBox.CheckedChanged += new System.EventHandler(this.showTextBox_CheckedChanged);
            // 
            // showGridBox
            // 
            this.showGridBox.AutoSize = true;
            this.showGridBox.Location = new System.Drawing.Point(6, 42);
            this.showGridBox.Name = "showGridBox";
            this.showGridBox.Size = new System.Drawing.Size(75, 17);
            this.showGridBox.TabIndex = 1;
            this.showGridBox.Text = "Show Grid";
            this.showGridBox.UseVisualStyleBackColor = true;
            this.showGridBox.CheckedChanged += new System.EventHandler(this.showGridBox_CheckedChanged);
            // 
            // invertTextColorBox
            // 
            this.invertTextColorBox.AutoSize = true;
            this.invertTextColorBox.Location = new System.Drawing.Point(98, 19);
            this.invertTextColorBox.Name = "invertTextColorBox";
            this.invertTextColorBox.Size = new System.Drawing.Size(104, 17);
            this.invertTextColorBox.TabIndex = 0;
            this.invertTextColorBox.Text = "Invert Text Color";
            this.invertTextColorBox.UseVisualStyleBackColor = true;
            this.invertTextColorBox.CheckedChanged += new System.EventHandler(this.invertTextColorBox_CheckedChanged);
            // 
            // useCudaBox
            // 
            this.useCudaBox.AutoSize = true;
            this.useCudaBox.Checked = true;
            this.useCudaBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCudaBox.Location = new System.Drawing.Point(6, 90);
            this.useCudaBox.Name = "useCudaBox";
            this.useCudaBox.Size = new System.Drawing.Size(78, 17);
            this.useCudaBox.TabIndex = 8;
            this.useCudaBox.Text = "Use CUDA";
            this.useCudaBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 532);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.displayOptionsGroup);
            this.Controls.Add(this.saveSeperateImagesButton);
            this.Controls.Add(this.loadSaveLabel);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.detailSuffixBox);
            this.Controls.Add(this.imageOptionsBox);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.previewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = " BF2Editor DDS Assembler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.imageOptionsBox.ResumeLayout(false);
            this.imageOptionsBox.PerformLayout();
            this.detailSuffixBox.ResumeLayout(false);
            this.detailSuffixBox.PerformLayout();
            this.displayOptionsGroup.ResumeLayout(false);
            this.displayOptionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.FolderBrowserDialog loadFolderDialog;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.SaveFileDialog saveLargeFileDialog;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.OpenFileDialog openLargeFileDialog;
        private System.Windows.Forms.Button saveSeperateImagesButton;
        private System.Windows.Forms.RadioButton colormapRadio;
        private System.Windows.Forms.GroupBox imageOptionsBox;
        private System.Windows.Forms.RadioButton detailmapRadio;
        private System.Windows.Forms.GroupBox detailSuffixBox;
        private System.Windows.Forms.RadioButton suffix6radio;
        private System.Windows.Forms.RadioButton suffix5radio;
        private System.Windows.Forms.RadioButton suffix4radio;
        private System.Windows.Forms.RadioButton suffix3radio;
        private System.Windows.Forms.RadioButton suffix2radio;
        private System.Windows.Forms.RadioButton suffix1radio;
        private System.Windows.Forms.Label loadSaveLabel;
        private System.Windows.Forms.GroupBox displayOptionsGroup;
        private System.Windows.Forms.CheckBox showCoordinateBox;
        private System.Windows.Forms.CheckBox showGridBox;
        private System.Windows.Forms.CheckBox invertTextColorBox;
        private System.Windows.Forms.CheckBox editorFolderBox;
        private System.Windows.Forms.CheckBox useCudaBox;
    }
}

