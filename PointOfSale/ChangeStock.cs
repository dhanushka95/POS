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

        public ChangeStock(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }
    }
}
