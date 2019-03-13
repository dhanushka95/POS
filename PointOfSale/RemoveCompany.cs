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
    public partial class RemoveCompany : Form
    {
        private DataGridView mDgv;
       
        public RemoveCompany(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("RemoveCompany");
        }

        private void RemoveCompany_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            redioBtnCompanyName.Checked = true;
        }

      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            CombineDataGridView combineDataGridView = new CombineDataGridView();

            if (txtSearch.Text != "")
            {

                DatabaseColumn databaseColumn = new DatabaseColumn();
                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();

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
            else
            {
                combineDataGridView.SetDataGridViewList(list, mDgv);
               
            }
        }

        private void txtCompanyId_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyId.Text!="")
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure delete company?", "Veryfy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                /*catch update details into databaseColumn*/
                DatabaseColumn deleteDatabaseColumn = new DatabaseColumn();
                deleteDatabaseColumn.company_id = txtCompanyId.Text.ToString();
                deleteDatabaseColumn.company_name = txtCompanyName.Text.ToString();
                deleteDatabaseColumn.company_address = txtCompanyAddress.Text.ToString();
                deleteDatabaseColumn.company_phone_no = txtCompanyPhoneNumber.Text.ToString();



                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();
                connector.SetData(deleteDatabaseColumn);

                if (connector.RemoveCompany() == true)
                {
                    MessageBox.Show("Delete compliete");

                    /*refresh main data grid view*/
                    redioBtnCompanyId.Checked = true;
                    txtSearch.Text = txtCompanyId.Text;
                    btnSearch.PerformClick();
                    txtSearch.Clear();

                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }


        }
    }
}
