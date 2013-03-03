using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace GameSync
{
    public partial class ReportBug : MetroForm
    {
        public ReportBug()
        {
            InitializeComponent();
            prepareRegister();
            List<string> types = new List<string>()
            {
                "Suggestion", 
                "Bug"
            };
            reportType.DataSource = types;
        }

        string RandomString(int length, string allowedChars = "abcdefghjkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789")
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length", "length cannot be less than zero.");
            if (string.IsNullOrEmpty(allowedChars)) throw new ArgumentException("allowedChars may not be empty.");

            const int byteSize = 0x100;
            var allowedCharSet = new HashSet<char>(allowedChars).ToArray();
            if (byteSize < allowedCharSet.Length) throw new ArgumentException(String.Format("allowedChars may contain no more than {0} characters.", byteSize));

            // Guid.NewGuid and System.Random are not particularly random. By using a
            // cryptographically-secure random number generator, the caller is always
            // protected, regardless of use.
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                var result = new StringBuilder();
                var buf = new byte[128];
                while (result.Length < length)
                {
                    rng.GetBytes(buf);
                    for (var i = 0; i < buf.Length && result.Length < length; ++i)
                    {
                        // Divide the byte into allowedCharSet-sized groups. If the
                        // random value falls into the last group and the last group is
                        // too small to choose from the entire allowedCharSet, ignore
                        // the value in order to avoid biasing the result.
                        var outOfRangeStart = byteSize - (byteSize % allowedCharSet.Length);
                        if (outOfRangeStart <= buf[i]) continue;
                        result.Append(allowedCharSet[buf[i] % allowedCharSet.Length]);
                    }
                }
                return result.ToString();
            }
        }
        string capString;
        private void prepareRegister()
        {
            captchaPic.Image = null;
            //this.Height = 502;
            capString = RandomString(10);
            // Kreiramo bmp file (sliku koja ce se kasnije prikazati u pictureBox1 kontroli).
            Bitmap bmp = new Bitmap(264, 60);
            Graphics gImage = Graphics.FromImage(bmp);
            gImage.FillRectangle(Brushes.BlanchedAlmond, 0, 0, bmp.Width, bmp.Height);
            // Odredjujemo font, boju teksta i deklarisemo DrawString metodu.
            Font CAPTCHAfont = new Font("Chiller", 24);
            Brush cetka = Brushes.Black;
            gImage.DrawString(capString, CAPTCHAfont, cetka, 0, 10);
            // Dodajemo linije preko teksta, da je (SPAM)programima teze procitati tekst.
            Pen p = new Pen(Color.Gray, 2);
            Random random = new Random();
            gImage.DrawLine(p, 230, random.Next(10, 40), 10, random.Next(10, 40));
            gImage.DrawLine(p, 230, random.Next(10, 40), 10, random.Next(10, 40));
            gImage.DrawLine(p, 230, random.Next(10, 40), 10, random.Next(10, 40));
            // Dodjeljujemo ime bmp fajlu.
            // Sacuvavamo bmp file.
            string rando = RandomString(16);
            bmp.Save(Application.UserAppDataPath + @"\captcha" + capString + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            //Prikazujemo bmp file u pictureBox kontroli.
            captchaPic.Image = new Bitmap(Application.UserAppDataPath + @"\captcha" + capString + ".bmp");
        }

        private void newCaptcha_Click(object sender, EventArgs e)
        {
            prepareRegister();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (capString == captchaBox.Text)
            {
                if (Properties.Settings.Default.username == "")
                {
                    MessageBoxEx.Show("You must have logged into Game Cloud atleast once to submit a bug report/suggestion");
                }
                else
                {

                    WebClient wc = new WebClient();
                    string uri = "http://gamecloud.xantecgames.com/report.php";
                    string param = "?type=" + reportType.Text + "&title=" + titleBox.Text + "&body=" + bodyText.Text + "&username=" + Properties.Settings.Default.username;
                    string url = uri + param;
                    byte[] response = wc.DownloadData(url);
                    string results = Encoding.ASCII.GetString(response);
                    if (results == "Complete")
                    {
                        MessageBox.Show("Thank you. Your request has been sent.");
                        this.Close();
                    }
                    else if (results == "incomplete")
                    {
                        MessageBoxEx.Show("Please fill out all of the fields before sending your request.");
                    }
                    else
                    {
                        MessageBoxEx.Show("An error occured.");
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("The captcha you entered did not match the captcha image.");
            }
        }
    }
}
