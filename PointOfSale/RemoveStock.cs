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
    public partial class RemoveStock : Form
    {
        private DataGridView dgv;
        private string barcode = "";

        private List<DatabaseColumn> tempCompanyList = new List<DatabaseColumn>();

        public RemoveStock(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure delete stock?", "Veryfy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                Connector connection = new MYSQLDatabaseConnection();
                DatabaseColumn dataset = new DatabaseColumn();
                dataset.barcode = barcode;
                connection.SetData(dataset);
                connection.establish();
                if (connection.RemoveStockDetails())
                {
                    MessageBox.Show("Deleted");
                }
                txtExpDate.Clear();
                txtGetPrice.Clear();
                txtInvoiceNumber.Clear();
                txtQuantity.Clear();
                txtStockDate.Clear();
                cmbCategoryName.Text = "";
                cmbCompanyName.Text = "";
                cmbProductName.Text = "";
                txtBarcode.Focus();
            }

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                cmbCompanyName.Text = data.company_name;
                cmbCategoryName.Text = data.category_name;
                cmbProductName.Text = data.product_name;

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
    }
}
