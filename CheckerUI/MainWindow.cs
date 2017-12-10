using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tabGeneral_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDownload_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowseCheckerDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = "Select Checker Base Directory",
                ShowNewFolderButton = false,
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textCheckerDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = "Select Downloads Directory",
                ShowNewFolderButton = false,
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textDownloads.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
