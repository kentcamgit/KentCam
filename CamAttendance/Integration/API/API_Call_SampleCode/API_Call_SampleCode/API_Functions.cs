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
using Newtonsoft.Json.Linq;

namespace API_Call_SampleCode
{
    class API_Functions
    {
        private string _baseurl = "";
        private DateTime _DT_from;
        private DateTime _DT_To;
        private string _AccountId = "";
        private string _secureToken = "";
        private string _PathtoCreateDataFile = "";
        private string _JsonFilePathToAddEmp = "";

        public API_Functions()
        {
            GetBaseUrl();
        }

        public string BaseUrl
        {
            get { return _baseurl; }
            set { _baseurl = value; }
        }
        public DateTime DT_from
        {
            get { return _DT_from; }
            set { _DT_from = value; }
        }
        public DateTime DT_To
        {
            get { return _DT_To; }
            set { _DT_To = value; }
        }
        public string AccountId
        {
            get { return _AccountId; }
            set { _AccountId = value; }
        }
        public string secureToken
        {
            get { return _secureToken; }
            set { _secureToken = value; }
        }
        public string PathtoCreateDataFile
        {
            get { return _PathtoCreateDataFile; }
            set { _PathtoCreateDataFile = value; }
        }
        public string JsonFilePathToAddEmp
        {
            get { return _JsonFilePathToAddEmp; }
            set { _JsonFilePathToAddEmp = value; }
        }

        public void AddEmployeeExample(dynamic jsonData, string base64EncodedStr)
        {
            try
            {

                HttpClientHandler handler = new HttpClientHandler();
                HttpClient client = new HttpClient(handler);

                string messageUri = BaseUrl + "employee";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
                var BodyPara = base64EncodedStr;
                request.Headers.Add("token", base64EncodedStr);
                request.ContentType = "application/json";
                request.Method = "Post";

                request.Accept = "application/json";
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(JsonConvert.DeserializeObject(jsonData));
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();

                string jsonString = null;

                using (StreamReader reader = new StreamReader(responseStream))
                {
                    jsonString = reader.ReadToEnd();
                    Console.WriteLine();
                    reader.Close();
                }
            }
            catch (Exception ee) { }
        }

        public void GetTransactionLogExample(string Base64EncodedToken)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string lastEvaluatedKey = ""; string Size50 = "&size=50";
                HttpClientHandler handler = new HttpClientHandler();
                HttpClient client = new HttpClient(handler);
                string content = string.Empty;

                string DateFrom = GetTimeInMiliSec(DT_from);
                string date_To = GetTimeInMiliSec(DT_To);
            Found:

                string messageUri = BaseUrl + "transactions?from=" + DateFrom + "&to=" + date_To + lastEvaluatedKey + Size50;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(messageUri);
                var BodyPara = Base64EncodedToken;

                request.Headers.Add("token", Base64EncodedToken);
                request.ContentType = "application/json";
                request.Method = "Get";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string jsonString = null;

                using (StreamReader reader = new StreamReader(responseStream))
                {
                    jsonString = reader.ReadToEnd();
                    reader.Close();
                }

                dynamic dynObj = JsonConvert.DeserializeObject(jsonString);

                foreach (var Root in dynObj.Root)
                {
                    foreach (var data in Root)
                    {
                        foreach (JProperty keyValue in data)
                        {
                            string KeyName = keyValue.Name.ToString();
                            var KeyVal = keyValue.Value;
                            if (KeyName == "list")
                            {
                                foreach (var data1 in KeyVal)
                                {
                                    sb.Append("{");
                                    foreach (JProperty keyValue2 in data1)
                                    {
                                        string KeyName2 = keyValue2.Name.ToString();
                                        var KeyVal2 = keyValue2.Value;
                                        sb.Append(KeyName2 + ":" + KeyVal2 + ",");
                                    }
                                    sb.Append("},\r\n");
                                }
                            }
                            if (KeyName == "lastEvaluatedKey")
                            {
                                if (KeyVal.ToString() != "")
                                {
                                    lastEvaluatedKey = "";
                                    lastEvaluatedKey = "&lastEvaluatedKey=" + KeyVal;
                                    goto Found;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                CreateTextFile(sb);
            }
        }
        public string EncryptString()
        {
            long currentTimeMillis = (long)DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

            string base64Decoded = secureToken + "_" + currentTimeMillis + "_" + AccountId;
            string base64Encoded;
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded);
            base64Encoded = System.Convert.ToBase64String(data);
            return base64Encoded;
        }
        public string ReadDataFromTextFile()
        {
            string JsonData = string.Empty;
            if (File.Exists(JsonFilePathToAddEmp))
            {
                JsonData = File.ReadAllText(JsonFilePathToAddEmp);
            }
            return JsonData;
        }
        public string GetTimeInMiliSec(DateTime Time)
        {
            long TimeInMiliSec = (long)Time.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds; ;
            return TimeInMiliSec.ToString();
        }
        public void CreateTextFile(StringBuilder sb)
        {
            if (!File.Exists(PathtoCreateDataFile))
            {
                using (StreamWriter sw = File.CreateText(PathtoCreateDataFile))
                {
                    sw.WriteLine(sb.ToString());
                }
            }
        }
        public void GetBaseUrl()
        {
            BaseUrl = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "url.txt"));
        }
    }
}
