using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Entity
{
    public class LoginDetails
    {
        #region Variables
        int userID;
        string password;
        #endregion

        #region Properties
        public int UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region Constructor
        public LoginDetails()
        {

        }
        public LoginDetails(int id,string pwd)
        {
            userID = id;
            password = pwd;
        }
        #endregion
    }
}
