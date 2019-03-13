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
    public partial class ChangeProduct : Form
    {
        List<DatabaseColumn> TempCompanyList=new List<DatabaseColumn>();
        List<DatabaseColumn> TempCategoryList = new List<DatabaseColumn>();
        List<DatabaseColumn> TempProductList = new List<DatabaseColumn>();
   

        private DataGridView mDgv;
       

        public ChangeProduct(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("ChangeProduct");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getProductDetails();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure update product details?", "Veryfy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Connector connector = new MYSQLDatabaseConnection();

                /*catch update details into databaseColumn*/
                DatabaseColumn updateDatabaseColumn = new DatabaseColumn();
                updateDatabaseColumn.company_id = connector.SearchCompanyList(TempCompanyList,cmbCompanyName.SelectedItem.ToString()).company_id;
                updateDatabaseColumn.category_id = connector.SearchCategoryList(TempCategoryList, cmbCategoryName.SelectedItem.ToString()).category_id;
                updateDatabaseColumn.product_id = txtProductId.Text.ToString();
                updateDatabaseColumn.product_name=txtProductName.Text;
                updateDatabaseColumn.sell_price=txtSellPrice.Text;
                updateDatabaseColumn.product_discount_price=txtDiscount.Text ;
                updateDatabaseColumn.minimum_quantity=txtMinimumQuantity.Text;

                List<DatabaseColumn> TempListForDGV = new List<DatabaseColumn>();
                TempListForDGV.Add(updateDatabaseColumn);


                connector.establish();
                connector.SetData(updateDatabaseColumn);

                if (connector.ChangeProductDetails() == true)
                {
                    CombineDataGridView combineDataGridView = new CombineDataGridView();
                    combineDataGridView.SetDataGridViewList(TempListForDGV, mDgv);
                    MessageBox.Show("Update compliete");
                    txtDiscount.Clear();
                    txtMinimumQuantity.Clear();
                    txtProductId.Clear();
                    txtProductName.Clear();
                    txtSellPrice.Clear();
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
        }

        private void ChangeProduct_Load(object sender, EventArgs e)
        {
           
            cmbSearchCategoryName.Enabled = false;
            cmbSearchProductName.Enabled = false;



        }

        private void cmbSearchCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            SetCategoryListIntoCategoryComboBox();
        }

        private void cmbSearchCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchCompanyName.Text != "")
            {
                cmbSearchCategoryName.Enabled = true;


            }
            else
            {
                cmbSearchCategoryName.Enabled = false;
                cmbSearchProductName.Enabled = false;

            }
        }

        private void cmbSearchCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchCompanyName.Text != "" && cmbSearchCategoryName.Text != "")
            {
                cmbSearchProductName.Enabled = true;


            }
            else
            {
              
                cmbSearchProductName.Enabled = false;

            }
        }

        private void cmbSearchProductName_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchCompanyName.Text != "" && cmbSearchCategoryName.Text != ""&& cmbSearchProductName.Text!="")
            {
                btnSearch.Enabled = true;


            }
            else
            {

                btnSearch.Enabled = false;

            }
        }
        private void SetCategoryListIntoCategoryComboBox()
        {
            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                
                Connector databaseConnectCategory = new MYSQLDatabaseConnection();
              
                if (databaseConnectCategory.establish() == true)
                {
                    DatabaseColumn databaseColumn = new DatabaseColumn();
                    databaseColumn.company_id = databaseConnectCategory.SearchCompanyList(TempCompanyList,cmbSearchCompanyName.SelectedItem.ToString()).company_id;
                    databaseConnectCategory.SetData(databaseColumn);
                    List<DatabaseColumn> CategoryList = databaseConnectCategory.GetCategoryNameForEachCompany();


                    cmbSearchCategoryName.Items.Clear();
                    cmbSearchCategoryName.Text = "";
                    foreach (DatabaseColumn databseColumn in CategoryList)
                    {
                        cmbSearchCategoryName.Items.Add(databseColumn.category_name);//add category name into combo box
                    }
             
                }
                else
                {
                    MessageBox.Show("connection error");
                }


            }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

        }
        private void SetProductListIntoProductComboBox()
        {
            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {

                Connector databaseConnectProduct = new MYSQLDatabaseConnection();

                if (databaseConnectProduct.establish() == true)
                {
                    DatabaseColumn databaseColumn = new DatabaseColumn();
                    databaseColumn.company_id = databaseConnectProduct.SearchCompanyList(TempCompanyList,cmbSearchCompanyName.SelectedItem.ToString()).company_id;
                    databaseColumn.category_id = databaseConnectProduct.SearchCategoryList(TempCategoryList,cmbSearchCategoryName.SelectedItem.ToString()).category_id;
                    databaseConnectProduct.SetData(databaseColumn);
                    List<DatabaseColumn> ProductList = databaseConnectProduct.GetProductNameForEachCompanyAndCategory();


                    cmbSearchProductName.Items.Clear();
                    cmbSearchProductName.Text = "";
                    TempProductList.Clear();
                    foreach (DatabaseColumn databseColumn in ProductList)
                    {
                        cmbSearchProductName.Items.Add(databseColumn.product_name);//add category name into combo box

                        TempProductList.Add(new DatabaseColumn()
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
        private void ChangeProduct_Shown(object sender, EventArgs e)
        {
            getCompanyList();
            getCategoryList();

        }

        private void cmbSearchProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
              
            
        }

        private void cmbSearchCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetProductListIntoProductComboBox();
        }
        private void getProductDetails()
        {

            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {

                Connector databaseConnectProductDetails = new MYSQLDatabaseConnection();

                if (databaseConnectProductDetails.establish() == true)
                {
                    DatabaseColumn databaseColumn = new DatabaseColumn();
                    databaseColumn.company_id = databaseConnectProductDetails.SearchCompanyList(TempCompanyList,cmbSearchCompanyName.SelectedItem.ToString()).company_id;
                    databaseColumn.category_id = databaseConnectProductDetails.SearchCategoryList(TempCategoryList,cmbSearchCategoryName.SelectedItem.ToString()).category_id;
                    databaseColumn.product_id = databaseConnectProductDetails.SearchProductList(TempProductList,cmbSearchProductName.SelectedItem.ToString()).product_id;

                    databaseConnectProductDetails.SetData(databaseColumn);
                    DatabaseColumn ProductDetails = databaseConnectProductDetails.GetProductDetails();


                    txtProductId.Text = ProductDetails.product_id;

                                   

                    txtProductName.Text = ProductDetails.product_name;
                    txtSellPrice.Text = ProductDetails.sell_price;
                    txtDiscount.Text = ProductDetails.product_discount_price;
                    txtMinimumQuantity.Text = ProductDetails.minimum_quantity;
                    cmbCategoryName.Text = ProductDetails.category_name;
                    cmbCompanyName.Text = ProductDetails.company_name;


                    

                }
                else
                {
                    MessageBox.Show("connection error");
                }


            }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());


        }
        private void getCompanyList()
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
                        cmbSearchCompanyName.Items.Add(databseColumn.company_name);//add company name into combo box
                        cmbCompanyName.Items.Add(databseColumn.company_name);

                        TempCompanyList.Add(new DatabaseColumn()
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

        private void getCategoryList()
        {
            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                Connector databaseConnectCategory = new MYSQLDatabaseConnection();

                if (databaseConnectCategory.establish() == true)
                {

                    List<DatabaseColumn> CategoryList = databaseConnectCategory.GetAllCategoryNameWithId();


                    foreach (DatabaseColumn databseColumn in CategoryList)
                    {
                        cmbCategoryName.Items.Add(databseColumn.category_name);//add company name into combo box
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

       
    }
}
