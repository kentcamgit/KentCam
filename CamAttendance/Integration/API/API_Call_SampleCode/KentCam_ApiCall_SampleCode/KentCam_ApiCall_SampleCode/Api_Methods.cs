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

namespace KentCam_ApiCall_SampleCode
{
    class Api_Methods
    {
        public void HTTP_PostRequest(dynamic jsonData, string AccountId, string secureToken)
        {
            string base64EncodedStr = EncryptString(AccountId, secureToken);
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient client = new HttpClient(handler);

            string messageUri = "https://fly1cnrt79.execute-api.ap-south-1.amazonaws.com/prod/public-api/employee";

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

        public void GetTransactionLog(string CompanyId, string EmpId, string AccountId, string secureToken, DateTime DT_From, DateTime DT_To, string PathToCreateFile)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string lastEvaluatedKey = ""; string Size50 = "&size=10";
                string Base64EncodedToken = EncryptString(AccountId, secureToken);
                HttpClientHandler handler = new HttpClientHandler();
                HttpClient client = new HttpClient(handler);
                string content = string.Empty;

                string DateFrom = GetTimeInMiliSec(DT_From);
                string date_To = GetTimeInMiliSec(DT_To);
            Found:

                string messageUri = " https://fly1cnrt79.execute-api.ap-south-1.amazonaws.com/prod/public-api/transactions?from=" + DateFrom + "&to=" + date_To + lastEvaluatedKey + Size50;

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
                                    foreach (JProperty keyValue2 in data1)
                                    {
                                        string KeyName2 = keyValue2.Name.ToString();
                                        var KeyVal2 = keyValue2.Value;
                                        sb.Append(KeyName2 + ":" + KeyVal2 + ",");
                                    }
                                    sb.Append("\r\n");
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
                CreateTextFile(sb, PathToCreateFile);
            }
        }
        public string EncryptString(string accountId, string secureToken)
        {
            long currentTimeMillis = (long)DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

            string base64Decoded = secureToken + "_" + currentTimeMillis + "_" + accountId;
            string base64Encoded;
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded);
            base64Encoded = System.Convert.ToBase64String(data);
            return base64Encoded;
        }
        public string ReadDataFromTextFile(string textFilePath)
        {
            string JsonData = string.Empty;
            if (File.Exists(textFilePath))
            {
                JsonData = File.ReadAllText(textFilePath);
            }
            return JsonData;
        }
        public string GetTimeInMiliSec(DateTime Time)
        {
            long TimeInMiliSec = (long)Time.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds; ;
            return TimeInMiliSec.ToString();
        }
        public void CreateTextFile(StringBuilder sb, string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                using (StreamWriter sw = File.CreateText(FilePath))
                {
                    sw.WriteLine(sb.ToString());
                }
            }
        }
    }
}
