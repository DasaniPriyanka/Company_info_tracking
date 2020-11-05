using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Entity
{
    public class Attendance
    {
        #region variables
        int employeeID;
        DateTime date;
        DateTime intime;
        DateTime outtime;
        string notes;
        #endregion

        #region properties
        public int EmployeeID { get => EmployeeID; set => EmployeeID = value; }
        public DateTime Date { get => Date; set => Date = value; }
        public DateTime Intime { get => intime; set => intime = value; }
        public DateTime Outtime { get => outtime; set => outtime = value; }
        public string Notes { get => notes; set => notes = value; }

        #endregion

        #region constructors
        public Attendance()
        {

        }


        public Attendance(int empID, DateTime dt, DateTime intm, DateTime outtm, string nts)
        {
            employeeID = empID;
            Date = dt;
            intime = intm;
            outtime = outtm;
            notes = nts;

        }
        #endregion
    }
}
