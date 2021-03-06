﻿using System;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            timerTaskBar.Start();
        }
        public static string TaskBar = "--------- Start ---------";
        private string currentTaskBar="";
        private bool isCollapsedStock = true, isCollapsedCompany = true, isCollapsedCategory = true, isCollapsedProduct = true, isCollapsedSetting = true, isCollapsedAccount = true;
        private void button7_Click(object sender, EventArgs e)
        {
            ChangeStock changeStock = new ChangeStock(this.dgv);
            changeStock.Show();
        }

        private void timerStock_Tick(object sender, EventArgs e)
        {
            if (isCollapsedStock)
            {
                panelStock.Height += 10;
                if (panelStock.Size==panelStock.MaximumSize)
                {
                    timerStock.Stop();
                    isCollapsedStock = false;

                }


            }
            else
            {
                panelStock.Height -= 10;
                if (panelStock.Size == panelStock.MinimumSize)
                {
                    timerStock.Stop();
                    isCollapsedStock = true;

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timerStock.Start();
        }

        private void timerCompany_Tick(object sender, EventArgs e)
        {
            if (isCollapsedCompany)
            {
                panelCompany.Height += 10;
                if (panelCompany.Size == panelCompany.MaximumSize)
                {
                    timerCompany.Stop();
                    isCollapsedCompany = false;

                }


            }
            else
            {
                panelCompany.Height -= 10;
                if (panelCompany.Size == panelCompany.MinimumSize)
                {
                    timerCompany.Stop();
                    isCollapsedCompany = true;

                }
            }
        }

        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            AddCompany addCompany = new AddCompany(this.dgv);
            addCompany.Show();
         
            
            
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            timerCategory.Start();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory(this.dgv);
            addCategory.Show();
        }

        private void timerTaskBar_Tick(object sender, EventArgs e)
        {
            if (currentTaskBar != TaskBar)
            {
                txtTaskBar.AppendText(TaskBar+"\n");
                TaskBar="";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            
            
        }

        private void btnCompanyRemove_Click(object sender, EventArgs e)
        {
            RemoveCompany removeCompany = new RemoveCompany(this.dgv);
            removeCompany.Show();
        }

        private void btnCompanyChange_Click(object sender, EventArgs e)
        {
            ChangeCompany changeCompany = new ChangeCompany(this.dgv);
            changeCompany.Show();
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            ChangeCategory changeCategory = new ChangeCategory(this.dgv);
            changeCategory.Show();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            RemoveCategory removeCategory = new RemoveCategory(this.dgv);
            removeCategory.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            timerProduct.Start();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this.dgv);
            addProduct.Show();
        }

        private void btnChangeProduct_Click(object sender, EventArgs e)
        {
            ChangeProduct changeProduct = new ChangeProduct(this.dgv);
            changeProduct.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveProduct RemoveProduct = new RemoveProduct(this.dgv);
            RemoveProduct.Show();
        }

        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock(this.dgv);
            addStock.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            timerSetting.Start();
        }

        private void timerSetting_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSetting)
            {
                panelSetting.Height += 10;
                if (panelSetting.Size == panelSetting.MaximumSize)
                {
                    timerSetting.Stop();
                    isCollapsedSetting = false;

                }


            }
            else
            {
                panelSetting.Height -= 10;
                if (panelSetting.Size == panelSetting.MinimumSize)
                {
                    timerSetting.Stop();
                    isCollapsedSetting = true;

                }
            }
        }

        private void btnServerSetting_Click(object sender, EventArgs e)
        {
            ServerConfiguration serverConfiguration = new ServerConfiguration();
            serverConfiguration.Show();
        }

        private void timerAccount_Tick(object sender, EventArgs e)
        {
            if (isCollapsedAccount)
            {
                panelAccount.Height += 10;
                if (panelAccount.Size == panelAccount.MaximumSize)
                {
                    timerAccount.Stop();
                    isCollapsedAccount = false;

                }


            }
            else
            {
                panelAccount.Height -= 10;
                if (panelAccount.Size == panelAccount.MinimumSize)
                {
                    timerAccount.Stop();
                    isCollapsedAccount = true;

                }
            }
        }

        private void btnAccountCreate_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount(this.dgv);
            addAccount.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            timerAccount.Start();
        }

        private void btnStockRemove_Click(object sender, EventArgs e)
        {
            RemoveStock removeStock = new RemoveStock(this.dgv);
            removeStock.Show();
        }

        private void timerProduct_Tick(object sender, EventArgs e)
        {
            if (isCollapsedProduct)
            {
                panelProduct.Height += 10;
                if (panelProduct.Size == panelProduct.MaximumSize)
                {
                    timerProduct.Stop();
                    isCollapsedProduct = false;

                }


            }
            else
            {
                panelProduct.Height -= 10;
                if (panelProduct.Size == panelProduct.MinimumSize)
                {
                    timerProduct.Stop();
                    isCollapsedProduct = true;

                }
            }
        }

        private void timerCategory_Tick(object sender, EventArgs e)
        {
            if (isCollapsedCategory)
            {
                panelCategory.Height += 10;
                if (panelCategory.Size == panelCategory.MaximumSize)
                {
                    timerCategory.Stop();
                    isCollapsedCategory = false;

                }


            }
            else
            {
                panelCategory.Height -= 10;
                if (panelCategory.Size == panelCategory.MinimumSize)
                {
                    timerCategory.Stop();
                    isCollapsedCategory = true;

                }
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            timerCompany.Start();
            
        }

      
        

    }
}
