using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace PointOfSale
{
    class MYSQLDatabaseConnection :Connector
    {  //establish , mysql database connection

        private DatabaseColumn databaseColumn;
        MySqlConnection mysqlConnection = null;
        bool isOpen = false;
        string Query;
        private int _id, _type;

        

        public bool establish()
        {
            try {
                /*read file and get Server details*/
                string path = Application.StartupPath.ToString();
                ServerDetails serverDetails = new ServerDetailsFile();
                serverDetails.filePath=path + @"\dhanushka\databaseDetails.txt";
                serverDetails.Read();

                /*build Mysql connection*/
                MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

                    connBuilder.Server = serverDetails.Ip;
                    connBuilder.UserID = serverDetails.UserName;
                    connBuilder.Database = serverDetails.dataBase;
                    connBuilder.Password = serverDetails.password;
                    connBuilder.OldGuids = true;

                mysqlConnection = new MySqlConnection(connBuilder.ConnectionString);
                mysqlConnection.Open();
               
                isOpen = true;
            }
            catch(Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                isOpen = false;
            }
            return isOpen;
            
        }
        public Boolean CheckLogin()
        {/*check user name and password is correct*/
            try {
                DatabaseColumn databaseColumn = new DatabaseColumn();

                Query = " Select Count(*) From  user where user_name = '" + this.databaseColumn.user_name + "' and password = '" +this.databaseColumn.password + "'";
                
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();


                if (reader["Count(*)"].ToString() == "1")
                {
                    MainWindow.TaskBar = "hi " +this.databaseColumn.user_name;
                    return true;
                }
                else
                {
                    return false;
                }
                mysqlConnection.Close();

            }
            catch (Exception e)
            {
               
                return false;
            }
           
        }
     

        public bool InsertCompanyDetails()
        {/*insert company details into database*/
            try {
                Query = "INSERT INTO `company` (`company_name`, `company_address`, `company_phone_no`,`company_id`)  VALUES ('" + this.databaseColumn.company_name + "','" + this.databaseColumn.company_address + "','" + this.databaseColumn.company_phone_no + "','"+this.databaseColumn.company_id+"')";
                
                MySqlCommand command = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                mysqlConnection.Close();
                MainWindow.TaskBar = databaseColumn.company_name+" , " + databaseColumn.company_address+" , " + databaseColumn.company_phone_no + " and " + databaseColumn.company_id + "-> insert complete";
                return true;

                 }catch(Exception e)
                {
                MainWindow.TaskBar = e.ToString();
                return false;
                }
        }
        public List<DatabaseColumn> GetAllCompanyNameWithId()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " SELECT * FROM `company` ORDER BY company_name ASC";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        company_name = reader["company_name"].ToString(),
                        company_id = reader["company_id"].ToString()
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public List<DatabaseColumn> SearchCompanyWithName()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try {
                

                Query = " Select * from `company` where `company_name` like '" + this.databaseColumn.company_name + "%' ";
                
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        company_name = reader["company_name"].ToString(),
                        company_address = reader["company_address"].ToString(),
                        company_phone_no = reader["company_phone_no"].ToString(),
                        company_id = reader["company_id"].ToString()
                    }

                        );
                }

                return list;
            }catch(Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public List<DatabaseColumn> SearchCompanyWithAddress()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " Select * from `company` where `company_address` like '" + this.databaseColumn.company_address + "%' ";
                
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        company_name = reader["company_name"].ToString(),
                        company_address = reader["company_address"].ToString(),
                        company_phone_no = reader["company_phone_no"].ToString(),
                        company_id =reader["company_id"].ToString()
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public List<DatabaseColumn> SearchCompanyWithPhoneNo()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " Select * from `company` where `company_phone_no` like '" + this.databaseColumn.company_phone_no + "%' ";
                
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        company_name = reader["company_name"].ToString(),
                        company_address = reader["company_address"].ToString(),
                        company_phone_no = reader["company_phone_no"].ToString(),
                        company_id =reader["company_id"].ToString()
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public List<DatabaseColumn> SearchCompanyWithId()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " Select * from `company` where `company_id` like '" + this.databaseColumn.company_id + "%' ";
                
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        company_name = reader["company_name"].ToString(),
                        company_address = reader["company_address"].ToString(),
                        company_phone_no = reader["company_phone_no"].ToString(),
                        company_id =reader["company_id"].ToString()
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public bool ChangeCompany()
        {          
            try
            {
                Query = " update `company`  SET `company_name`='" + this.databaseColumn.company_name+ "' ,`company_address`='"+this.databaseColumn.company_address+ "' ,`company_phone_no`='"+this.databaseColumn.company_phone_no+ "' where `company_id`='" + this.databaseColumn.company_id+"' ";
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
                MainWindow.TaskBar = e.ToString();
            }

            
        }
        public bool RemoveCompany()
        {
            try
            {
                Query = "delete from `company` where `company_id`='"+this.databaseColumn.company_id+"'";
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                MainWindow.TaskBar = e.ToString();
            }
        }
        public List<DatabaseColumn> GetAllCategoryNameWithId()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " SELECT * FROM `category` ORDER BY category_name ASC";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        category_name = reader["category_name"].ToString(),
                        category_id = reader["cotegory_id"].ToString()
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public List<DatabaseColumn> GetCategoryNameForEachCompany()
        {    /*you have to set company name into SetData after this can execute*/
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " SELECT * FROM `product_details`,`company`,`category`  WHERE company.company_id=product_details.company_id AND category.cotegory_id=product_details.cotegory_id AND company.company_id='" + this.databaseColumn.company_id+"'";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        category_name = reader["category_name"].ToString(),
                        category_id = reader["cotegory_id"].ToString()
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public List<DatabaseColumn> GetProductNameForEachCompanyAndCategory()
        {
            /*you have to set company name amd category name into SetData after this can execute*/
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " SELECT * FROM `product_details`,`company`,`category`  WHERE company.company_id=product_details.company_id AND category.cotegory_id=product_details.cotegory_id AND company.company_id='" + this.databaseColumn.company_id + "' AND category.cotegory_id='" + this.databaseColumn.category_id+"'";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        product_name = reader["product_name"].ToString(),
                        product_id = reader["product_id"].ToString()
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public bool InsertCategoryDetails()
        {
            /*insert company details into database*/
            try
            {
                Query = "INSERT INTO `category` (`category_name`, `cotegory_id`)  VALUES ('" + this.databaseColumn.category_name + "','" + this.databaseColumn.category_id + "')";
                
                MySqlCommand command = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                mysqlConnection.Close();
                MainWindow.TaskBar = databaseColumn.category_name+" and "+databaseColumn.category_id+" -> insert complete";
                return true;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return false;
            }

        }
        public List<DatabaseColumn> SearchCategoryWithName()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " Select * from `category` where `category_name` like '" + this.databaseColumn.category_name + "%' ";
                
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        category_name = reader["category_name"].ToString(),
                        category_id = reader["cotegory_id"].ToString()
                        
                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }

        public List<DatabaseColumn> SearchCategoryWithId()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = " Select * from `category` where `cotegory_id` like '" + this.databaseColumn.category_id + "%' ";
                
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        category_name = reader["category_name"].ToString(),
                        category_id = reader["cotegory_id"].ToString()

                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }

        public bool ChangeCategory()
        {

            try
            {
                Query = " update `category`  SET `category_name`='" + this.databaseColumn.category_name + "' where `cotegory_id`='" + this.databaseColumn.category_id + "' ";
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                MainWindow.TaskBar = e.ToString();
            }


        }
        public bool RemoveCategory()
        {
            try
            {
                Query = "delete from `category` where `cotegory_id`='" + this.databaseColumn.category_id + "'";
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                MainWindow.TaskBar = e.ToString();
            }

        }

        public bool InsertProductDetails()
        {
            try
            {
                Query = "INSERT INTO `product_details` (`company_id`, `cotegory_id`, `product_name`,`product_id`,`minimum_quantity`,`sell_price`,`product_discount_price`)  VALUES ('" + this.databaseColumn.company_id + "','" + this.databaseColumn.category_id + "','" + this.databaseColumn.product_name + "','" + this.databaseColumn.product_id + "','" + this.databaseColumn.minimum_quantity + "','" + this.databaseColumn.sell_price + "','" + this.databaseColumn.product_discount_price + "')";

                MySqlCommand command = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                mysqlConnection.Close();
                MainWindow.TaskBar = "\n"+databaseColumn.product_name + " , " + databaseColumn.product_id + " , " + databaseColumn.sell_price + " , " + databaseColumn.product_discount_price + " , " + databaseColumn.minimum_quantity + " , " + databaseColumn.company_name + "/" + databaseColumn.company_id + " and " + databaseColumn.category_name + " /" + databaseColumn.category_id + "-> insert complete";
                return true;

            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return false;
            }
        }
        public List<DatabaseColumn> GetAllProductNameWithId()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = "SELECT * FROM `product_details`";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                       
                        product_id = reader["product_id"].ToString(),
                        product_name = reader["product_name"].ToString()
                      

                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public List<DatabaseColumn> SearchProductNameWithCompanuAndCategoryName()
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            try
            {


                Query = "SELECT * FROM `product_details` ,`company`,`category` WHERE company.company_name ='" + this.databaseColumn.company_name+ "' and category.category_name ='" + this.databaseColumn.category_name + "' and product_details.company_id=company.company_id and product_details.cotegory_id=category.cotegory_id ORDER BY `product_id` ASC";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DatabaseColumn()
                    {
                        category_name = reader["category_name"].ToString(),
                        category_id = reader["cotegory_id"].ToString(),
                        company_id= reader["company_id"].ToString(),
                        company_name= reader["company_name"].ToString(),
                        product_id= reader["product_id"].ToString(),
                        product_discount_price=reader["product_discount_price"].ToString(),
                        product_name= reader["product_name"].ToString(),
                        sell_price= reader["sell_price"].ToString(),
                        minimum_quantity= reader["minimum_quantity"].ToString()

                    }

                        );
                }

                return list;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return list;
            }
        }
        public DatabaseColumn GetProductDetails()
        {

           DatabaseColumn databaseColumn = new DatabaseColumn();
            try
            {


                Query = "SELECT * FROM `product_details` ,`company`,`category` WHERE company.company_id='" + this.databaseColumn.company_id + "' and category.cotegory_id='" + this.databaseColumn.category_id + "' and product_details.product_id='" + this.databaseColumn.product_id+"' and product_details.company_id=company.company_id and product_details.cotegory_id=category.cotegory_id ORDER BY `product_id` ASC";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    databaseColumn.category_name = reader["category_name"].ToString();
                    databaseColumn.category_id = reader["cotegory_id"].ToString();
                    databaseColumn.company_id = reader["company_id"].ToString();
                    databaseColumn.company_name = reader["company_name"].ToString();
                    databaseColumn.product_id = reader["product_id"].ToString();
                    databaseColumn.product_discount_price = reader["product_discount_price"].ToString();
                    databaseColumn.product_name = reader["product_name"].ToString();
                    databaseColumn.sell_price = reader["sell_price"].ToString();
                    databaseColumn.minimum_quantity = reader["minimum_quantity"].ToString();

                }

                        
                

                return databaseColumn;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return databaseColumn;
            }
        }
        public bool RemoveProductDetails()
        {
            try
            {
                Query = "delete from `product_details` where `cotegory_id`='" + this.databaseColumn.category_id + "' and company_id='"+this.databaseColumn.company_id+"' and product_id='"+this.databaseColumn.product_id+"'";
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                MainWindow.TaskBar = e.ToString();
            }
        }
        public bool ChangeProductDetails()
        {
            try
            {
                Query = " update `product_details`  SET `product_name`='" + this.databaseColumn.product_name + "' ,`minimum_quantity`='"+this.databaseColumn.minimum_quantity+ "' ,`sell_price`='"+this.databaseColumn.sell_price+ "' ,`product_discount_price`='"+this.databaseColumn.product_discount_price+"' where `cotegory_id`='" + this.databaseColumn.category_id + "' and `company_id`='"+this.databaseColumn.company_id+ "' and `product_id`='"+this.databaseColumn.product_id+"' ";
                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                MainWindow.TaskBar = e.ToString();
            }


        }

        public bool InsertStock() {
            try
            {
                Query = "INSERT INTO `stock` (`E_D`, `product_id`, `barcode`,`stock_date`,`invoice_number`,`start_quantity`,`current_quantity`,`exp_date`,`get_price`)  VALUES ('" + this.databaseColumn.E_D + "','" + this.databaseColumn.product_id + "','" + this.databaseColumn.barcode + "','" + this.databaseColumn.stock_date + "','" + this.databaseColumn.invoice_number + "','" + this.databaseColumn.start_quantity + "','" + this.databaseColumn.start_quantity + "','" + this.databaseColumn.exp_date + "','" + this.databaseColumn.get_price + "')";

                MySqlCommand command = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                mysqlConnection.Close();
                MainWindow.TaskBar = "insert stock -->"+this.databaseColumn.product_name+" "+this.databaseColumn.category_name+" "+this.databaseColumn.company_name+" "+this.databaseColumn.stock_date+" "+this.databaseColumn.invoice_number+" "+this.databaseColumn.start_quantity+" "+this.databaseColumn.exp_date+" "+this.databaseColumn.get_price;
                    return true;

            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return false;
            }

        }

        public void SetData(DatabaseColumn _databaseColumn)
        {
            this.databaseColumn = _databaseColumn;
        }

       public DatabaseColumn SearchCompanyList(List<DatabaseColumn> databaseColumn, string SearchCompanyName)
        {
            DatabaseColumn result = new DatabaseColumn();
            try {
                result = databaseColumn.Find(x => x.company_name == SearchCompanyName);
                return result;
            }
            catch(Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return result;
            }
            
        }
       public DatabaseColumn SearchCategoryList(List<DatabaseColumn> databaseColumn, string SearchCategoryName)
        {
            DatabaseColumn result = new DatabaseColumn();
            try
            {
                result = databaseColumn.Find(x => x.category_name == SearchCategoryName);
                return result;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return result;
            }
        }
        public DatabaseColumn SearchProductList(List<DatabaseColumn> databaseColumn, string SearchProductName)
        {
            DatabaseColumn result = new DatabaseColumn();
            try
            {
                result = databaseColumn.Find(x => x.product_name == SearchProductName);
                return result;
            }
            catch (Exception e)
            {
                MainWindow.TaskBar = e.ToString();
                return result;
            }
        }

    }
}
