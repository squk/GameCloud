using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;


namespace GameSync
{
    public sealed class ErrorLog
    {
        #region Properties

        private string _LogPath;
        public string LogPath
        {
            get
            {
                return _LogPath;
            }
        }

        #endregion

        #region Constructors

        public ErrorLog()
        {
            _LogPath = Path.Combine(Application.UserAppDataPath, "Errors");
            if (!Directory.Exists(_LogPath))
                Directory.CreateDirectory(_LogPath);
        }

        public ErrorLog(string logPath)
        {
            _LogPath = logPath;
            if (!Directory.Exists(_LogPath))
                Directory.CreateDirectory(_LogPath);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Logs exception information to the assigned log file.
        /// </summary>
        /// <param name="exception">Exception to log.</param>
        public string LogError(Exception exception)
        {
            Assembly caller = Assembly.GetEntryAssembly();
            Process thisProcess = Process.GetCurrentProcess();

            string LogFile = DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss") + ".txt";
            using (StreamWriter sw = new StreamWriter(Path.Combine(_LogPath, LogFile)))
            {
                sw.WriteLine("======================Game Cloud Error Log====================================");
                sw.WriteLine("Username : " + Properties.Settings.Default.username);
                sw.WriteLine("==============================================================================");
                sw.WriteLine(caller.FullName);
                sw.WriteLine("------------------------------------------------------------------------------");
                sw.WriteLine("Application Information");
                sw.WriteLine("------------------------------------------------------------------------------");
                sw.WriteLine("Program      : " + caller.Location);
                sw.WriteLine("Time         : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                sw.WriteLine("User         : " + Environment.UserName);
                sw.WriteLine("Computer     : " + Environment.MachineName);
                sw.WriteLine("OS           : " + Environment.OSVersion.ToString());
                sw.WriteLine("Culture      : " + CultureInfo.CurrentCulture.Name);
                sw.WriteLine("Processors   : " + Environment.ProcessorCount);
                sw.WriteLine("Working Set  : " + Environment.WorkingSet);
                sw.WriteLine("Framework    : " + Environment.Version);
                sw.WriteLine("Run Time     : " + (DateTime.Now - Process.GetCurrentProcess().StartTime).ToString());
                sw.WriteLine("------------------------------------------------------------------------------");
                sw.WriteLine("Exception Information");
                sw.WriteLine("------------------------------------------------------------------------------");
                sw.WriteLine("Source       : " + exception.Source.ToString().Trim());
                sw.WriteLine("Method       : " + exception.TargetSite.Name.ToString());
                sw.WriteLine("Type         : " + exception.GetType().ToString());
                sw.WriteLine("Error        : " + GetExceptionStack(exception));
                sw.WriteLine("Stack Trace  : " + exception.StackTrace.ToString().Trim());
                sw.WriteLine("------------------------------------------------------------------------------");
                sw.WriteLine("Loaded Modules");
                sw.WriteLine("------------------------------------------------------------------------------");
                foreach (ProcessModule module in thisProcess.Modules)
                {
                    try
                    {
                        sw.WriteLine(module.FileName + " | " + module.FileVersionInfo.FileVersion + " | " + module.ModuleMemorySize);
                    }
                    catch (FileNotFoundException)
                    {
                        sw.WriteLine("File Not Found: " + module.ToString());
                    }
                    catch (Exception)
                    {

                    }
                }
                sw.WriteLine("------------------------------------------------------------------------------");
                sw.WriteLine(LogFile);
                sw.WriteLine("==============================================================================");
            }

            return Path.Combine(_LogPath, LogFile);
        }

        #endregion

        #region Private Methods

        private string GetExceptionStack(Exception e)
        {
            StringBuilder message = new StringBuilder();
            message.Append(e.Message);
            while (e.InnerException != null)
            {
                e = e.InnerException;
                message.Append(Environment.NewLine);
                message.Append(e.Message);
            }

            return message.ToString();
        }

        #endregion
    }
}
