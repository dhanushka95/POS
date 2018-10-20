using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PointOfSale
{
    class CombineDataGridView
    {
      
        public DataGridView SetDataGridViewList(List<DatabaseColumn> list, DataGridView dgv)
        {

            dgv.DataSource = new BindingList<DatabaseColumn>(list);
            var t = new Task(() => { });
            t.Start();
            t.ContinueWith(task => {
                bool column_barcode = false, column_bill_no = false, column_user_id = false, column_category_id = false, column_category_name = false, column_company_address = false, column_company_id = false, column_company_name = false, column_company_phone_no = false, column_counter_id = false, column_counter_name = false, column_current_quantity = false, column_date = false, column_discount_price = false, column_expences = false, column_exp_date = false, column_get_price = false, column_income = false, column_invoice_number = false, column_location = false, column_minimum_quantity = false, column_user_name = false, column_product_discount_price = false, column_product_id = false, column_product_name = false, column_sell_price = false, column_start_quantity = false, column_stock_date = false, column_type = false, column_quantity = false;
                foreach (DatabaseColumn column in (BindingList<DatabaseColumn>)dgv.DataSource)
                {

                    if (!string.IsNullOrEmpty(column.barcode))
                        column_barcode = true;
                    if (!string.IsNullOrEmpty(column.bill_no))
                        column_bill_no = true;
                    if (!string.IsNullOrEmpty(column.category_id))
                        column_category_id = true;
                    if (!string.IsNullOrEmpty(column.category_name))
                        column_category_name = true;
                    if (!string.IsNullOrEmpty(column.company_address))
                        column_company_address = true;
                    if (!string.IsNullOrEmpty(column.company_id))
                        column_company_id = true;
                    if (!string.IsNullOrEmpty(column.company_name))
                        column_company_name = true;
                    if (!string.IsNullOrEmpty(column.company_phone_no))
                        column_company_phone_no = true;
                    if (!string.IsNullOrEmpty(column.counter_id))
                        column_counter_id = true;
                    if (!string.IsNullOrEmpty(column.counter_name))
                        column_counter_name = true;
                    if (!string.IsNullOrEmpty(column.current_quantity))
                        column_current_quantity = true;
                    if (!string.IsNullOrEmpty(column.date))
                        column_date = true;
                    if (!string.IsNullOrEmpty(column.discount_price))
                        column_discount_price = true;
                    if (!string.IsNullOrEmpty(column.expences))
                        column_expences = true;
                    if (!string.IsNullOrEmpty(column.exp_date))
                        column_exp_date = true;
                    if (!string.IsNullOrEmpty(column.get_price))
                        column_get_price = true;
                    if (!string.IsNullOrEmpty(column.income))
                        column_income = true;
                    if (!string.IsNullOrEmpty(column.invoice_number))
                        column_invoice_number = true;
                    if (!string.IsNullOrEmpty(column.location))
                        column_location = true;
                    if (!string.IsNullOrEmpty(column.barcode))
                        column_barcode = true;
                    if (!string.IsNullOrEmpty(column.minimum_quantity))
                        column_minimum_quantity = true;
                    if (!string.IsNullOrEmpty(column.type))
                        column_type = true;
                    if (!string.IsNullOrEmpty(column.product_discount_price))
                        column_product_discount_price = true;
                    if (!string.IsNullOrEmpty(column.product_id))
                        column_product_id = true;
                    if (!string.IsNullOrEmpty(column.product_name))
                        column_product_name = true;
                    if (!string.IsNullOrEmpty(column.quantity))
                        column_quantity = true;
                    if (!string.IsNullOrEmpty(column.sell_price))
                        column_sell_price = true;
                    if (!string.IsNullOrEmpty(column.start_quantity))
                        column_start_quantity = true;
                    if (!string.IsNullOrEmpty(column.stock_date))
                        column_stock_date = true;
                    if (!string.IsNullOrEmpty(column.user_id))
                        column_user_id = true;
                    if (!string.IsNullOrEmpty(column.user_name))
                        column_user_name = true;

                }
                dgv.Columns[0].Visible = column_barcode;
                dgv.Columns[1].Visible = column_counter_id;
                dgv.Columns[2].Visible = column_bill_no;
                dgv.Columns[3].Visible = column_date;
                dgv.Columns[4].Visible = column_discount_price;
                dgv.Columns[5].Visible = column_expences;
                dgv.Columns[6].Visible = column_income;
                dgv.Columns[7].Visible = column_category_name;
                dgv.Columns[8].Visible = column_category_id;
                dgv.Columns[9].Visible = column_company_name;
                dgv.Columns[10].Visible = column_company_address;
                dgv.Columns[11].Visible = column_company_phone_no;
                dgv.Columns[12].Visible = column_company_id;
                dgv.Columns[13].Visible = column_counter_name;
                dgv.Columns[14].Visible = column_location;
                dgv.Columns[15].Visible = column_user_id;
                dgv.Columns[16].Visible = column_quantity;
                dgv.Columns[17].Visible = column_product_id;
                dgv.Columns[18].Visible = column_get_price;
                dgv.Columns[19].Visible = column_exp_date;
                dgv.Columns[20].Visible = column_product_name;
                dgv.Columns[21].Visible = column_minimum_quantity;
                dgv.Columns[22].Visible = column_sell_price;
                dgv.Columns[23].Visible = column_product_discount_price;
                dgv.Columns[24].Visible = column_stock_date;
                dgv.Columns[25].Visible = column_invoice_number;
                dgv.Columns[26].Visible = column_start_quantity;
                dgv.Columns[27].Visible = column_current_quantity;
                dgv.Columns[28].Visible = column_user_name;
                dgv.Columns[29].Visible = false; //this is password column;
                dgv.Columns[30].Visible = column_type;

                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
                    }
                    else
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }
                }
              
            }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            return dgv;
        }

        
    }
}
