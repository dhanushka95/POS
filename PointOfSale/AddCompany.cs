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
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // Add company details into database
            Connector connector= new MYSQLDatabaseConnection();
            connector.establish();
            connector.companyId=txtCompanyId.Text.ToString();
            connector.companyName=txtCompayName.Text.ToString();
            connector.companyPhoneNumber=txtCompanyPhoneNumber.Text.ToString();

            if (connector.InsertCompanyDetails()==true)
            {
                MessageBox.Show("add Compleat");
                txtCompanyId.Clear();
                txtCompanyPhoneNumber.Clear();
                txtCompayName.Clear();
            }
            else
            {
                MessageBox.Show("data insert error");
            }
        }
    }
}
