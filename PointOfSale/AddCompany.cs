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
    public partial class AddCompany : Form
    {
        private DataGridView mDgv;

        public AddCompany(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("AddCompany");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {   // Add company details into database
            DatabaseColumn databaseColumn = new DatabaseColumn();

            Connector connector= new MYSQLDatabaseConnection();
            
           
            databaseColumn.company_name=txtCompayName.Text.ToString();
            databaseColumn.company_phone_no=txtCompanyPhoneNumber.Text.ToString();
            databaseColumn.company_address = txtCompanyAddress.Text.ToString();
            databaseColumn.company_id = txtCompanyId.Text.ToString();
            connector.SetData(databaseColumn);

            if (connector.establish()==true &&connector.InsertCompanyDetails()==true)
            {
                

                //create database column list with data
                var list = new List<DatabaseColumn>()
               {
               new DatabaseColumn { company_name = txtCompayName.Text.ToString(),company_phone_no =txtCompanyPhoneNumber.Text.ToString(),company_address=txtCompanyAddress.Text.ToString(),company_id=txtCompanyId.Text.ToString() }
           
                };

                CombineDataGridView combineDataGridView = new CombineDataGridView();
                combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview

                MessageBox.Show("Compleat");
                
                txtCompanyPhoneNumber.Clear();
                txtCompayName.Clear();
                txtCompanyAddress.Clear();
                txtCompanyId.Clear();
            }
            else
            {
                MessageBox.Show("operation error");
            }
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void txtCompayName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyAddress.Text.ToString()!=""&& txtCompanyPhoneNumber.Text.ToString() != "" && txtCompayName.Text.ToString() != "" && txtCompanyId.Text.ToString()!="")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void txtCompanyPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyAddress.Text.ToString() != "" && txtCompanyPhoneNumber.Text.ToString() != "" && txtCompayName.Text.ToString() != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void txtCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyAddress.Text.ToString() != "" && txtCompanyPhoneNumber.Text.ToString() != "" && txtCompayName.Text.ToString() != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
