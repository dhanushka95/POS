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
    public partial class AddAccount : Form
    {
        private DataGridView dgv;
        private List<DatabaseColumn> counterList = new List<DatabaseColumn>();
        public AddAccount(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            DatabaseColumn dataset = new DatabaseColumn();
            Connector connection = new MYSQLDatabaseConnection();

            

            dataset.counter_id = connection.SearchCounterList(counterList, cmbCounterName.Text.ToString()).counter_id;
            dataset.type = cmbType.SelectedIndex.ToString();
            dataset.user_name = txtUserName.Text.ToString();
            dataset.user_id = txtUserId.Text.ToString();
            dataset.password = txtPassword.Text.ToString();
            dataset.counter_name = cmbCounterName.Text.ToString();

            connection.SetData(dataset);
            connection.establish();

            if (connection.InsertUser())
            {
                MessageBox.Show("Complete");
                txtPassword.Clear();
                txtUserId.Clear();
                txtUserName.Clear();
                txtVerifyPassowrd.Clear();
            }
            else
            {
                MessageBox.Show("Error");

            }


        }

        private void AddAccount_Shown(object sender, EventArgs e)
        {
            cmbCounterName.Focus();
            Connector connection = new MYSQLDatabaseConnection();
            connection.establish();

           List<DatabaseColumn> Data= connection.GetCounter();
          //  counterList.Clear();
            cmbCounterName.Items.Clear();
            foreach (DatabaseColumn data in Data)
            {
                cmbCounterName.Items.Add(data.counter_name);
                counterList.Add(data);
            }
        }
    }
}
