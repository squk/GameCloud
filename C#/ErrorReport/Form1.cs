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
using System.IO;
using System.Net;
using System.Web;

namespace ErrorReport
{
    public partial class Form1 : MetroForm
{
    private static string _PostURI = "http://gamecloud.xantecgames.com/reporterror.php";
    private FileInfo _ErrorFile;
 
    public Form1(FileInfo errorFile)
    {
        _ErrorFile = errorFile;

        InitializeComponent();

        using (StreamReader reader = File.OpenText(errorFile.FullName))
        {
            richTextBoxEx2.Text = reader.ReadToEnd();
        }
    }
    bool sent = false;
    private void ErrorReport_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        /*
        if (!sent)
        {
            if (MessageBox.Show("Are you sure you want to exit without sending the error report?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                e.Cancel = true;
        }
         * */
        MessageBoxEx.Show("Nope. Send that shit. ");
    }
 
    private void buttonSend_Click(object sender, EventArgs e)
    {
        string data = "?name=" + HttpUtility.UrlEncode(_ErrorFile.Name) + "&desc=" + HttpUtility.UrlEncode(richTextBoxEx1.Text);

        WebClient wc = new WebClient();
        string uri = "http://www.gamecloud.xantecgames.com/reporterror.php";

        string url = uri + data;
        byte[] response = wc.UploadFile(url, "PUT", _ErrorFile.FullName);

        string results = Encoding.ASCII.GetString(response);

        if (results == "YAY")
        {
            sent = true;
            MessageBox.Show("Thank you for sending your error report!", "Error Report Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        else
        {
            MessageBox.Show("There appears to be an error with the system. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
 
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        //Application.Exit();
        MessageBox.Show("Nope. Send that shit!");
    }
}
}
