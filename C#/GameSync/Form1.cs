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
using System.Net;
using System.Threading;
using System.IO;

namespace GameSync
{
    public partial class Form1 : MetroAppForm
    {
        public Form1(string[] args)
        {
            InitializeComponent();
            checkForUpdate();
            if (args.Length == 2)
                if (args[1] == "delete")
                {
                    System.IO.File.Delete(args[0]);
                    MessageBoxEx.Show("Your file has been updated successfully!", "Update Successful");
                }
            userLBox.Text = Properties.Settings.Default.username;
            passLBox.Text = Properties.Settings.Default.password;

            if (Properties.Settings.Default.password != "")
            {
                loginButton.Enabled = false;
                login();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        #region Update
        public void checkForUpdate()
        {
            WebClient wc = new WebClient();
            if (!File.Exists(Application.UserAppDataPath + "\\ErrorReport.exe"))
            {
                wc.DownloadFile("http://www.gamecloud.xantecgames.com/ErrorReport.exe", Application.UserAppDataPath + "\\ErrorReport.exe");
            }

            //Download the data of your XML file.
            try
            {
                string XMLContent = wc.DownloadString("http://www.gamecloud.xantecgames.com/update.xml");

                //Create our XmlDocument
                //We will use this to read our XmlNodex.
                System.Xml.XmlDocument Doc = new System.Xml.XmlDocument();

                //Load the data into our XmlDocument.
                Doc.LoadXml(XMLContent);

                string Version = Doc.SelectSingleNode("latest/version").InnerText;

                //Select the node called 'download' that is a sub-node of 'latest', and get the text.
                string DownloadLink = Doc.SelectSingleNode("latest/download").InnerText;
                string changes = Doc.SelectSingleNode("latest/changes").InnerText;
                string DownloadPath = Path.GetRandomFileName();

                if (Version != this.ProductVersion)
                {
                    MessageBoxEx.Show("A new version of Game Cloud has been released. New features include : \n" + changes);
                    Updater updater = new Updater();
                    updater.Show();
                }
            }
            catch (WebException we)
            {
                this.Hide();
                MessageBoxEx.Show(we.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
        #endregion
        #region Buttons
        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            register();
        }

        private void metroTabItem2_Click(object sender, EventArgs e)
        {
            this.AcceptButton = registerButton;
        }

        private void metroTabItem1_Click(object sender, EventArgs e)
        {
            this.AcceptButton = loginButton;
        }
        #endregion

        private void login()
        {
            string username = userLBox.Text;
            string password = MD5Gen.Calculate(passLBox.Text + "ju8y6eRqge9VQwdW");
            WebClient wc = new WebClient();
            string uri = "http://www.gamecloud.xantecgames.com/login.php";

            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string vers2 = version.Replace(".", "");

            string param = "?username=" + username + "&password=" + password + "&version=" + vers2;
            string url = uri + param;
            //try
            //{
                wc.DownloadDataAsync(new Uri(url));
                wc.DownloadDataCompleted += wc_DownloadDataCompleted;
            //}
            
        }

        void wc_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            string username = userLBox.Text;
            string password = MD5Gen.Calculate(passLBox.Text + "ju8y6eRqge9VQwdW");
            byte[] response = e.Result;
            string results = Encoding.ASCII.GetString(response);

            string preHash = username + "ju8y6eRqge9VQwdW" + password;
            string hashCheck = MD5Gen.Calculate(preHash);
            if (string.Equals(hashCheck, results, StringComparison.OrdinalIgnoreCase))
            {
                WebClient wc = new WebClient();
                this.Hide();
                string uri = "http://www.gamecloud.xantecgames.com/makeStatus.php";
                string param = "?status=ON&user=" + Properties.Settings.Default.username;
                string url = uri + param;
                byte[] dlData = wc.DownloadData(url);
                results = Encoding.ASCII.GetString(dlData);
                //save correct info
                Properties.Settings.Default.username = userLBox.Text;
                Properties.Settings.Default.password = passLBox.Text;
                Properties.Settings.Default.Save();

                Syncer syncer = new Syncer();
                syncer.Show();
            }
            else
            {
                loginButton.Enabled = true;
                MessageBoxEx.Show(results);
            }
        }

        private void register()
        {
            string username = userRBox.Text;
            string password = passRBox.Text;
            string cpassword = cPassRBox.Text;
            string email = emailBox.Text;
            WebClient wc = new WebClient();
            string uri = "http://www.gamecloud.xantecgames.com/register.php";
            string param = "?username=" + username + "&password=" + password + "&email=" + email;
            string url = uri + param;
            byte[] response = wc.DownloadData(url);
            string results = Encoding.ASCII.GetString(response);
            MessageBoxEx.Show(results);
            userLBox.Text = userRBox.Text;
            passLBox.Text = passRBox.Text;
        }

        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            if (e.ControlToValidate.Text == "DotNetBar")
                e.IsValid = true;
            else
                e.IsValid = false;
        }
    }
}
