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
    public partial class ChangeCategory : Form
    {
        private DataGridView mDgv;
        
        public ChangeCategory(DataGridView dgv)
        {
            InitializeComponent();
            this.mDgv = dgv;
            CommandLine commandLine = new CommandLine("ChangeCategory");
        }


        private void ChangeCategory_Load(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            redioBtnCategoryName.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DatabaseColumn databaseColumn = new DatabaseColumn();
            List<DatabaseColumn> list = new List<DatabaseColumn>();
            CombineDataGridView combineDataGridView = new CombineDataGridView();
            if (txtSearch.Text != "")
            {
                

               

                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();

                if (redioBtnCategoryName.Checked == true)
                {
                    databaseColumn.category_name = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCategoryWithName();
                    combineDataGridView.SetDataGridViewList(list, mDgv);//connect main window datagridview
                  

                }
                else if (redioBtnCategoryId.Checked == true)
                {
                    databaseColumn.category_id = txtSearch.Text.ToString();
                    connector.SetData(databaseColumn);
                    list = connector.SearchCategoryWithId();
                    combineDataGridView.SetDataGridViewList(list, mDgv);
                   
                }
                if (list.Count > 0)
                {
                    txtCategoryId.Text = list[0].category_id;
                    txtCategoryName.Text = list[0].category_name;
                }
                else
                {
                    txtCategoryName.Clear();
                    txtCategoryId.Clear();
                }

            }
            else
            {
                combineDataGridView.SetDataGridViewList(list, mDgv);
                txtCategoryName.Clear();
                txtCategoryId.Clear();
            }

            
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryId.Text.ToString() != "" && txtCategoryName.Text.ToString() != "")
            {
                btnChange.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure update category details?", "Veryfy", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                /*catch update details into databaseColumn*/
                DatabaseColumn updateDatabaseColumn = new DatabaseColumn();
                updateDatabaseColumn.category_id = txtCategoryId.Text.ToString();
                updateDatabaseColumn.category_name = txtCategoryName.Text.ToString();
              

                Connector connector = new MYSQLDatabaseConnection();
                connector.establish();
                connector.SetData(updateDatabaseColumn);

                if (connector.ChangeCategory() == true)
                {
                    MessageBox.Show("Update compliete");

                    /*refresh main data grid view and show update company deteils*/
                    redioBtnCategoryId.Checked = true;
                    txtSearch.Text = txtCategoryId.Text;
                    btnSearch.PerformClick();

                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryId.Text!="" && txtCategoryName.Text!="")
            {
                btnChange.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
            }
        }
    }
}
