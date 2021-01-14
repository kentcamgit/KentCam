using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KentCamAttendanceController.Common
{
    public class GlobalMethods
    {
        public static string NullCheckString(object NewVal)
        {
            if (NewVal is DBNull)
            {
                return "";
            }
            else if ((NewVal == null) == true)
            {
                return "";
            }
            else if (NewVal is string)
            {
                return (string)NewVal;
            }
            else if (NewVal is bool)
            {
                if ((bool)NewVal == true)
                    return "1";
                else
                    return "0";
            }
            else if (NewVal is int | NewVal is decimal | NewVal is long | NewVal is double | NewVal is float | NewVal is Int64 | NewVal is Int32 | NewVal is Int16)
            {
                return Convert.ToString(NewVal);
            }
            return Convert.ToString(NewVal);
        }
    }
}