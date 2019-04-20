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
    public partial class ScanBarcode : Form
    {
     
        private string productName,categoryName,companyName,productId,stockDate,invoiceNumber,startQuantity,currentQuantity,expDate,getPrice,barcodeValue;
        private DatabaseColumn databaseColumn = new DatabaseColumn();
        private DataGridView mDGV;
        private List<DatabaseColumn> columnList = new List<DatabaseColumn>();
        private void txtBarcodeValue_TextChanged(object sender, EventArgs e)
        {
            databaseColumn.barcode = txtBarcodeValue.Text.ToString();
        }

        private Connector insertStock;

        private void txtBarcodeValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                if (insertStock.InsertStock())
                {

                    CombineDataGridView datagrid = new CombineDataGridView();
                    datagrid.SetDataGridViewList(columnList,mDGV);
                    this.Close();

                }

            }
        }

        public ScanBarcode(string[] details,DataGridView d)
        {
            InitializeComponent();
            this.productName = details[0];
            this.categoryName = details[1];
            this.companyName = details[2];
            this.productId = details[3];
            this.stockDate = details[4];
            this.invoiceNumber = details[5];
            this.startQuantity = details[6];
            this.currentQuantity = details[6];
            this.expDate = details[7];
            this.getPrice = details[8];

            this.mDGV = d;

        }

        private void ScanBarcode_Load(object sender, EventArgs e)
        {
            txtBarcodeValue.Focus();
            insertStock = new MYSQLDatabaseConnection();
          
            databaseColumn.product_name = productName;
            databaseColumn.category_name = categoryName;
            databaseColumn.company_name = companyName;
            databaseColumn.product_id = productId;
            databaseColumn.stock_date = stockDate;
            databaseColumn.invoice_number = invoiceNumber;
            databaseColumn.start_quantity = startQuantity;
            databaseColumn.issue_quantity ="0";
            databaseColumn.exp_date = expDate;
            databaseColumn.get_price = getPrice;
            databaseColumn.E_D = "T";
         
                
            if (insertStock.establish())
            {
                insertStock.SetData(databaseColumn);
                columnList.Add(databaseColumn);
            }
            else {
                this.Close();
            }
        }
    }
}
