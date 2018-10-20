using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace eHealth.Utility
{
    public static class clsUtility
    {
        [DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int WNetGetConnection(
            [MarshalAs(UnmanagedType.LPTStr)] string localName,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder remoteName,
            ref int length);

        public static string GetUNCPath(string originalPath)
        {
            StringBuilder sb = new StringBuilder(512);
            int size = sb.Capacity;

            if (originalPath.Length > 2 && originalPath[1] == ':')
            {
                char c = originalPath[0];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    int error = WNetGetConnection(originalPath.Substring(0, 2), sb, ref size);
                    if (error == 0)
                    {
                        DirectoryInfo dir = new DirectoryInfo(originalPath);
                        string path = Path.GetFullPath(originalPath).Substring(Path.GetPathRoot(originalPath).Length);
                        return Path.Combine(sb.ToString().TrimEnd(), path);

                    }
                }
            }

            return originalPath;
        }


        public static void WriteLogs(string pSource, string sType, DateTime EDate, string ErrorMessage)
        {
            StringBuilder str = new StringBuilder();
            string folderName = ConfigurationManager.AppSettings["LogPath"].ToString();
            string fileName = ConfigurationManager.AppSettings["LogFile"].ToString();

            string psLogDirectory;// = PrjInsuranceModule.Business_Objects.Properties.Settings.Default.Logs.ToString(); //+ "Complaince_Logs.txt";
            psLogDirectory = folderName; //Environment.CurrentDirectory.ToString() + "\\" + ;
            string psLogPath = psLogDirectory + "\\" + fileName + EDate.ToString("yyyy-MM-dd").Replace('-', '_').ToString() + ".txt";
            if (Directory.Exists(psLogDirectory) == false)
            {
                Directory.CreateDirectory(psLogDirectory);
            }
            int len = (Int32)75 - pSource.Length;
            if (len < 0)
            {
                len = 0;
            }
            char space = ' ';
            pSource = pSource.PadRight(pSource.Length + len, space);
            sType = sType.PadRight(sType.Length + len, space);

            str.AppendLine(pSource + "\t" + sType + "\t" + EDate.ToString("yyyy-MM-dd hh:mm:ss") + "\t" + ErrorMessage);
            System.IO.File.AppendAllText(psLogPath, str.ToString());



        }
    }
}
