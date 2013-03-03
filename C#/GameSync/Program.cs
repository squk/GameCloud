using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using DevComponents.DotNetBar;
using System.ServiceProcess;
using System.Diagnostics;
using System.IO;

namespace GameSync
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main(string[] args)
        {
            /*
            Logger = new ErrorLog(Application.UserAppDataPath + "\\Errors");
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            */

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(args));
        }
        static ErrorLog Logger;
        static void OnProcessExit(object sender, EventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();
                string uri = "http://www.gamecloud.xantecgames.com/makeStatus.php";
                string param = "?status=OFF&user=" + Properties.Settings.Default.username;
                string url = uri + param;
                byte[] dlData = wc.DownloadData(url);
            }
            catch
            {

            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                string LogFile = Logger.LogError(ex);

                MessageBoxEx.Show(
                    "The application encountered a fatal error and must exit. This error has been logged and should be reported using the Error Report utility.\n\n" +
                        "Error:\n" +
                        ex.Message +
                        "\n\nStack Trace:\n" +
                        ex.StackTrace,
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                Process proc = new Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = Application.UserAppDataPath + "\\ErrorReport.exe";
                
                proc.StartInfo.Arguments = LogFile;
                proc.Start();
            }
            finally
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            DialogResult result = DialogResult.Abort;
            try
            {
                string LogFile = Logger.LogError(e.Exception);

                result = MessageBoxEx.Show(
                    "The application encountered a error. This error has been logged and should be reported using the Error Report utility.\n\n" +
                        "Error:\n" +
                        e.Exception.Message +
                        "\n\nStack Trace:\n" +
                        e.Exception.StackTrace,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                Process proc = new Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = Application.UserAppDataPath + "\\ErrorReport.exe";
                proc.StartInfo.Arguments = LogFile;
                proc.Start();
            }
            finally
            {
                
                    Application.Exit();
                    Environment.Exit(0);
            }
        }
    }
}
