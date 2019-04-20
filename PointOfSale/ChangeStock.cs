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
    public partial class ChangeStock : Form
    {
        private DataGridView dgv;

        private List<DatabaseColumn> tempCompanyList = new List<DatabaseColumn>();
        private List<DatabaseColumn> tempCategoryList = new List<DatabaseColumn>();
        private List<DatabaseColumn> tempProductList = new List<DatabaseColumn>();

        private DatabaseColumn companyId = new DatabaseColumn();
        private DatabaseColumn categoryId = new DatabaseColumn();
        private DatabaseColumn productId = new DatabaseColumn();

        private string barcode = "";
        

        public ChangeStock(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cmbCompanyName.SelectedItem!= null && cmbCategoryName.SelectedItem != null && cmbProductName.SelectedItem != null) {
                Connector connection = new MYSQLDatabaseConnection();

                DatabaseColumn dataset = new DatabaseColumn();
                dataset.product_id = connection.SearchProductList(tempProductList, cmbProductName.SelectedIndex.ToString()).product_id;
                dataset.stock_date = txtStockDate.Text.ToString();
                dataset.invoice_number = txtInvoiceNumber.Text.ToString();
                dataset.start_quantity = txtQuantity.Text.ToString();
                dataset.exp_date = txtExpDate.Text.ToString();
                dataset.get_price = txtGetPrice.Text.ToString();
                dataset.barcode = barcode;
                connection.SetData(dataset);

                connection.establish();
                if (connection.ChangeStockDetails())
                {
                    List<DatabaseColumn> dgvList = new List<DatabaseColumn>();
                    dgvList.Add(dataset);
                    CombineDataGridView combindDataGrid = new CombineDataGridView();
                    combindDataGrid.SetDataGridViewList(dgvList,dgv);
                    MessageBox.Show("changed");
                }
                else {
                    MessageBox.Show("can't changed");
                }
            }
            else
            {
                MessageBox.Show("fill all requred data");
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                Connector conection = new MYSQLDatabaseConnection();
                DatabaseColumn dataset = new DatabaseColumn();
                dataset.barcode = txtBarcode.Text.ToString();
                barcode = txtBarcode.Text.ToString();
                conection.SetData(dataset);
                conection.establish();
                DatabaseColumn data = conection.GetStockUsingBarcode();
                txtBarcode.Clear();

                txtExpDate.Text = data.exp_date;
                txtGetPrice.Text = data.get_price;
                txtInvoiceNumber.Text = data.invoice_number;
                txtQuantity.Text = data.start_quantity;
                txtStockDate.Text = data.stock_date;


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
        }

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryName.Text = "";
            cmbCategoryName.Items.Clear();

            cmbProductName.Text = "";
            cmbProductName.Items.Clear();

            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                Connector databaseConnectCategory = new MYSQLDatabaseConnection();

                companyId = databaseConnectCategory.SearchCompanyList(tempCompanyList, cmbCompanyName.SelectedItem.ToString());

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

            cmbProductName.Text = "";
            cmbProductName.Items.Clear();

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

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connector databaseConnectProductId = new MYSQLDatabaseConnection();
            productId = databaseConnectProductId.SearchProductList(tempProductList, cmbProductName.SelectedItem.ToString());

        }
    }
}
