using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Exception
{
    public class HolidayException : ApplicationException
    {
        public HolidayException() : base()
        {

        }
        public HolidayException(string message) : base(message)
        {

        }
    }
}