using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace KentCamAttendanceWindowsExlorer
{
    public partial class RecognitionLog : Form
    {
        
        public RecognitionLog()
        {
            InitializeComponent();
        }

        private void RecognitionLog_Load(object sender, EventArgs e)
        {
           
        }

        API_Interface OBJApiInterface = new API_Interface();
       
        public void HttpRequest()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://rlcjyu5r30.execute-api.ap-south-1.amazonaws.com/DEV/authv1/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var BodyPara = "{userName:U2FsdGVkX1/N9U4v+FMfzAN/1nhTWxgbJiypxvWrnV13ArYO7KMh1THOLk4Ioszm,password:U2FsdGVkX19fRKYnnMcAMHPbGALWQcG31qoSeb42zeo=,userEmail:U2FsdGVkX1+UFt24sengB3ec9VUM/zMfZAwpC47VGGmh3+whM8AMQTjF0BfqYpYV}";
                string jsonModel = Newtonsoft.Json.JsonConvert.SerializeObject(BodyPara);
                streamWriter.Write(jsonModel);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
        
        //For Add a Employee
        private void btn_PostData_Click(object sender, EventArgs e)
        {              
            string FilePath = @"C:\KentFile\Transactionlog.txt";
            string AccountId = "ACC-106";
            string secureToken = "FUBQqq0kFPbXQzi";
            var JsonData=  OBJApiInterface.ReadDataFromTextFile(FilePath);
            OBJApiInterface.HTTP_PostRequest(JsonData, AccountId, secureToken);
        }

        //For getting data from cloud
        private void btn_GetLog_Click(object sender, EventArgs e)
        {
            DateTime DT_from = dateTimePicker1.Value;
            DateTime DT_To = dateTimePicker2.Value;
            string from = dateTimePicker1.Text; string To = dateTimePicker2.Text;
            string AccountId = "ACC-106";
            string secureToken = "FUBQqq0kFPbXQzi";
            string CompanyId = "0000";
            string EmpId = "";
            string PathtoCreateDataFile = @"D:\FileTodo.txt";
            OBJApiInterface.GetTransactionLog(CompanyId, EmpId, AccountId, secureToken, DT_from, DT_To, PathtoCreateDataFile);
        }
    }
}
