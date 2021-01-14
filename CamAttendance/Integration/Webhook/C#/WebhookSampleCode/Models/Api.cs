using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KentCamAttendanceController.Models
{
    public class Api
    {

    }
    public class Employee
    {
        public string empId { get; set; }
        public double time { get; set; }
        public string locationName { get; set; }
        public int CamStatus { get; set; }
    }

}