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
    public class HolidayDAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        List<Holiday> myholiday = null;
        DataTable mydt = null;
        public HolidayDAO()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.//SQLEXPRESS01;Integerated Security=true;Database=CompanyInfoTracking";
        }
        public List<Holiday> ListOfPublicHolidays()
        {
            return myholiday;
        }
    }
}
