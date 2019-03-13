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
    public partial class AddStock : Form
    {
        private DataGridView mDgv;
        private List<DatabaseColumn> tempCompanyList = new List<DatabaseColumn>();
        private List<DatabaseColumn> tempCategoryList = new List<DatabaseColumn>();
        private List<DatabaseColumn> tempProductList = new List<DatabaseColumn>();

        private DatabaseColumn companyId = new DatabaseColumn();
        private DatabaseColumn categoryId = new DatabaseColumn();
        private DatabaseColumn productId = new DatabaseColumn();

        public AddStock(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("AddStock");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string[] x = { cmbProductName.Text.ToString(),cmbCategoryName.Text.ToString(), cmbCompanyName.Text.ToString(),productId.product_id ,txtStockDate.Text.ToString() , txtInvoiceNumber.Text.ToString(), txtQuantity.Text.ToString(),txtExpDate.Text.ToString(),txtGetPrice.Text.ToString()};
            ScanBarcode scanBarcode = new ScanBarcode(x,mDgv);
            scanBarcode.Show();
            
        }

        private void AddStock_Load(object sender, EventArgs e)
        {



        }

        private void AddStock_Shown(object sender, EventArgs e)
        {
            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                Connector databaseConnectCompany = new MYSQLDatabaseConnection();
               
                if (databaseConnectCompany.establish() == true)
                {

                    List<DatabaseColumn> CompanyList = databaseConnectCompany.GetAllCompanyNameWithId();
                    
                    foreach (DatabaseColumn databseColumn in CompanyList)
                    {
                        cmbCompanyName.Items.Add(databseColumn.company_name);//add company name into combo box

                        tempCompanyList.Add(new DatabaseColumn()
                        {
                            company_name = databseColumn.company_name,
                            company_id = databseColumn.company_id,
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

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                Connector databaseConnectCategory= new MYSQLDatabaseConnection();

                companyId = databaseConnectCategory.SearchCompanyList(tempCompanyList,cmbCompanyName.SelectedItem.ToString());

                if (databaseConnectCategory.establish() == true)
                {
                    databaseConnectCategory.SetData(companyId);
                    List<DatabaseColumn> CategoryList = databaseConnectCategory.GetCategoryNameForEachCompany();

                    foreach (DatabaseColumn databseColumn in CategoryList)
                    {
                        cmbCategoryName.Items.Add(databseColumn.category_name);//add category name into combo box

                        tempCategoryList.Add(new DatabaseColumn()
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

        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                Connector databaseConnectProduct = new MYSQLDatabaseConnection();
                DatabaseColumn dataSet = new DatabaseColumn();

                categoryId = databaseConnectProduct.SearchCategoryList(tempCategoryList, cmbCategoryName.SelectedItem.ToString());

                if (databaseConnectProduct.establish() == true)
                {
                    dataSet.company_id = companyId.company_id;
                    dataSet.category_id = categoryId.category_id;

                    databaseConnectProduct.SetData(dataSet);

                    List<DatabaseColumn> ProductList = databaseConnectProduct.GetProductNameForEachCompanyAndCategory();

                    foreach (DatabaseColumn databseColumn in ProductList)
                    {
                        cmbProductName.Items.Add(databseColumn.product_name);//add category name into combo box
                        tempProductList.Add(new DatabaseColumn()
                        {
                            product_name = databseColumn.product_name,
                            product_id = databseColumn.product_id,
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

        private void txtStockDate_Click(object sender, EventArgs e)
        {
            txtStockDate.Text = DateTime.Now.ToString();
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connector databaseConnectProductId = new MYSQLDatabaseConnection();
            productId = databaseConnectProductId.SearchProductList(tempProductList, cmbProductName.SelectedItem.ToString());
        }
    }
}
