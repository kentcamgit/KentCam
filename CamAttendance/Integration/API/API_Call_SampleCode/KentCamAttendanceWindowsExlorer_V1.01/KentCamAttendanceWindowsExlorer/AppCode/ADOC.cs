using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Xml;

namespace KentCamAttendanceWindowsExlorer.AppCode
{
    class ADOC
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter DA = new SqlDataAdapter();

        public ADOC()
        {
            //con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
        }
        public void ImportTableIntoDB(DataTable DT,List<string> listData)
        {
            con = new SqlConnection(Program.Connectionstr);
            using (con)
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " insert into " + Program.XML_Data[4] + "(" + Program.XML_Data[5] + "," + Program.XML_Data[6] + "," + Program.XML_Data[7] + "," + Program.XML_Data[8] + "," + Program.XML_Data[9] + "," + Program.XML_Data[10] + ") values('" + listData[0] + "','" + listData[1] + "','" + listData[2] + "','" + listData[3] + "','" + listData[4] + "','" + listData[5] + "')";
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetSchemaFromTable(string TablName)
        {
            string Qry = " SELECT* FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + TablName + "'";
            DataTable DT = new DataTable();
            con = new SqlConnection(Program.Connectionstr);
            using (con)
            {
                con.Open();
                DA = new SqlDataAdapter(Qry, con);
                DA.Fill(DT);
            }
            return DT;
        }
        public void ReadXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Settings.xml");
            
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Program.XML_Data.Add(node.InnerText);               
            }
            Program.Connectionstr = "Data Source=" + Program.XML_Data[0] + ";Initial Catalog=" + Program.XML_Data[1] + ";" +
                "Persist Security Info=True;User ID=" + Program.XML_Data[2] + ";Password=" + Program.XML_Data[3] + ";";
        }
    }
}
