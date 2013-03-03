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
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace GameSync
{
    public partial class AddGame : MetroForm
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            string folderPath = saveBox.Text;
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowser.SelectedPath;
                saveBox.Text = folderPath;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string spath = Application.UserAppDataPath + "\\customgames.xml";
            if (!File.Exists(spath))
            {
                using (XmlWriter writer = XmlWriter.Create(spath))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Games");
                    writer.WriteStartElement("Game");
                    writer.WriteAttributeString("title", nameBox.Text);

                    //writer.WriteElementString("ID", employee.Id.ToString());   // <-- These are new7
                    //writer.WriteElementString("title", nameBox.Text);
                    writer.WriteElementString("path", saveBox.Text);

                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Dispose();
                }
            }
            else
            {
                XDocument doc = XDocument.Load(spath);
                XElement root = new XElement("Game");
                root.Add(new XAttribute("title", nameBox.Text));
                root.Add(new XElement("path", saveBox.Text));
                doc.Element("Games").Add(root);
                doc.Save(spath);     
                
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
