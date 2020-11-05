using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Exception
{
    public class CompanyException : ApplicationException
    {
        public CompanyException() : base()
        {

        }
        public CompanyException(string message) : base(message)
        {

        }

    }
}