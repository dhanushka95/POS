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
    public partial class StartingForm : Form
    {
        Timer t = new Timer();
        public StartingForm()
        {
            InitializeComponent();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            //Set Time to Start Login Form
            t.Interval = 1000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            t.Stop();
        }
    }
}
