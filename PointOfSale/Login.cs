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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                prograsbarLogin.Value = 50;

                Connector databaseConnection = new MYSQLDatabaseConnection();

                databaseConnection.userName=txtUserName.Text.ToString();
                databaseConnection.password=txtPassword.Text.ToString();

                prograsbarLogin.Value = 80;

            if (databaseConnection.establish() == true)
            {
                     if (databaseConnection.CheckLogin() == true) {
                         prograsbarLogin.Value = 100;
                    MainWindow mainWindow = new MainWindow();
                    
                          this.Hide();
                          mainWindow.Show();
                        }
                        else
                        {
                         prograsbarLogin.Value = 100;
                          MessageBox.Show("wrong Password!");
                        }
                
            }
            else
            {
                ServerConfiguration serverConfiguration = new ServerConfiguration();
                serverConfiguration.Show();
                
            }

        }
        public Point mouseLocation;// get mous location for move form
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X , -e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToString()!="" && txtUserName.Text.ToString()!="")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToString() != "" && txtUserName.Text.ToString() != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
    }
}
