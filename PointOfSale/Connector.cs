using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    interface Connector
    {

        bool establish();
     
        bool CheckLogin();
     
        bool InsertCompanyDetails();

        string userName
        {
            get;
            set;
        }
        string password
        {
            get;
            set;
        }
        string companyId
        {
            get;
            set;
        }
        string companyName
        {
            get;
            set;
        }
        string companyPhoneNumber
        {
            get;
            set;
        }
        int id
        {
            get;
            set;
        }
        int type
        {
            get;
            set;
        }
    }
}
