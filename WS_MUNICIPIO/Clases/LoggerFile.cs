using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Web_Services_BCBG;

namespace WS_MUNICIPIO.Clases
{
    public class LoggerFile
    {
        public static void WriteLogger(string message)
        {
            string logPath = CreateDirectory();

            message = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + " : " + message;
            var name_file = Path.Combine(logPath, DateTime.Now.Day.ToString() + ".txt");
            if (!File.Exists(name_file))
            {
                File.WriteAllText(name_file, message);
            }
            else
            {
                string[] message_ = new string[] { message };

                File.AppendAllLines(name_file, message_);
            }
            //File.SetAttributes(name_file, FileAttributes.ReadOnly);
        }

        public static string CreateDirectory()
        {

            string docPath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\LOGGER_OTPI\\";
            string root = docPath + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMMM").ToUpper() + "\\";

            //string root = ConfigurationManager.AppSettings["Logger_OTPI"] + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMMM").ToUpper() + "\\";

            bool folder_exists = Directory.Exists(root);
            if (!folder_exists)
                Directory.CreateDirectory(root);
            return root;

        }
    }
}