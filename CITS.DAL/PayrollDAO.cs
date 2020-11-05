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
    public class PayrollDAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        List<Payroll_Details> mypayroll = null;
        DataTable mydt = null;
        public PayrollDAO()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.//SQLEXPRESS01;Integerated Security=true;Database=Employee_Details";
        }
        public bool SalaryHike(Payroll_Details p1)
        {
            bool res = false;
            return res;
        }
        public bool StopPayment(Payroll_Details p1)
        {
            bool res = false;
            return res;
        }
        public bool OverTimeAllowances(Payroll_Details p1)
        {
            bool res = false;
            return res;
        }

    }
}
