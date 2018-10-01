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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool isCollapsedStock=true, isCollapsedCompany= true, isCollapsedProduct = true;
        private void button7_Click(object sender, EventArgs e)
        {

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
            AddCompany addCompany = new AddCompany();
            addCompany.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            timerProduct.Start();
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

        private void btnCompany_Click(object sender, EventArgs e)
        {
            timerCompany.Start();
        }
    }
}
