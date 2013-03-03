using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace GameSync
{
    public partial class settingsForm : MetroForm
    {
        public settingsForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.customPath != "")
            {
                chk.Checked = true;
                locationBox.Text = Properties.Settings.Default.customPath;
            }
            startupChk.Checked = Properties.Settings.Default.openOnStartup;
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            string folderPath = locationBox.Text;
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowser.SelectedPath;
                locationBox.Text = folderPath;
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (chk.Checked)
            {
                chooseButton.Enabled = true;
                locationBox.Enabled = true;
            }
            else
            {
                chooseButton.Enabled = false;
                locationBox.Enabled = false;
                locationBox.Text = "";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.customPath = Utility.AddTrailingSlash(locationBox.Text);
            Properties.Settings.Default.openOnStartup = startupChk.Checked;
            Utility.SetStartup(startupChk.Checked);
            Properties.Settings.Default.Save();
            this.Close();
        }
        /*
        private void chooseInstall_Click(object sender, EventArgs e)
        {
            string folderPath = installPath.Text;
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowser.SelectedPath;
                installPath.Text = folderPath;
            }
        }
        */
        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pastLogin = false;
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
