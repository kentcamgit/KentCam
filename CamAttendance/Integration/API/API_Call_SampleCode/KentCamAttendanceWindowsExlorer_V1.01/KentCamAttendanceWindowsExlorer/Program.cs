using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace KentCamAttendanceWindowsExlorer
{
    static class Program
    {
        public static string Connectionstr = string.Empty;
        public static List<string> XML_Data = new List<string>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //long currentTimeMillis =(long)DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;            
            //string accountId = "ACC-103";
            //string secureToken = "4VbVlGUMYQ9JRLG";

            //string base64Decoded = secureToken + "_" + currentTimeMillis + "_" + accountId;
            //string base64Encoded;
            //byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded);
            //base64Encoded = System.Convert.ToBase64String(data);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RecognitionLog());// parentForm());           
        }       
    }
}
