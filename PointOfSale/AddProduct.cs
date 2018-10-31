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
        public AddProduct(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            MainWindow.TaskBar = "open Product Add window";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
