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
    public partial class AddCategory : Form
    {
        private DataGridView mDgv;
        public AddCategory(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("AddCategory");
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            Connector databaseConnect = new MYSQLDatabaseConnection();
            DatabaseColumn databaseColumn = new DatabaseColumn();

            databaseColumn.category_name = txtCategoryName.Text.ToString();
            databaseColumn.category_id = txtCategoryId.Text.ToString();

            databaseConnect.SetData(databaseColumn);

            

            if (databaseConnect.establish()==true && databaseConnect.InsertCategoryDetails()==true)
            {

                var list = new List<DatabaseColumn>()
               {
               new DatabaseColumn { category_name = txtCategoryName.Text.ToString(),category_id =txtCategoryId.Text.ToString()}

                };
                CombineDataGridView combineDataGridView = new CombineDataGridView();
                combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview

                txtCategoryId.Clear();
                txtCategoryName.Clear();
            }
            else
            {
                MessageBox.Show("operation error");
            }
        }
    }
}
