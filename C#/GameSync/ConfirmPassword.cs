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
    public partial class ConfirmPassword : MetroForm
    {
        public ConfirmPassword()
        {
            InitializeComponent();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public string getPassword()
        {
            return passwordText.Text;
        }
    }
}
