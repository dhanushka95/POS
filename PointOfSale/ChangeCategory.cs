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
    public partial class ChangeCategory : Form
    {
        private DataGridView mDgv;
        private string Check_RedioButton = "name";
        public ChangeCategory(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            MainWindow.TaskBar = "open Category change window";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {

                DatabaseColumn databaseColumn = new DatabaseColumn();

                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();

                CombineDataGridView combineDataGridView = new CombineDataGridView();
                if (redioBtnCategoryName.Checked == true)
                {
                    databaseColumn.category_name = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    var list = connector.SearchCategoryWithName();
                    combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview
                }
                else if (redioBtnCategoryId.Checked == true)
                {
                    databaseColumn.category_id = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    var list = connector.SearchCategoryWithId();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }
            }
            }

        private void ChangeCategory_Load(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            redioBtnCategoryName.Checked = true;
        }
    }
}
