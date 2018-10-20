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
        private string Check_RedioButton = "name";
        public RemoveCompany(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            MainWindow.TaskBar = "open Company Remove window";
        }

        private void RemoveCompany_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            redioBtnCompanyName.Checked = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {

                DatabaseColumn databaseColumn = new DatabaseColumn();

                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();

                CombineDataGridView combineDataGridView = new CombineDataGridView();
                if (redioBtnCompanyName.Checked == true)
                {
                    databaseColumn.company_name = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    var list = connector.SearchCompanyWithName();
                    combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview
                }
                else if (redioBtnCompanyAddress.Checked == true)
                {
                    databaseColumn.company_address = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    var list = connector.SearchCompanyWithAddress();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }
                else if (redioBtnCompanyPhoneNumber.Checked == true)
                {
                    databaseColumn.company_phone_no = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    var list = connector.SearchCompanyWithPhoneNo();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }
                else if (redioBtnCompanyId.Checked == true)
                {
                    databaseColumn.company_id = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    var list = connector.SearchCompanyWithId();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }
            }

        }
    }
}
