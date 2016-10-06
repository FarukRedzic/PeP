using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhoneUI.ExtensionKlase {
    public static class DateTimeExtension {

        public static string ToApiDateTime(this DateTime dateTime) {
            string date = dateTime.ToString();
            date = date.Replace(':', 'X');
            date = date.Replace('/', '-');
            date = date.Replace(" AM", "");
            date = date.Replace(" PM", "");
            date = date.Replace("31", "12");
            return date;
        }

        public static DateTime ApiToDateTime(this string dateData) {
            return Convert.ToDateTime(dateData.Replace("X", ":"));
        }
    }
}
