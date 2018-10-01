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
        private string _userName, _password, _companyId, _companyName, _companyPhoneNumber;
       
        MySqlConnection mysqlConnection = null;
        bool isOpen = false;
        string Query;
        private int _id, _type;

      public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string companyId
        {
            get { return _companyId; }
            set { _companyId = value; }
        }
        public string companyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public string companyPhoneNumber
        {
            get { return _companyPhoneNumber; }
            set { _companyPhoneNumber = value; }
        }
        public int id
        {
            get { return id; }
            set { _id = value; }
         }
        public int type
        {
            get { return _type; }
            set { _type = value; }
        }

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
                isOpen = false;
            }
            return isOpen;
            
        }
        public Boolean CheckLogin()
        {/*check user name and password is correct*/
            try {
                Query = " Select Count(*),value,id From  login where USERname = '" + _userName + "' and password = '" +_password + "'";

                MySqlCommand cmd = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();


                if (reader["Count(*)"].ToString() == "1")
                {
                    id = int.Parse(reader["id"].ToString());
                    type = int.Parse(reader["value"].ToString());
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
                Query = "INSERT INTO `company` (`company_id`, `company_name`, `phone`)  VALUES ('" + this._companyId + "','" + this._companyName + "','" + this._companyPhoneNumber + "')";
                MySqlCommand command = new MySqlCommand(Query, mysqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                mysqlConnection.Close();

            return true;
            }catch(Exception e)
            {
                return false;
            }
        }

    }
}
