using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAPI.DAL {
    public class Connection {
        public static SqlConnection getConnection() {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
            cn.Open();
            return cn;
        }
    }
}