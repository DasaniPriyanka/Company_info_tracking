using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Exception
{
    class LoginException : ApplicationException
    {
        public LoginException() : base()
        {

        }
        public LoginException(string message) : base(message)
        {

        }

    }
}
