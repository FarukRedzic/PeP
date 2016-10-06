using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAPI.Util
{
    public class ExceptionHandler
    {  
        public static string HandleSQLException(DbUpdateException ex)
        {
            string error = ex.InnerException.InnerException.ToString();

            int pocetak = error.IndexOf("X");
            int kraj = error.IndexOf("'", pocetak + 1);
            //if (pocetak == 0 && kraj == 0) return string.Empty;
            string exceptionName = error.Substring(pocetak + 1, kraj - pocetak - 1);
            return (exceptionName.Equals("_Email")) ? "email_con" : (exceptionName.Equals("_KorisnickoIme")) ? "username_con" : (exceptionName.Equals("_Favoriti")) ? "favorit_con" : "SQLServerGreska";

            

        }
    }
}