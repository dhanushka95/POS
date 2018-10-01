using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class ServerConfiguration : Form
    {
        public ServerConfiguration()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure","Update it?",MessageBoxButtons.YesNo);
            /*Confirm user want yes or no*/
            if (dialogResult==DialogResult.Yes) {

                /*save server details into file*/
                string path = Application.StartupPath.ToString();

                ServerDetails serverDetails = new ServerDetailsFile();
                serverDetails.filePath=path + @"\dhanushka\databaseDetails.txt";
                serverDetails.Ip=txtIp.Text.ToString();
                serverDetails.UserName=txtUserName.Text.ToString();
                serverDetails.password=txtPassword.Text.ToString();
                serverDetails.dataBase=txtDatabase.Text.ToString();

                if (serverDetails.Write() == true)
                {
                    MessageBox.Show("Compleate");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("File write erro");
                }
            }

        }
    }
}
