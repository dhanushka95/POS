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

        public RemoveStock(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
