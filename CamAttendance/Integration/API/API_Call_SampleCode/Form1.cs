using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Call_SampleCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            OBJApiInterface.AccountId = "";
            OBJApiInterface.secureToken = "";            
            OBJApiInterface.JsonFilePathToAddEmp = "";
            OBJApiInterface.PathtoCreateDataFile = "";
        }

        API_Functions OBJApiInterface = new API_Functions();
        private void btn_GetLog_Click(object sender, EventArgs e)
        {
            OBJApiInterface.DT_from = dateTimePicker1.Value;
            OBJApiInterface.DT_To = dateTimePicker2.Value;
            string Base64EncodedToken = OBJApiInterface.EncryptString();
            OBJApiInterface.GetTransactionLog(Base64EncodedToken);
        }

        private void btn_PostData_Click(object sender, EventArgs e)
        {            
            var JsonData = OBJApiInterface.ReadDataFromTextFile();
            string Base64EncodedToken = OBJApiInterface.EncryptString();
            OBJApiInterface.HTTP_PostRequest(JsonData, Base64EncodedToken);
        }
    }
}
