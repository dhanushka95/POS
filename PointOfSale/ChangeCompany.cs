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
    public partial class ChangeCompany : Form
    {
        private DataGridView mDgv;
        
        public ChangeCompany(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("ChangeCompany");
        }

     

        private void ChangeCompany_Load(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            redioBtnCompanyName.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {

                DatabaseColumn databaseColumn = new DatabaseColumn();
                List<DatabaseColumn> list = new List<DatabaseColumn>();
                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();

                CombineDataGridView combineDataGridView = new CombineDataGridView();
                if (redioBtnCompanyName.Checked == true)
                {
                    databaseColumn.company_name = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCompanyWithName();
                    combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview

                }
                else if (redioBtnCompanyAddress.Checked == true)
                {
                    databaseColumn.company_address = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCompanyWithAddress();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }
                else if (redioBtnCompanyPhoneNumber.Checked == true)
                {
                    databaseColumn.company_phone_no = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCompanyWithPhoneNo();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }
                else if (redioBtnCompanyId.Checked == true)
                {
                    databaseColumn.company_id = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCompanyWithId();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }



                if (list.Count > 0)
                {
                    txtCompanyAddress.Text = list[0].company_address;
                    txtCompanyId.Text = list[0].company_id;
                    txtCompanyName.Text = list[0].company_name;
                    txtCompanyPhoneNumber.Text = list[0].company_phone_no;
                }
                else
                {
                    txtCompanyAddress.Clear();
                    txtCompanyId.Clear();
                    txtCompanyName.Clear();
                    txtCompanyPhoneNumber.Clear();
                }
            }


        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure update company details?", "Veryfy", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {

                /*catch update details into databaseColumn*/
                DatabaseColumn updateDatabaseColumn = new DatabaseColumn();
                updateDatabaseColumn.company_id = txtCompanyId.Text.ToString();
                updateDatabaseColumn.company_name = txtCompanyName.Text.ToString();
                updateDatabaseColumn.company_address = txtCompanyAddress.Text.ToString();
                updateDatabaseColumn.company_phone_no = txtCompanyPhoneNumber.Text.ToString();



                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();
                connector.SetData(updateDatabaseColumn);

                if (connector.ChangeCompany() == true)
                {
                    MessageBox.Show("Update compliete");

                    /*refresh main data grid view and show update company deteils*/
                    redioBtnCompanyId.Checked = true;
                    txtSearch.Text = txtCompanyId.Text;
                    btnSearch.PerformClick();
               
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyAddress.Text != "" && txtCompanyId.Text != "" && txtCompanyName.Text != "" && txtCompanyPhoneNumber.Text != "")
            {
                btnChange.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
            }
        
        
        }

        private void txtCompanyPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyAddress.Text != "" && txtCompanyId.Text != "" && txtCompanyName.Text != "" && txtCompanyPhoneNumber.Text != "")
            {
                btnChange.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
            }

        }

        private void txtCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyAddress.Text != "" && txtCompanyId.Text != "" && txtCompanyName.Text != "" && txtCompanyPhoneNumber.Text != "")
            {
                btnChange.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
            }

        }
    }
}
