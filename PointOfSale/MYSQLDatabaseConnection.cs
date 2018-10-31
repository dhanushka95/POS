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

        public void SetData(DatabaseColumn _databaseColumn)
        {
            this.databaseColumn = _databaseColumn;
        }

    }
}
