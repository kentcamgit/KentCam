using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
//using KentAndCamEyeAttendance.DBConnection;
//using KentAndCamEyeAttendance.Models;


namespace KentCamAttendanceController.BusinessLogic
{
    public class KentAttendanceBLL
    {
        public static string KentDatabaseName = string.Empty;
        public bool InsertEmployeeAttendance(ArrayList alist_Employee, string KentDatabase)
        {
            bool result = false;
            SqlCommand command;
            SqlParameter Par;
            ConClass con = new ConClass(KentDatabase);
            if (con.IsConnectionExist == false)
            {
                return false;
            }
            if (con.Open() == false)
            {
                return false;
            }
            if (con.BeginTransaction() == false)
            {
                return false;
            }

            try
            {
                Employee drow_Employee;
                IEnumerator Inum_Employee = alist_Employee.GetEnumerator();
                while (Inum_Employee.MoveNext())
                {
                    drow_Employee = new Employee();
                    drow_Employee = Inum_Employee.Current as Employee;
                    command = new SqlCommand();
                    command.CommandText = "";
                    command.CommandType = CommandType.StoredProcedure;
                    Par = new SqlParameter("@userid", SqlDbType.VarChar, 255);
                    Par.Value = drow_Employee.empId;
                    command.Parameters.Add(Par);

                    Par = new SqlParameter("@intime", SqlDbType.Decimal, 9);
                    Par.Value = drow_Employee.time;
                    command.Parameters.Add(Par);

                    Par = new SqlParameter("@locationName", SqlDbType.VarChar, 255);
                    Par.Value = drow_Employee.locationName;
                    command.Parameters.Add(Par);

                    Par = new SqlParameter("@CamStatus", SqlDbType.Int, 4);
                    Par.Value = drow_Employee.CamStatus;
                    command.Parameters.Add(Par);

                    if (con.ExecuteNonQuery(command) > 0)
                        result = true;
                    else
                        result = false;
                }

                if (result == true)
                {
                    con.Commit();
                }
                else
                {
                    con.RollBack();
                }
            }
            catch
            {
                con.RollBack();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public DataSet IsUserExist(string UserId, double intime, string location, string KentDatabase)
        {
            DataSet ds = new DataSet(); bool result = false;
            SqlCommand command;
            SqlParameter Par;
            ConClass con = new ConClass(KentDatabase);
            if (con.IsConnectionExist == false)
            {
                return null;
            }
            if (con.Open() == false)
            {
                return null;
            }
            if (con.BeginTransaction() == false)
            {
                return null;
            }

            try
            {
                command = new SqlCommand();
                command.CommandText = "";
                command.CommandType = CommandType.StoredProcedure;
                Par = new SqlParameter("@userid", SqlDbType.VarChar, 255);
                Par.Value = UserId;
                command.Parameters.Add(Par);

                Par = new SqlParameter("@intime", SqlDbType.Decimal, 9);
                Par.Value = intime;
                command.Parameters.Add(Par);

                Par = new SqlParameter("@locationName", SqlDbType.VarChar, 255);
                Par.Value = location;
                command.Parameters.Add(Par);

                ds = con.GetDataSet(command);
                if (ds != null || ds.Tables[0].Rows.Count > 0)
                    result = true;
                else
                    result = false;

                if (result)
                    con.Commit();
                else
                    con.RollBack();
            }
            catch
            {
                con.RollBack();
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

    }
}