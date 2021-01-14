using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using KentCamAttendanceController.Common;
using KentCamAttendanceController.BusinessLogic;

namespace KentCamAttendanceController.Controllers
{
    public class KentCamAttendanceController  : ApiController
    {
       
        //// GET: Api
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        //[Route("api/KentCamAttendanceController")]
        public HttpResponseMessage Insert()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hello World");
        }
        [HttpPost]
        public HttpResponseMessage Insert([FromBody]List<Models.Employee> emp)
        {
            KentAttendanceMaster obj = new KentAttendanceMaster();
            //try
            //{
                string empcode = string.Empty;
                foreach (Models.Employee item in emp)
                {
                    if (GlobalMethods.NullCheckString(item.empId) != "" && GlobalMethods.NullCheckString(item.locationName) != "")
                    {
                        if (IsUserValid(GlobalMethods.NullCheckString(item.empId), item.time, item.locationName))
                        {
                            obj.Data_Employee.empId = Convert.ToString(item.empId);
                            obj.Data_Employee.time = Convert.ToDouble(item.time);
                            obj.Data_Employee.locationName = Convert.ToString(item.locationName);
                            obj.Data_Employee.CamStatus = 1;
                            obj.AddEmployeeAttendance();
                        }
                        else
                        {
                            empcode += GlobalMethods.NullCheckString(item.empId) + ",";
                        }
                    }

                }
                if (obj.InsertEmployeeAttendance(KentAttendanceBLL.KentDatabaseName))
                {
                    if (empcode.TrimEnd(',').Length > 0)
                        return Request.CreateResponse(HttpStatusCode.Created, empcode.TrimEnd(',').Length > 0 ? empcode.TrimEnd(',') + " employee does not exist." : "");
                    else
                        return Request.CreateResponse(HttpStatusCode.Created);
                }
                else
                {
                    if (empcode.TrimEnd(',').Length > 0)
                        return Request.CreateResponse(HttpStatusCode.Conflict, empcode.TrimEnd(',') + " employee does not exist.");
                    else
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            //}
            //catch (Exception ee)
            //{ }
        }
        bool IsUserValid(string userId, double intime, string location)
        {
            KentAttendanceMaster obj = new KentAttendanceMaster();
            DataSet ds = new DataSet();

            ds = obj.IsUserExist(userId, intime, location, KentAttendanceBLL.KentDatabaseName);
            return Convert.ToInt32(ds.Tables[0].Rows[0]["UserExist"]) > 0 ? true : false;
        }

    }
}

