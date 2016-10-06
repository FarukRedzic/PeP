using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Util 
{
    public static class DateTimeExtension 
    {
        public static string ToApiDateTime(this DateTime dateTime) 
        {
            return dateTime.ToString().Replace(":", "X");
        }

        public static DateTime ApiToDateTime(this string dateData) 
        {
            return Convert.ToDateTime(dateData.Replace("X", ":"));
        }
    }
}