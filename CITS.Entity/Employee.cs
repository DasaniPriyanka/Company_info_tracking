using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Entity
{
    public class Employee
    {
        #region Variables
        int employeeID;
        string employeeName;
        string employeeAddress;
        DateTime dateOfBirth;
        string contactNumber;
        string emailID;


        #endregion

        #region Properties
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeAddress { get => employeeAddress; set => employeeAddress = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string EmailID { get => emailID; set => emailID = value; }
        #endregion

        #region Constructors
        public Employee()
        {

        }
        public Employee(int empId, string empName, string addr, DateTime dob, string contactNum, string email)
        {
            EmployeeID = empId;
            employeeName = empName;
            EmployeeAddress = addr;
            dateOfBirth = dob;
            ContactNumber = contactNum;
            emailID = email;
        }
        #endregion
    }
}
