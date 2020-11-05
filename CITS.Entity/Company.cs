using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CITS.Entity
{
    public class Company
    {
        #region variables
        int companyID;
        string companyName;
        string companyAddress;
        string companycontactNumber;
        string companyBranch;


        #endregion

        #region properties

        public int CompanyID { get => companyID; set => companyID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string CompanyAddress { get => companyAddress; set => companyAddress = value; }
        public string CompanycontactNumber { get => companycontactNumber; set => companycontactNumber = value; }
        public string CompanyBranch { get => companyBranch; set => companyBranch = value; }
        
        #endregion

        #region constructors
        public Company()
        {

        }


       
        public Company(int compID, string compName,string compAddress,string compcontactNumber,string compBranch)
        {
            companyID = compID;
            companyName = compName;
            CompanyAddress = compAddress;
            companycontactNumber = compcontactNumber;
            companyBranch = compBranch;

        }
        #endregion


        

        



    }
}
