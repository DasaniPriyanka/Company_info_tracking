using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Exception
{
    public class EmployeeException : ApplicationException
    {
        public EmployeeException() :base()
        {

        }
        public EmployeeException(string message):base(message)
        {

        }
    }
}
