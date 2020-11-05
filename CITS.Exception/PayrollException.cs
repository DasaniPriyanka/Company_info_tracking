using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Exception
{
    public class PayrollException : ApplicationException
    {
        public PayrollException() : base()
        {

        }
        public PayrollException(string message):base(message)
        {

        }
    }
}
