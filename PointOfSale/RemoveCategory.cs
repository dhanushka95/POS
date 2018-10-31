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
    public partial class RemoveCategory : Form
    {
        private DataGridView mDgv;
        
        public RemoveCategory(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            MainWindow.TaskBar = "open Category remove window";
        }

        private void RemoveCategory_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            redioBtnCategoryName.Checked = true;
        }

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DatabaseColumn databaseColumn = new DatabaseColumn();
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            CombineDataGridView combineDataGridView = new CombineDataGridView();
            if (txtSearch.Text != "")
            {            

                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();

              
                if (redioBtnCategoryName.Checked == true)
                {
                    databaseColumn.category_name = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCategoryWithName();
                    combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview
                }
                else if (redioBtnCategoryId.Checked == true)
                {
                    databaseColumn.category_id = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCategoryWithId();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                }
                if (list.Count > 0)
                {
                    txtCategoryId.Text = list[0].category_id;
                    txtCategoryName.Text = list[0].category_name;
                   
                }
                else
                {
                    txtCategoryName.Clear();
                    txtCategoryId.Clear();
                    
                }

            }
            else
            {
                txtCategoryName.Clear();
                txtCategoryId.Clear();
            }

        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryId.Text!="")
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
            DialogResult dialogResult = MessageBox.Show("Are you Sure delete category?", "Veryfy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                /*catch update details into databaseColumn*/
                DatabaseColumn deleteDatabaseColumn = new DatabaseColumn();
                deleteDatabaseColumn.category_id = txtCategoryId.Text.ToString();
                deleteDatabaseColumn.category_name = txtCategoryName.Text.ToString();
                
                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();
                connector.SetData(deleteDatabaseColumn);

                if (connector.RemoveCategory() == true)
                {
                    MessageBox.Show("Delete compliete");

                    /*refresh main data grid view*/
                    redioBtnCategoryId.Checked = true;
                    txtSearch.Text = txtCategoryId.Text;
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
