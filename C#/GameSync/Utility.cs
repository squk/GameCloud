using Microsoft.Win32;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSync
{
    class Utility
    {
        public static string AddTrailingSlash(string path)
        {
            if (path.Length > 0)
            {
                char ch = path[path.Length - 1];
                if (ch.ToString() != @"\")
                {
                    path = path + @"\";
                }
            }
            return path;
        }

        private static bool is64Bit()
        {
            if (8 != IntPtr.Size)
            {
                return !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
            }
            return true;
        }

        private static string GetAllUsersProfilePath()
        {
            return (Environment.GetEnvironmentVariable("ALLUSERSPROFILE") + @"\");
        }

        public static string GetApplicationDataPath()
        {
            return (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\");
        }

        public static string getAssemblyGUID()
        {
            GuidAttribute attribute = (GuidAttribute)Assembly.GetEntryAssembly().GetCustomAttributes(typeof(GuidAttribute), true)[0];
            return attribute.Value;
        }

        private static string GetCommonApplicationDataPath()
        {
            return (Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\");
        }

        private static string GetCommonDocumentsPath()
        {
            return (Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\");
        }

        private static string GetDocumentsPath()
        {
            return (Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\");
        }

        private static string GetDriveRootPath()
        {
            return Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        }

        private static string GetFlashPath()
        {
            return (GetApplicationDataPath() + @"Macromedia\Flash Player\#SharedObjects\");
        }

        private static string GetLocalApplicationDataPath()
        {
            return (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\");
        }

        public static string replaceSpecials(string special)
        {
            string Special = "";
            List<string> specials = new List<string>()
            {
                "%APPDATA%", "%APPDATA_LOCAL%", "%APPDATA_COMMON%", "%DOCUMENTS%", "%STEAM%", "%STEAM_CLOUD%", "%STEAM_CACHE%", "%SAVED_GAMES%"
            };

            List<string> specialsTrans = new List<string>()
            {
                "APPLICATIONDATA", "LOCALAPPLICATIONDATA", "COMMONAPPLICATIONDATA", "MYDOCUMENTS", "STEAM", "STEAMCLOUD", "STEAMCACHE", "SAVEDGAMES"
            };

            for (int i = 0; i < specials.Count; i++)
            {
                if (special.Contains(specials[i]))
                {
                    Special = special.Replace(specials[i], Utility.getLocalEnvironmentPath(specialsTrans[i]));
                }
            }
            if (Special == "")
            {
                //Console.WriteLine("No special found in string : " + special);
                Special = special;
            }
            return Special;
        }

        public static string getLocalEnvironmentPath(string env)
        {
            try
            {
                switch (env)
                {
                    case "PROGRAMFILES":
                        return GetProgramFilesPath();

                    case "APPLICATIONDATA":
                        return GetApplicationDataPath();

                    case "LOCALAPPLICATIONDATA":
                        return GetLocalApplicationDataPath();

                    case "ALLUSERSPROFILE":
                        return GetAllUsersProfilePath();

                    case "COMMONAPPLICATIONDATA":
                        return GetCommonApplicationDataPath();

                    case "COMMONDOCUMENTS":
                        return GetCommonDocumentsPath();

                    case "PUBLIC":
                        return GetPublicPath();

                    case "MYDOCUMENTS":
                        return GetDocumentsPath();

                    case "STEAM":
                        return GetSteamPath();

                    case "SAVEDGAMES":
                        return GetSavedGamesPath();

                    case "DRIVEROOT":
                        return GetDriveRootPath();

                    case "USERPROFILE":
                        return GetUserProfilePath();

                    case "FLASH":
                        return GetFlashPath();

                    case "UBISOFT":
                        return GetUbisoftPath();

                    case "STEAMCLOUD":
                        return GetSteamCloudPath();

                    case "STEAMCACHE":
                        return GetSteamCachePath();
                }
                return "";
            }
            catch (Exception exception)
            {
                //Logger.exceptionLog("Error when getting environment path.", exception);
                Console.WriteLine(exception);
                return "";
            }
        }

        private static string GetProgramFilesPath()
        {
            if (is64Bit())
            {
                return (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\");
            }
            return (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\");
        }

        private static string GetPublicPath()
        {
            string str = Environment.GetEnvironmentVariable("PUBLIC") + @"\";
            if (str == null)
            {
                str = GetDriveRootPath() + @"Users\Public\";
            }
            return str;
        }

        public static string getRegKeyEntry(RegistryKey key, string value, string truncateAt)
        {
            string path = "";
            if ((key == null) || (key.GetValue(value) == null))
            {
                return path;
            }
            path = key.GetValue(value).ToString();
            if ((truncateAt != "") && (path.LastIndexOf(truncateAt) >= 0))
            {
                path = path.Remove(path.LastIndexOf(truncateAt));
            }
            return AddTrailingSlash(path);
        }

        private static string GetSavedGamesPath()
        {
            if (Environment.OSVersion.Version.Major == 5)
            {
                return GetDocumentsPath();
            }
            return (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Saved Games\");
        }

        private static string GetSteamCloudPath()
        {
            return (GetSteamPath() + @"userdata\");
        }

        private static string GetSteamPath()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Valve\Steam\", false);
            string str = "";
            if ((key != null) && (key.GetValue("InstallPath") != null))
            {
                str = key.GetValue("InstallPath").ToString() + @"\";
            }
            if (str == "")
            {
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valve\Steam\", false);
                if ((key != null) && (key.GetValue("SteamPath") != null))
                {
                    str = key.GetValue("SteamPath").ToString() + @"\";
                }
            }
            return str;
        }

        private static string GetSteamCachePath()
        {
            string transformed = "";
            if (Directory.Exists(GetSteamPath()))
            {
                foreach (DirectoryInfo dir in new DirectoryInfo(GetSteamPath() + "steamapps").GetDirectories())
                {
                    //Console.WriteLine(dir.FullName);
                    if (dir.Name != "common" && dir.Name != "downloading" && dir.Name != "sourcemods" && dir.Name != "temp")
                    {
                        //Console.WriteLine(dir.FullName);
                        transformed =AddTrailingSlash(dir.FullName);
                    }
                }
            }

            return transformed;
        }

        private static string GetUbisoftPath()
        {
            string path = GetLocalApplicationDataPath() + @"Ubisoft Game Launcher\savegame_storage\";
            if (Directory.Exists(path))
            {
                return path;
            }
            return (GetProgramFilesPath() + @"Ubisoft\Ubisoft Game Launcher\savegames\");
        }

        private static string GetUserProfilePath()
        {
            return (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\");
        }

        public static void SetStartup(bool start)
        {
            RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (start)
                
                add.SetValue("Game Cloud", "\"" + Application.ExecutablePath.ToString() + @"\");
            else
                add.SetValue("Game Cloud", false);

        }
    }
}
