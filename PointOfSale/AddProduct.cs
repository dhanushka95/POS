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
    public partial class AddProduct : Form
    {
        private DataGridView mDgv;
        List<DatabaseColumn> TempCompanyList = new List<DatabaseColumn>();// this is use to catch company deteils
        List<DatabaseColumn> TempCategoryList = new List<DatabaseColumn>();// this is use to catch category deteils
        public AddProduct(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("AddProduct");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
         
        }

        private void AddProduct_Shown(object sender, EventArgs e)
        {
           
            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                Connector databaseConnectCompany = new MYSQLDatabaseConnection();
                Connector databaseConnectCategory = new MYSQLDatabaseConnection();
                if (databaseConnectCompany.establish() == true && databaseConnectCategory.establish() == true)
                {

                    List<DatabaseColumn> CompanyList = databaseConnectCompany.GetAllCompanyNameWithId();
                    List<DatabaseColumn> CategoryList = databaseConnectCategory.GetAllCategoryNameWithId();
                    foreach (DatabaseColumn databseColumn in CompanyList)
                    {
                        cmbCompanyName.Items.Add(databseColumn.company_name);//add company name into combo box
                        TempCompanyList.Add(new DatabaseColumn()
                        {
                            company_name = databseColumn.company_name,
                            company_id = databseColumn.company_id,
                        }
                         );
                    }
                    foreach (DatabaseColumn databseColumn in CategoryList)
                    {
                        cmbCategoryName.Items.Add(databseColumn.category_name);//add category name into combo box
                        TempCategoryList.Add(new DatabaseColumn()
                        {
                            category_name = databseColumn.category_name,
                            category_id = databseColumn.category_id,
                        }
                         );
                    }

                }
                else
                {
                    MessageBox.Show("connection error");
                }


            }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            if (txtDiscount.Text != "" && txtMinimumQuantity.Text != "" && txtProductId.Text != "" && txtProductName.Text != "" && txtSellPrice.Text != "" && cmbCategoryName.Text != "" && cmbCompanyName.Text != "")
            {
                Connector databaseConnect = new MYSQLDatabaseConnection();
                DatabaseColumn databaseColumn = new DatabaseColumn();
                
                CombineDataGridView combineDataGridView = new CombineDataGridView();
                List<DatabaseColumn> list = new List<DatabaseColumn>();

                /*get data into database column object*/
                databaseColumn.product_id = txtProductId.Text.ToString();
                databaseColumn.product_name = txtProductName.Text.ToString();
                databaseColumn.company_name = cmbCompanyName.Text;
                databaseColumn.category_id = databaseConnect.SearchCategoryList(TempCategoryList, cmbCategoryName.Text).category_id;
                databaseColumn.category_name = cmbCategoryName.Text;
                databaseColumn.company_id = databaseConnect.SearchCompanyList(TempCompanyList, cmbCompanyName.Text).company_id;
                databaseColumn.minimum_quantity = txtMinimumQuantity.Text.ToString();
                databaseColumn.product_discount_price = txtDiscount.Text.ToString();
                databaseColumn.sell_price = txtSellPrice.Text.ToString();


                databaseConnect.SetData(databaseColumn);
                databaseConnect.establish();

                if (databaseConnect.InsertProductDetails() == true)
                {
                    list.Add(databaseColumn);
                    combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview
                    MessageBox.Show("comlete");
                    txtDiscount.Clear();
                    txtMinimumQuantity.Clear();
                    txtProductId.Clear();
                    txtProductName.Clear();
                    txtSellPrice.Clear();
                    cmbCategoryName.Text = "";
                    cmbCompanyName.Text = "";
                }
                else
                {
                    MessageBox.Show("operation error");
                }
            }
            else
            {
                MessageBox.Show("Fill all deteils");
            }

        }
    }
}
