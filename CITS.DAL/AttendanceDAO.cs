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
    public class AttendanceDAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        List<Attendance> myattendance = null;
        DataTable mydt = null;
        public AttendanceDAO()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.//SQLEXPRESS01;Integerated Security=true;Database=CompanyInfoTracking";
        }

        public int TotalNoOfDaysWorked(Attendance a)
        {
            int days = 0;
            return days;
        }
        public int OverTimeHours(Attendance a1)
        {
            int hours = 0;
            return hours;
        }
    }
}

