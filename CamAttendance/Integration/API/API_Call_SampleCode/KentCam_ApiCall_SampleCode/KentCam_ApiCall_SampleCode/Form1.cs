using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentCam_ApiCall_SampleCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Api_Methods OBJApiInterface = new Api_Methods();
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

        private void btn_PostData_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\KentFile\Transactionlog.txt";
            string AccountId = "ACC-106";
            string secureToken = "FUBQqq0kFPbXQzi";
            var JsonData = OBJApiInterface.ReadDataFromTextFile(FilePath);

            OBJApiInterface.HTTP_PostRequest(JsonData, AccountId, secureToken);
        }
    }
}
