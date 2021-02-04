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
            OBJApiInterface.EmpId = "";
            OBJApiInterface.CompanyId = "";
            OBJApiInterface.JsonFilePathToAddEmp = "";
            OBJApiInterface.PathtoCreateDataFile = @"D://CamAtt.txt";
        }

        API_Functions OBJApiInterface = new API_Functions();
        private void btn_GetTransactionLog_Click(object sender, EventArgs e)
        {
            OBJApiInterface.DT_from = dateTimePicker1.Value;
            OBJApiInterface.DT_To = dateTimePicker2.Value;
            string Base64EncodedToken = OBJApiInterface.EncryptString();
            OBJApiInterface.GetTransactionLogExample(Base64EncodedToken);
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            var JsonData = OBJApiInterface.ReadDataFromTextFile();
            string Base64EncodedToken = OBJApiInterface.EncryptString();
            OBJApiInterface.AddEmployeeExample(JsonData, Base64EncodedToken);
        }       

        private void btn_EmpInfo_Click(object sender, EventArgs e)
        {
            string Base64EncodedToken = OBJApiInterface.EncryptString();
            OBJApiInterface.GetEmpInfo(Base64EncodedToken);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
