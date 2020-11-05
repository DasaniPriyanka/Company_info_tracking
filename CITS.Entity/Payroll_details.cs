using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Entity
{
    public class Payroll_Details
    {
        #region Variables
        double basicSalary;
        double totalDaysWorked;
        double hourlyRate;
        double deductions;
        #endregion

        #region Properties
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double TotalDaysWorked { get => totalDaysWorked; set => totalDaysWorked = value; }
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        public double Deductions { get => deductions; set => deductions = value; }
        #endregion

        #region Constructor
        public Payroll_Details()
        {

        }
        public Payroll_Details(double basicSal, double days, double hourRate, double deduct)
        {
            basicSalary = basicSal;
            totalDaysWorked = days;
            hourlyRate = hourRate;
            deductions = deduct;
        }
        #endregion
    }
}
