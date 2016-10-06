using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Models;

namespace WinFormUI.Util
{
    public class Global
    {
        public static Korisnik logiraniKorisnik { get; set; }
        public static Form frmMain { get; set; }
        public static string GetMessage(string key)
        {
            ResourceManager rm = new ResourceManager("WinFormUI.Util.Messages",Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}
