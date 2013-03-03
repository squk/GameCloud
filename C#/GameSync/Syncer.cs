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
using Microsoft.Win32;
using System.Net;
using System.Threading;
using Ionic.Zip;
using System.Xml;
using DevComponents.AdvTree;
using System.Xml.Linq;
using System.Collections;
using System.Text.RegularExpressions;

namespace GameSync
{
    public partial class Syncer : MetroAppForm
    {
        string ready = "READY";
        public Syncer()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
            if (!Properties.Settings.Default.pastLogin)
            {
                FirstLoginForm firstLogin = new FirstLoginForm();
                firstLogin.ShowDialog();

                //Properties.Settings.Default.pastLogin = true;
                Properties.Settings.Default.pastLogin = true;
                Properties.Settings.Default.Save();
                start();
            }
            else
            {
                start();
            }
            
        }

        #region Initialization
        private void start()
        {
            getGames();
            cancelB.Visible = false;
            cancelR.Visible = false;
        }
        private void Syncer_Load(object sender, EventArgs e)
        {
            //GameSearcher search = new GameSearcher();
            //search.Show();
            //search.BringToFront();
        }
        List<Game> Games = new List<Game>();
        /*
        List<string> gDirectories = new List<string>();
        List<string> namesSource = new List<string>();
        List<string> warningsList = new List<string>();
        List<string> excludeList = new List<string>();
        List<string> includeList = new List<string>();
        */
        public void getGames()
        {
            updateInProgress = true;
            Games.Clear();
             List<Game> games = new List<Game>();
            statusLabel.Text = "SEARCHING FOR GAMES ON YOUR HARDDRIVE";
            var files = new List<string>();
            files.AddRange(Directory.GetFiles(Utility.getLocalEnvironmentPath("APPLICATIONDATA"), "customgames.xml", SearchOption.AllDirectories));
            foreach (string file in files)
            {
                try
                {
                    File.Move(file, Application.UserAppDataPath + "\\customgames.xml");
                }
                catch
                {

                }
            }
            if (File.Exists(Application.UserAppDataPath + "\\customgames.xml"))
            {
                XmlDocument customDoc = new XmlDocument();
                XmlTextReader reader = new XmlTextReader(Application.UserAppDataPath + "\\customgames.xml");
                customDoc.Load(reader);

                XmlNode customListNode = customDoc.SelectSingleNode("Games");
                XmlNodeList customEntrys = customListNode.SelectNodes("Game");
                
                foreach (XmlNode node in customEntrys)
                {
                    string path = node.SelectSingleNode("path").InnerText;
                    string name = node.Attributes.GetNamedItem("title").Value;
                    if (Directory.Exists(path))
                    {
                        //MessageBoxEx.Show(path);
                        games.Add(new Game(name, path, "", "", "", "CUSTOM"));
                    }
                }
                reader.Close();
                reader.Dispose();
            }

            MemoryStream stream = new MemoryStream(Properties.Resources.games);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(stream);

            XmlNode gameListNode = xmlDoc.SelectSingleNode("/GameCloudDB");
            XmlNodeList gameEntrys = gameListNode.SelectNodes("entry");
           

            foreach (XmlNode node in gameEntrys)
            {
                //Console.WriteLine(node.InnerText);
                //string specialPath = node.SelectSingleNode("directories/dir/path").Attributes.GetNamedItem("specialpath").Value;

                XmlNodeList pathNode = node.SelectNodes("directories/dir/path");
                XmlNodeList excludeNode = node.SelectNodes("directories/dir/exclude");
                XmlNodeList includeNode = node.SelectNodes("directories/dir/include");
                XmlNode titleNode = node.SelectSingleNode("title");
                XmlNode bkpWarningNode = node.SelectSingleNode("backupwarning");
                for (int i = 0; i < pathNode.Count; i++)
                {
                    if (pathNode[i] != null && titleNode != null)
                    {
                        string title = replaceAnds(titleNode.InnerText);
                        string path = pathNode[i].InnerText;
                        string special = pathNode[i].Attributes.GetNamedItem("specialpath").Value;
                        string dir = special + replaceAnds(path);
                        //Console.WriteLine(dir);
                        if (title != "" && path != "")
                        {
                            List<string> excF = new List<string>();
                            if (excludeNode[i].InnerText != "")
                            {
                                foreach (string exc in excludeNode[i].InnerText.Split('|'))
                                {
                                    excF.Add(exc);
                                    //excludeNode.Console.WriteLine(dir + exc);
                                }
                            }

                            List<string> incF = new List<string>();
                            if (includeNode[i].InnerText != "")
                            {
                                foreach (string inc in includeNode[i].InnerText.Split('|'))
                                {
                                    incF.Add(inc);
                                    //excludeNode.Console.WriteLine(dir + exc);
                                }
                            }
                            //Console.WriteLine(dir + "\n" + replaceSpecials(dir));
                            if (Directory.Exists(Utility.replaceSpecials(dir)))
                            {
                                games.Add(new Game(title, dir, bkpWarningNode.InnerText, string.Join("|", excF), string.Join("|", incF), "STOCK"));
                            }
                        }
                    }
                }
            }
            stream.Close();
            for (int i = 0; i < games.Count; i++)
            {
                Console.WriteLine(games[i].Location);
                double perc = (double)i / games.Count * 100;
                progressBarX1.Value = (int)perc;
                progressBarX2.Value = (int)perc;
                //Console.WriteLine("Processing " + games[i].Name);
                Games.Add(games[i]);
            }

            localGamesTree.Nodes.Clear();
            for (int i = 0; i < Games.Count; i++)
            {
                Node node = new Node(Games[i].Name);
                
                if (Games[i].Warning != "")
                {
                    node.Image = Properties.Resources.sign_warning;
                    node.Tooltip = Games[i].Warning;
                }
                node.CheckBoxVisible = true;
                localGamesTree.Nodes.Add(node);
            }
            //gamesListBox.DataSource = null;
            //gamesListBox.DataSource = namesSource;
            statusLabel.Text = ready;
            progressBarX1.Value = 0;
            progressBarX2.Value = 0;
            updateInProgress = false;
        }

        

        public string replaceAnds(string code)
        {
            string finished = code.Replace("%and%", "&");
            return finished;
        }

        #endregion

        /// <summary>
        /// BUTTONS
        /// </summary>
        
        #region Buttons
        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            string spath = Application.UserAppDataPath + "\\customgames.xml";
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = new XmlTextReader(Application.UserAppDataPath + "\\customgames.xml");
            doc.Load(reader);
            reader.Close();
            XmlNode customListNode = doc.SelectSingleNode("Games");
            XmlNodeList customEntrys = customListNode.SelectNodes("Game");

            foreach (XmlNode node in customEntrys)
            {
                string name = node.Attributes.GetNamedItem("title").Value;
                if (name == Games[localGamesTree.SelectedIndex].Name)
                {
                    node.ParentNode.RemoveChild(node);
                }

            }

            doc.Save(Application.UserAppDataPath + "\\customgames.xml");
            getGames();
        }  
        private void refreshButton_Click(object sender, EventArgs e)
        {
            getServerGames();
        }
        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            statusLabel.Text = "SEARCHING FOR GAMES ON YOUR HARDDRIVE";
            getGames();
        }
        private void restoreTab_Click(object sender, EventArgs e)
        {
            getServerGames();
            detailLabel.Text = "";
        }

        private void backupTab_Click(object sender, EventArgs e)
        {
            detailLabel.Text = "";
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            if (localGamesTree.CheckedNodes.Count > 0)
            {
                UploadCheckedToServer();
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (serverGamesTree.CheckedNodes.Count > 0)
            {
                downloadCheckedGames();
            }
        }
        private void cancelR_Click(object sender, EventArgs e)
        {
            //indD = 0;
            statusLabel.Text = ready;
            if (webClientU != null)
            {
                webClientD.CancelAsync();
            }
            cancelR.Visible = false;
            progressBarX1.Value = 0;
            progressBarX2.Value = 0;
            downloadButton.Enabled = true;
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            //ind = 0;
            statusLabel.Text = ready;
            if(webClientU != null)
            {
                webClientU.CancelAsync();
            }
            progressBarX1.Value = 0;
            progressBarX2.Value = 0;
            syncButton.Enabled = true;
            cancelB.Visible = false;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm();
            settings.Show();
        }

        private void deleteFromServer_Click(object sender, EventArgs e)
        {
            if (serverGamesTree.CheckedNodes.Count > 0)
            {
                List<string> deletes = new List<string>();

                foreach (Node node in serverGamesTree.CheckedNodes)
                {
                    deletes.Add(node.Text.ToString());
                }
                string games = String.Join(",", deletes);
                DialogResult dialogResult = MessageBoxEx.Show("Are you sure you would like to delete these saves? \n" + games, "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteSave();
                }
            }
        }

        private void addGame_Click(object sender, EventArgs e)
        {
            AddGame addgame = new AddGame();
            addgame.ShowDialog();
            addgame.Dispose();
            if (addgame.DialogResult == DialogResult.OK)
            {
                getGames();
            }
        }

    #endregion

        /// <summary>
        /// Upload/backup
        /// </summary>
        
        #region Upload/Backup
        int _ind = 0;
        List<int> chkIndexesU = new List<int>();

        public void UploadCheckedToServer()
        {
            chkIndexesU.Clear();
            //check for checked strings
            foreach (Node node in localGamesTree.CheckedNodes)
            {
                chkIndexesU.Add(node.Index);
            }
            ind = 0;
        }

        int upIndex;
        string zipLoc;
        bool updateInProgress = false;
        WebClient webClientU;
        public void upload(int i)
        {
            if (i < chkIndexesU.Count)
            {
                syncButton.Enabled = false;
                updateInProgress = true;
                //cancelB.Visible = true;
                upIndex = chkIndexesU[i];
                statusLabel.Text = "COMPRESSING SAVE";

                zipLoc = zipPath(Games[upIndex].Location, new DirectoryInfo(Games[upIndex].Location).Name, MD5Gen.Calculate(Properties.Settings.Default.username + "ju8y6eRqge9VQwdW"), Games[upIndex].Exclude, Games[upIndex].Include);

                webClientU = new WebClient();
                string uri = "http://www.gamecloud.xantecgames.com/uploadSave.php";
                string param = "?user=" + Properties.Settings.Default.username + "&hash=" + MD5Gen.Calculate(MD5Gen.CalculateFromFile(zipLoc) + "ju8y6eRqge9VQwdW") + "&location=" + Games[upIndex].Location + "&gameName=" + Games[upIndex].Name;
                string url = uri + param;

                webClientU.UploadFileAsync(new Uri(url), "PUT", zipLoc);
                webClientU.UploadProgressChanged += client_UploadProgressChanged;
                webClientU.UploadFileCompleted += client_UploadFileCompleted;
            }
        }
        public int ind
        {
            get { return _ind; }
            set
            {
                _ind = value;
                upload(ind);
            }
        }

        void client_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            double bytesOut = e.BytesSent;
            progressBarX1.Value = e.ProgressPercentage;
            //progressBarX2.Value = e.ProgressPercentage;
            statusLabel.Text = "UPLOADING YOUR \"" + Games[upIndex].Name.ToUpper() + "\" SAVE";
        }

        void client_UploadFileCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            syncButton.Enabled = true;
            updateInProgress = false;
            Console.WriteLine("Web Upload Complete");
            if (e.Cancelled)
            {
                cancelB.Visible = false;
                //webClientU.CleanUp(); // Method that disposes the client and unhooks events
                Console.WriteLine("canceled operation");
                progressBarX1.Value = 0;
                //progressBarX2.Value = 0;
                statusLabel.Text = ready;
                return;
            }
            else
            {
                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.Message);
                }

                byte[] result = e.Result;
                string response = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
                if (response != "Done")
                {
                    MessageBoxEx.Show(response);
                }
                File.Delete(zipLoc);
                ind++;
                
                cancelB.Visible = false;
            }
            progressBarX1.Value = 0;
            //progressBarX2.Value = 0;
            statusLabel.Text = ready;
        }

        private void localGamesTree_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("GetEnvironmentVariables: ");
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in environmentVariables)
            {
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            }
            if (!updateInProgress)
            {
                if (Games[localGamesTree.SelectedIndex].Type == "CUSTOM")
                {
                    deleteGameButton.Visible = true;
                }
                else
                {
                    deleteGameButton.Visible = false;
                }
                detailLabel.Text = GetDirectorySize(Games[localGamesTree.SelectedIndex].Location, Games[localGamesTree.SelectedIndex].Exclude);
            }
        }
        #endregion

        /// <summary>
        /// Download/Recover
        /// </summary>
        
        #region Download/Recover

        private List<string> serverNames = new List<string>();
        private void getServerGames()
        {
            statusLabel.Text = "GETTING GAME INFO FROM SERVER";
            //Thread.Sleep(1000);
            //serverListBox.Items.Clear();
            WebClient wc = new WebClient();
            string uri = "http://www.gamecloud.xantecgames.com/getGames.php";
            string param = "?username=" + Properties.Settings.Default.username;

            string url = uri + param;
            wc.DownloadDataAsync(new Uri(url));
            wc.DownloadDataCompleted += new DownloadDataCompletedEventHandler(DownloadCompleted);
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            //string results = Encoding.ASCII.GetString(response);
            //MessageBoxEx.Show(url + "\n" + results);
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarX1.Value = e.ProgressPercentage;
            //progressBarX2.Value = e.ProgressPercentage;
        }

        List<string> dates = new List<string>();
        List<string> serverListSource = new List<string>();
        List<int> downloadIDs = new List<int>();
        List<string> serverLocs = new List<string>();
        List<string> serverSize = new List<string>();

        public void DownloadCompleted(Object sender, DownloadDataCompletedEventArgs e)
        {
            dates.Clear();
            serverListSource.Clear();
            serverLocs.Clear();
            serverSize.Clear();
            dates.Clear();
            downloadIDs.Clear();
            serverGamesTree.Nodes.Clear();
            byte[] bytes = e.Result;
            string results = Encoding.ASCII.GetString(bytes);
            // do something with the bytes
            List<string> entrys = new List<string>();
            if (results.Contains("\n"))
            {
                foreach (string game in results.Split('\n'))
                {
                    entrys.Add(game);
                }
            }
            else if (results != "")
            {
                entrys.Add(results);
            }
            if (entrys.Count > 0)
            {
                List<double> megs = new List<double>();
                List<double> kils = new List<double>();

                foreach (string entry in entrys)
                {
                    string[] split = entry.Split(',');
                    //serverListBox.Items.Add(split);
                    serverListSource.Add(split[1]);
                    dates.Add(split[2]);
                    downloadIDs.Add(Convert.ToInt32(split[0]));
                    serverLocs.Add(split[3]);
                    serverSize.Add(split[4]);
                    if (split[4].Contains("MB"))
                    {
                        string m = split[4].Replace("MB", "");
                        megs.Add(Convert.ToSingle(m));
                    }
                    else if (split[4].Contains("KB"))
                    {
                        string k = split[4].Replace("KB", "");
                        megs.Add(Convert.ToSingle(k) * 0.000976562);
                    }
                    else if (split[4].Contains("B"))
                    {
                        string b = split[4].Replace("B", "");
                        megs.Add(Convert.ToSingle(b) * 9.53674e-7);
                    }

                    double megT = 0;
                    foreach (double meg in megs)
                    {
                        megT += meg;
                    }
                    serverLabel.Text = "GAMES ON SERVER : " + Math.Round(megT, 2) + "MB";
                }
                foreach (string source in serverListSource)
                {
                    Node node = new Node(source);
                    node.CheckBoxVisible = true;
                    serverGamesTree.Nodes.Add(node);
                }
            }
            statusLabel.Text = ready;
            progressBarX1.Value = 0;
            //progressBarX2.Value = 0;
        }

        List<int> chkIndexesD = new List<int>();

        public void downloadCheckedGames()
        {
            chkIndexesD.Clear();
            //check for checked strings
            foreach (Node node in serverGamesTree.CheckedNodes)
            {
                chkIndexesD.Add(node.Index);
            }
            indD = 0;
        }

        int _indD = 0;

        public int indD
        {
            get { return _indD; }
            set
            {
                _indD = value;
                download(indD);
            }
        }
        int dlIndex = 0;
        WebClient webClientD;
        public void download(int i)
        {
            if (i < chkIndexesD.Count)
            {
                downloadButton.Enabled = false;
                updateInProgress = true;
                cancelR.Visible = true;
                dlIndex = chkIndexesD[i];
                statusLabel.Text = "DOWNLOADING YOUR \"" + serverGamesTree.Nodes[dlIndex].Text.ToString().ToUpper() + "\" SAVE";
                //statusLabel.Refresh();
                
               // string zip = Zippy.zipPath(gDirectories[dlIndex], new DirectoryInfo(gDirectories[dlIndex]).Name, MD5Gen.Calculate(Properties.Settings.Default.password + "ju8y6eRqge9VQwdW"));
                webClientD = new WebClient();
                string uri = "http://www.gamecloud.xantecgames.com/downloadSave.php";
                string param = "?username=" + Properties.Settings.Default.username + "&gameName=" + serverGamesTree.Nodes[dlIndex].Text.ToString() + "&checker=" + MD5Gen.Calculate(Properties.Settings.Default.username + serverGamesTree.Nodes[dlIndex].Text.ToString() + "ju8y6eRqge9VQwdW");
                string url = uri + param;
                //MessageBoxEx.Show(url);
                webClientD.DownloadFileAsync(new Uri(url), Application.UserAppDataPath + @"\" + serverGamesTree.Nodes[dlIndex].Text + ".zip");
                webClientD.DownloadFileCompleted += webClient_DownloadFileCompleted;
                webClientD.DownloadProgressChanged += new DownloadProgressChangedEventHandler(saveDLChanged);
            }
        }

        void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            downloadButton.Enabled = true;
            updateInProgress = false;
            progressBarX1.Value = 0;
            //progressBarX2.Value = 0;
            statusLabel.Text = ready;
            if (e.Cancelled)
            {
                cancelB.Visible = false;
                progressBarX1.Value = 0;
                //progressBarX2.Value = 0;
                statusLabel.Text = ready;
                //webClientU.CleanUp(); // Method that disposes the client and unhooks events
                return;
            }
            else
            {
                try
                {
                    statusLabel.Text = "DECOMPRESSING DOWNLOADED SAVE";
                    if (Properties.Settings.Default.customPath == "")
                    {
                        unzipFile(Application.UserAppDataPath + @"\" + serverGamesTree.Nodes[dlIndex].Text + ".zip", serverLocs[dlIndex], MD5Gen.Calculate(Properties.Settings.Default.username + "ju8y6eRqge9VQwdW"));
                    }
                    else
                    {
                        unzipFile(Application.UserAppDataPath + @"\" + serverGamesTree.Nodes[dlIndex].Text + ".zip", Properties.Settings.Default.customPath + @"\" + serverGamesTree.Nodes[dlIndex].Text, MD5Gen.Calculate(Properties.Settings.Default.username + "ju8y6eRqge9VQwdW"));
                    }
                    File.Delete(Application.UserAppDataPath + @"\" + serverGamesTree.Nodes[dlIndex].Text + ".zip");
                    indD++;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    //MessageBoxEx.Show(ex.ToString());
                }
                // do something with the bytes
            }
        }

        void saveDLChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            statusLabel.Text = "DOWNLOADING YOUR " + serverGamesTree.Nodes[dlIndex].Text.ToString().ToUpper() + " SAVE : " + int.Parse(Math.Truncate(percentage).ToString()) + "%";
            progressBarX1.Value = int.Parse(Math.Truncate(percentage).ToString());
            //progressBarX2.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i = serverGamesTree.SelectedNode.Index;
                try
                {
                    detailLabel.Text = "DATE UPLOADED : " + dates[i] + "\nSIZE ON SERVER : " + serverSize[i];
                }
                catch
                {
                    detailLabel.Text = "DATE UPLOADED : " + "\nSIZE ON SERVER : ";
                }
            }
            catch
            {

            }
        }
        #endregion

        private static string GetDirectorySize(string FolderPath, string exclusions)
        {
            string folderPath = Utility.replaceSpecials(FolderPath);
            string size = "";
                if (exclusions == "")
                {
                    DirectoryInfo di = new DirectoryInfo(folderPath);
                    size = ((FileSize)Convert.ToDouble(di.EnumerateFiles("***", SearchOption.AllDirectories).Sum(fi => fi.Length))).ToString();
                    Console.WriteLine(size);
                }
                else
                {
                    //exclude = exclude.Replace(@"\", @"/");
                    DirectoryInfo di = new DirectoryInfo(folderPath);
                    long files = Convert.ToInt64(di.EnumerateFiles("***", SearchOption.AllDirectories).Sum(fi => fi.Length));
                    Console.WriteLine("Total = " + (FileSize)files);
                    long f2 = 0;

                    long exc = getExclusionSize(folderPath, exclusions);

                    Console.WriteLine("Excluded Files : " + (FileSize)f2);
                    files = files - exc;
                    size = ((FileSize)files).ToString();

                    /*
                    if (exclusions.Contains("|"))
                    {
                        foreach (string exc in exclusions.Split('|'))
                        {
                            string[] excps = Directory.GetFiles(Utility.AddTrailingSlash(folderPath) + exc);
                            foreach (string fileX in excps)
                            {
                                FileAttributes attr = File.GetAttributes(fileX);
                                if((attr & FileAttributes.Directory) == FileAttributes.Directory)
                                {
                                    string[] exD = Directory.GetDirectories(Utility.AddTrailingSlash(folderPath) + exc);
                                    DirectoryInfo dif = new DirectoryInfo(fileX);
                                    f2 += Convert.ToInt64(dif.EnumerateFiles("***", SearchOption.AllDirectories).Sum(fi => fi.Length));
                                }
                                else
                                {
                                    FileInfo fileInfo = new FileInfo(fileX);
                                    f2 += fileInfo.Length;
                                }
                            }
                        }

                        Console.WriteLine("Excluded Files : " + (FileSize)f2);
                        files = files - f2;
                        size = ((FileSize)files).ToString();
                    }
                    else
                    {
                        string[] excps = Directory.GetFiles(Utility.AddTrailingSlash(folderPath) + exclusions);

                        foreach (string fileX in excps)
                        {
                            FileInfo fileInfo = new FileInfo(fileX);
                            f2 += fileInfo.Length;
                        }

                        string[] exD = Directory.GetDirectories(Utility.AddTrailingSlash(folderPath) + exclusions);
                        foreach (string dirX in exD)
                        {
                            DirectoryInfo dif = new DirectoryInfo(dirX);
                            f2 += Convert.ToInt64(dif.EnumerateFiles("***", SearchOption.AllDirectories).Sum(fi => fi.Length));
                        }
                        files = files - f2;
                        size = ((FileSize)files).ToString();
                    }
                     *  * */
                }
                    
            return size;
        }

        public static long getExclusionSize(string path, string Exclusions)
        {
            string exclusions = Exclusions;
            //exclusions = exclusions.TrimEnd("*.*");
            long size = 0;

            foreach (string Exc in exclusions.Split('|'))
            {
                string exc = Exc;
                string[] excps;
                if (exc.EndsWith(@"\*.*"))
                {
                    exc = exc.Replace("*.*", "");
                    excps = Directory.GetFiles(Utility.AddTrailingSlash(path) + exc);
                }
                else
                {
                    excps = Directory.GetFiles(Utility.AddTrailingSlash(path) + exc).Where(name => !name.EndsWith(exc)).ToArray();
                }
                //exc = exc.Replace("*.*", "");
                foreach (string fileX in excps)
                {
                    FileAttributes attr = File.GetAttributes(fileX);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        string[] exD = Directory.GetDirectories(Utility.AddTrailingSlash(path) + exc);
                        DirectoryInfo dif = new DirectoryInfo(fileX);
                        size += Convert.ToInt64(dif.EnumerateFiles("***", SearchOption.AllDirectories).Sum(fi => fi.Length));
                    }
                    else
                    {
                        FileInfo fileInfo = new FileInfo(fileX);
                        size += fileInfo.Length;
                    }
                }
                
            }
            return size;
        }

        public void deleteSave()
        {
            List<string> deletes = new List<string>();

            foreach (Node node in serverGamesTree.CheckedNodes)
            {
                deletes.Add(node.Text.ToString());
            }
            string games = String.Join(",", deletes);

            ConfirmPassword confirm = new ConfirmPassword();
            confirm.ShowDialog();
            confirm.Dispose();
            if (confirm.DialogResult == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                string uri = "http://www.gamecloud.xantecgames.com/deleteSave.php";
                string param = "?username=" + Properties.Settings.Default.username + "&gameNames=" + games + "&gHash=" + MD5Gen.Calculate(games + "ju8y6eRqge9VQwdW") + "&password=" + MD5Gen.Calculate(confirm.getPassword() + "ju8y6eRqge9VQwdW");
                string url = uri + param;
                //MessageBoxEx.Show(url);
                byte[] response = webClient.DownloadData(url);
                string results = Encoding.ASCII.GetString(response);
                if (results == "Password")
                {
                    MessageBoxEx.Show("Incorrect password entered");
                    deleteSave();
                }
                else if (results != "Done")
                {
                    MessageBoxEx.Show(results);
                }
                else
                {
                    getServerGames();
                }
            }
        }

        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updateInProgress)
            {
                DialogResult dr = MessageBoxEx.Show("An Upload/Download is currently running. Are you sure you'd like to exit?", "Upload/Download in progress.", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                    Environment.Exit(0);
                }
            }
            else
            {
                Application.Exit();
                Environment.Exit(0);
                //System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            // Autosave and clear up ressources
        }        
        #region ZippyReplacement
        public string zipPath(string file)
        {
            return zipPath(file, "", "", "", "");
        }

        public string zipPath(string file, string name)
        {
            return zipPath(file, name, "", "", "");
        }

        public string zipPath(string file, string name, string password)
        {
            return zipPath(file, name, password, "", "");
        }

        public string zipPath(string file2, string name, string password, string exclude, string include)
        {
            string file = (Utility.replaceSpecials(file2));//.Replace('/', '\\');
            Console.WriteLine(file);
            //string include = Include.Replace("*.*", "");
            using (ZipFile zip = new ZipFile())
            {
                //var dir = Directory.GetParent(zipPath);
                DirectoryInfo dirInfo = new DirectoryInfo(file);
                if (password != "")
                {
                    zip.Password = password;
                    zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                }
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zip.SaveProgress += SaveProgress;
                if (include != "")
                {
                    zip.AddDirectory(file);
                }
                else
                {
                    if (include.Contains("|"))
                    {
                        foreach (string inc in include.Split('|'))
                        {
                            Console.WriteLine("Include : " + inc);
                            string[] fileEntries = Directory.GetFiles(Utility.AddTrailingSlash(file) + inc);
                            foreach (string fileName in fileEntries)
                            {
                                zip.AddFile(fileName);
                            }
                        }
                    }
                }
                if (exclude != "")
                {
                    //exclude = exclude.Replace("*.*", "");
                    //exclude = exclude.Replace(@"\", @"/");
                    
                    foreach (string Exc in exclude.Split('|'))
                    {
                        string exc = Exc;
                        string[] excps;
                        if (exc.EndsWith(@"\*.*"))
                        {
                            exc = exc.Replace("*.*", "");
                            excps = Directory.GetFiles(Utility.AddTrailingSlash(file) + exc);
                        }
                        else
                        {
                            excps = Directory.GetFiles(Utility.AddTrailingSlash(file) + exc).Where(x => !x.EndsWith(exc)).ToArray();
                        }
                        //exc = exc.Replace("*.*", "");
                        foreach (string fileX in excps)
                        {
                            FileAttributes attr = File.GetAttributes(fileX);
                            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                            {
                                foreach (string dir in Directory.GetFiles(fileX))
                                {
                                    zip.RemoveEntry(dir.Replace(file, ""));
                                }
                            }
                            else
                            {
                                FileInfo fileInfo = new FileInfo(fileX);
                                zip.RemoveEntry(fileInfo.FullName.Replace(file, ""));
                            }
                        }

                    }
                    
                    /*
                        foreach (string exc in exclude.Split('|'))
                        {
                            string xc = exc.Replace("*.*", "");
                            string fullPath = Utility.AddTrailingSlash(file) + xc;
                            if (exc.EndsWith(@"\*.*"))
                            {
                                
                                zip.RemoveEntries(Directory.GetFiles(fullPath));
                               
                            Console.WriteLine("Exclude : " + exc);
                            string[] fileEntries = Directory.GetFiles(Utility.AddTrailingSlash(file) + exc);
                            foreach (string fileName in fileEntries)
                            {
                                zip.RemoveEntry(fileName.Replace(file, ""));
                            }
                            }
                            else
                            {
                                zip.RemoveEntries(Directory.GetFiles(Utility.AddTrailingSlash(file) + exc).Where(x => !x.EndsWith(exc)).ToArray());
                            }
                        }
                     * 
                     * */
                }

                foreach (string entry in zip.EntryFileNames)
                {
                    Console.WriteLine(entry);
                }
                string final = "";

                if (name != "")
                {
                    final = Application.UserAppDataPath + @"\" + name + ".zip";
                }
                else
                {
                    final = Path.GetTempFileName() + ".zip";
                }
                Console.WriteLine(final);
                zip.Save(final);

                return final;
            }
        }

        public void unzipFile(string from, string to, string password)
        {
            using (ZipFile zip1 = ZipFile.Read(from))
            {
                zip1.Password = password;
                zip1.Encryption = EncryptionAlgorithm.WinZipAes256;
                // here, we extract every entry, but we could extract conditionally
                // based on entry name, size, date, checkbox status, etc.  
                foreach (ZipEntry e in zip1)
                {
                    e.Extract(to, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }

        public void SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_Started)
            {
                progressBarX2.Visible = true;
                statusLabel.Text = "BEGINNING COMPRESSION";
            }
            else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                statusLabel.Text = "Writing: " + e.CurrentEntry.FileName + " (" + (e.EntriesSaved + 1) + "/" + e.EntriesTotal + ")";
                statusLabel.Update();
                progressBarX2.Maximum = e.EntriesTotal;
                progressBarX2.Value = e.EntriesSaved + 1;
            }
            else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBarX1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
            }
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {
                statusLabel.Text = "COMPRESSION COMPLETE";
                progressBarX2.Maximum = 100;
                progressBarX2.Visible = false;
                cancelB.Visible = true;
            }
        }
        #endregion
    }
}
