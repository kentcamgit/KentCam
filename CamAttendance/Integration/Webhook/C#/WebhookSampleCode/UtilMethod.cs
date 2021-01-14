using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using KentCamAttendanceController.BusinessLogic;
using KentCamAttendanceController.Models;

namespace KentCamAttendanceController
{
    public class UtilMethod
    {

    }
    public class KentAttendanceMaster
    {
        KentAttendanceBLL obj = null;
        ArrayList alist_Employee = new ArrayList();
        public Employee Data_Employee = null;

        public KentAttendanceMaster()
        {
            Data_Employee = new Employee();
        }

        public void AddEmployeeAttendance()
        {
            alist_Employee.Add(Data_Employee);
            Data_Employee = new Employee();
        }

        public bool InsertEmployeeAttendance(string Database)
        {
            obj = new KentAttendanceBLL();
            return obj.InsertEmployeeAttendance(alist_Employee, Database);
        }

        public DataSet IsUserExist(string UserId, double intime, string location, string Database)
        {
            obj = new KentAttendanceBLL();
            return obj.IsUserExist(UserId, intime, location, Database);
        }
    }
}