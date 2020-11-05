using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Entity
{
    public class Holiday
    {
        #region variables
        int year;
        DateTime holidayDate;
        string holidayDescription;
        #endregion


        #region properties
        public int Year { get => year; set => year = value; }
        public DateTime HolidayDate { get => holidayDate; set => holidayDate = value; }
        public string HolidayDescription { get => holidayDescription; set => holidayDescription = value; }

        #endregion

        #region constructors
        public Holiday()
        {

        }



        public Holiday(int yr, DateTime holiDate,string holiDescription)
        {
            year = yr;
            holidayDate = holiDate;
            holidayDescription = holiDescription;

        }
        #endregion




    }
}
