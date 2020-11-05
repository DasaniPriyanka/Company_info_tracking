using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CITS.Entity;
using CITS.Exception;

namespace CITS.DAL
{
    public class LoginDAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        List<Login> mylogin = null;
        DataTable mydt = null;
        public LoginDAO()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.//SQLEXPRESS01;Integerated Security=true;Database=CompanyInfoTracking";
        }
        public bool LoginValidation(Login l)
        {
            bool res = false;
            return res;
        }
    }
}
