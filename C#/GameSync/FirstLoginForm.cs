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
using Microsoft.Win32;

namespace GameSync
{
    public partial class FirstLoginForm : MetroForm
    {
        public FirstLoginForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.openOnStartup = startupChk.Checked;
            Utility.SetStartup(startupChk.Checked);
            this.Close();
        }
    }
}
