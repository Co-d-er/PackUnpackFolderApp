using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PackUnpackFolderApp.View
{
    public partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();
        }        

        public string TextBoxForFilePath
        {
            get
            {
                return textBoxForFilePath.Text;
            }
        }

        public string TextBoxForFolderPath
        {
            get
            {
                return textBoxForFolderPath.Text;
            }
        }

        public string TextBoxForUnpackedFolder
        {
            get
            {
                return textBoxForUnpackedFolder.Text;
            }
        }

        public event EventHandler ButtonPackClick;
        public event EventHandler ButtonUnpackClick;

        private void buttonUnpack_Click(object sender, EventArgs e)
        {
            if (ButtonUnpackClick != null) ButtonUnpackClick(this, EventArgs.Empty);
        }

        private void buttonPack_Click(object sender, EventArgs e)
        {
            if (ButtonPackClick != null) ButtonPackClick(this, EventArgs.Empty);           
        }

        private void buttonFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxForFolderPath.Text = folderBrowserDialog.SelectedPath;
                buttonPack.Enabled = true;
            }
        }

        private void buttonChooseUnpackFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxForUnpackedFolder.Text = folderBrowserDialog.SelectedPath;
                if (textBoxForFilePath.Text != "")
                {
                    buttonUnpack.Enabled = true;
                }
            }
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "bak files (*.bak)|*.bak";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxForFilePath.Text = openFileDialog.FileName;
                if(textBoxForUnpackedFolder.Text != "")
                {
                    buttonUnpack.Enabled = true;
                }
            }
        }

        public void ShowMessage()
        {
            MessageBox.Show("Completed!!!");
        }

        public void Loading()
        {
            buttonProgress.BackColor = Color.Blue;
            buttonProgress.Text = "Please wait...";
        }

        public void Done()
        {
            buttonProgress.BackColor = Color.Lime;
            buttonProgress.Text = "Done!";
        }

        public void Block()
        {
            buttonPack.Enabled = false;
            buttonUnpack.Enabled = false;
            buttonChooseUnpackFolder.Enabled = false;
            buttonFolderBrowserDialog.Enabled = false;
            buttonOpenFileDialog.Enabled = false;           
        }

        public void Unblock()
        {
            buttonChooseUnpackFolder.Enabled = true;
            buttonFolderBrowserDialog.Enabled = true;
            buttonOpenFileDialog.Enabled = true;

            textBoxForFilePath.Text = "";
            textBoxForUnpackedFolder.Text = "";
            textBoxForFolderPath.Text = "";
        }

        public void OpenCurrentDirectory(string directoryPath)
        {
            Process.Start(directoryPath);
        }
    }
}
