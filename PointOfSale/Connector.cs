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
        List<DatabaseColumn> GetAllCompanyNameWithId();
        List<DatabaseColumn> SearchCompanyWithName();
        List<DatabaseColumn> SearchCompanyWithAddress();
        List<DatabaseColumn> SearchCompanyWithPhoneNo();
        List<DatabaseColumn> SearchCompanyWithId();
        bool ChangeCompany();
        bool RemoveCompany();
        List<DatabaseColumn> GetAllCategoryNameWithId();
        List<DatabaseColumn> SearchCategoryWithName();
        List<DatabaseColumn> SearchCategoryWithId();
        bool ChangeCategory();
        bool RemoveCategory();
        bool InsertProductDetails();
        List<DatabaseColumn> GetAllProductNameWithId();
        List<DatabaseColumn> GetProductNameForEachCompanyAndCategory();
        DatabaseColumn GetProductDetails();
        List<DatabaseColumn> GetCategoryNameForEachCompany();
        List<DatabaseColumn> SearchProductNameWithCompanuAndCategoryName();
        bool ChangeProductDetails();
        bool RemoveProductDetails();
        bool InsertStock();
        DatabaseColumn GetStockUsingBarcode();
        bool ChangeStockDetails();
        bool RemoveStockDetails();
        List<DatabaseColumn> GetCounter();
        bool InsertUser();
        DatabaseColumn SearchCompanyList(List<DatabaseColumn> databaseColumn, string SearchCompanyName);
        DatabaseColumn SearchCategoryList(List<DatabaseColumn> databaseColumn, string SearchCategoryName);
        DatabaseColumn SearchProductList(List<DatabaseColumn> databaseColumn, string SearchCategoryName);
        DatabaseColumn SearchCounterList(List<DatabaseColumn> databaseColumn, string SearchCounterName);
    }
}
