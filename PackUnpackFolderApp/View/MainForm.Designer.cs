namespace PackUnpackFolderApp.View
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
            this.buttonFolderBrowserDialog = new System.Windows.Forms.Button();
            this.buttonPack = new System.Windows.Forms.Button();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.buttonUnpack = new System.Windows.Forms.Button();
            this.textBoxForFolderPath = new System.Windows.Forms.TextBox();
            this.textBoxForFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonProgress = new System.Windows.Forms.Button();
            this.textBoxForUnpackedFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChooseUnpackFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFolderBrowserDialog
            // 
            this.buttonFolderBrowserDialog.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFolderBrowserDialog.Location = new System.Drawing.Point(390, 19);
            this.buttonFolderBrowserDialog.Name = "buttonFolderBrowserDialog";
            this.buttonFolderBrowserDialog.Size = new System.Drawing.Size(39, 23);
            this.buttonFolderBrowserDialog.TabIndex = 0;
            this.buttonFolderBrowserDialog.Text = ". . .";
            this.buttonFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.buttonFolderBrowserDialog.Click += new System.EventHandler(this.buttonFolderBrowserDialog_Click);
            // 
            // buttonPack
            // 
            this.buttonPack.Enabled = false;
            this.buttonPack.Location = new System.Drawing.Point(435, 19);
            this.buttonPack.Name = "buttonPack";
            this.buttonPack.Size = new System.Drawing.Size(75, 23);
            this.buttonPack.TabIndex = 1;
            this.buttonPack.Text = "Pack";
            this.buttonPack.UseVisualStyleBackColor = true;
            this.buttonPack.Click += new System.EventHandler(this.buttonPack_Click);
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(390, 60);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(39, 22);
            this.buttonOpenFileDialog.TabIndex = 2;
            this.buttonOpenFileDialog.Text = ". . . ";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // buttonUnpack
            // 
            this.buttonUnpack.Enabled = false;
            this.buttonUnpack.Location = new System.Drawing.Point(435, 60);
            this.buttonUnpack.Name = "buttonUnpack";
            this.buttonUnpack.Size = new System.Drawing.Size(75, 22);
            this.buttonUnpack.TabIndex = 3;
            this.buttonUnpack.Text = "Unpack";
            this.buttonUnpack.UseVisualStyleBackColor = true;
            this.buttonUnpack.Click += new System.EventHandler(this.buttonUnpack_Click);
            // 
            // textBoxForFolderPath
            // 
            this.textBoxForFolderPath.Location = new System.Drawing.Point(9, 21);
            this.textBoxForFolderPath.Name = "textBoxForFolderPath";
            this.textBoxForFolderPath.ReadOnly = true;
            this.textBoxForFolderPath.Size = new System.Drawing.Size(375, 20);
            this.textBoxForFolderPath.TabIndex = 4;
            // 
            // textBoxForFilePath
            // 
            this.textBoxForFilePath.Location = new System.Drawing.Point(9, 61);
            this.textBoxForFilePath.Name = "textBoxForFilePath";
            this.textBoxForFilePath.ReadOnly = true;
            this.textBoxForFilePath.Size = new System.Drawing.Size(375, 20);
            this.textBoxForFilePath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a folder that has to be packed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select a file that has to be unpacked ";
            // 
            // buttonProgress
            // 
            this.buttonProgress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProgress.BackColor = System.Drawing.SystemColors.Control;
            this.buttonProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonProgress.Enabled = false;
            this.buttonProgress.FlatAppearance.BorderSize = 0;
            this.buttonProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProgress.Location = new System.Drawing.Point(0, 132);
            this.buttonProgress.Name = "buttonProgress";
            this.buttonProgress.Size = new System.Drawing.Size(522, 39);
            this.buttonProgress.TabIndex = 9;
            this.buttonProgress.TabStop = false;
            this.buttonProgress.UseVisualStyleBackColor = false;
            // 
            // textBoxForUnpackedFolder
            // 
            this.textBoxForUnpackedFolder.Location = new System.Drawing.Point(9, 101);
            this.textBoxForUnpackedFolder.Name = "textBoxForUnpackedFolder";
            this.textBoxForUnpackedFolder.ReadOnly = true;
            this.textBoxForUnpackedFolder.Size = new System.Drawing.Size(375, 20);
            this.textBoxForUnpackedFolder.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select a folder where the file has to be unpacked";
            // 
            // buttonChooseUnpackFolder
            // 
            this.buttonChooseUnpackFolder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseUnpackFolder.Location = new System.Drawing.Point(390, 100);
            this.buttonChooseUnpackFolder.Name = "buttonChooseUnpackFolder";
            this.buttonChooseUnpackFolder.Size = new System.Drawing.Size(120, 22);
            this.buttonChooseUnpackFolder.TabIndex = 12;
            this.buttonChooseUnpackFolder.Text = ". . .";
            this.buttonChooseUnpackFolder.UseVisualStyleBackColor = true;
            this.buttonChooseUnpackFolder.Click += new System.EventHandler(this.buttonChooseUnpackFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 171);
            this.Controls.Add(this.buttonChooseUnpackFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxForUnpackedFolder);
            this.Controls.Add(this.buttonProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForFilePath);
            this.Controls.Add(this.textBoxForFolderPath);
            this.Controls.Add(this.buttonUnpack);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.buttonPack);
            this.Controls.Add(this.buttonFolderBrowserDialog);
            this.Name = "MainForm";
            this.Text = "PackUnpackFolderApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFolderBrowserDialog;
        private System.Windows.Forms.Button buttonPack;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.Button buttonUnpack;
        private System.Windows.Forms.TextBox textBoxForFolderPath;
        private System.Windows.Forms.TextBox textBoxForFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonProgress;
        private System.Windows.Forms.TextBox textBoxForUnpackedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChooseUnpackFolder;
    }
}

