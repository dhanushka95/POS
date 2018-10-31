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
        bool InsertCategoryDetails();
        void SetData(DatabaseColumn _databaseColumn);
        List<DatabaseColumn> SearchCompanyWithName();
        List<DatabaseColumn> SearchCompanyWithAddress();
        List<DatabaseColumn> SearchCompanyWithPhoneNo();
        List<DatabaseColumn> SearchCompanyWithId();
        bool ChangeCompany();
        bool RemoveCompany();
        List<DatabaseColumn> SearchCategoryWithName();
        List<DatabaseColumn> SearchCategoryWithId();
        bool ChangeCategory();
        bool RemoveCategory();


    }
}
