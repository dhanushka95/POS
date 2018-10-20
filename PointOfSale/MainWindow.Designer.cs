namespace PointOfSale
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panelStock = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelCompany = new System.Windows.Forms.Panel();
            this.btnCompanySearch = new System.Windows.Forms.Button();
            this.btnCompanyChange = new System.Windows.Forms.Button();
            this.btnCompanyRemove = new System.Windows.Forms.Button();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.timerStock = new System.Windows.Forms.Timer(this.components);
            this.timerCompany = new System.Windows.Forms.Timer(this.components);
            this.timerProduct = new System.Windows.Forms.Timer(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panelBottam = new System.Windows.Forms.Panel();
            this.txtTaskBar = new System.Windows.Forms.TextBox();
            this.timerTaskBar = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panelCompany.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelBottam.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.btnSetting);
            this.flowLayoutPanel1.Controls.Add(this.panelStock);
            this.flowLayoutPanel1.Controls.Add(this.panelCompany);
            this.flowLayoutPanel1.Controls.Add(this.panelProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 673);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(3, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(302, 61);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(3, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(302, 61);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Backup";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(3, 204);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(302, 61);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.button7);
            this.panelStock.Controls.Add(this.button6);
            this.panelStock.Controls.Add(this.button5);
            this.panelStock.Location = new System.Drawing.Point(3, 271);
            this.panelStock.MaximumSize = new System.Drawing.Size(302, 139);
            this.panelStock.MinimumSize = new System.Drawing.Size(302, 62);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(302, 62);
            this.panelStock.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 101);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(302, 40);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(302, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(302, 61);
            this.button5.TabIndex = 5;
            this.button5.Text = "Stock";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelCompany
            // 
            this.panelCompany.Controls.Add(this.btnCompanySearch);
            this.panelCompany.Controls.Add(this.btnCompanyChange);
            this.panelCompany.Controls.Add(this.btnCompanyRemove);
            this.panelCompany.Controls.Add(this.btnCompanyAdd);
            this.panelCompany.Controls.Add(this.btnCompany);
            this.panelCompany.Location = new System.Drawing.Point(3, 339);
            this.panelCompany.MaximumSize = new System.Drawing.Size(302, 216);
            this.panelCompany.MinimumSize = new System.Drawing.Size(302, 62);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(302, 62);
            this.panelCompany.TabIndex = 3;
            // 
            // btnCompanySearch
            // 
            this.btnCompanySearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCompanySearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompanySearch.FlatAppearance.BorderSize = 0;
            this.btnCompanySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanySearch.ForeColor = System.Drawing.Color.White;
            this.btnCompanySearch.Location = new System.Drawing.Point(0, 181);
            this.btnCompanySearch.Name = "btnCompanySearch";
            this.btnCompanySearch.Size = new System.Drawing.Size(302, 40);
            this.btnCompanySearch.TabIndex = 6;
            this.btnCompanySearch.Text = "Search";
            this.btnCompanySearch.UseVisualStyleBackColor = false;
            // 
            // btnCompanyChange
            // 
            this.btnCompanyChange.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCompanyChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompanyChange.FlatAppearance.BorderSize = 0;
            this.btnCompanyChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyChange.ForeColor = System.Drawing.Color.White;
            this.btnCompanyChange.Location = new System.Drawing.Point(0, 141);
            this.btnCompanyChange.Name = "btnCompanyChange";
            this.btnCompanyChange.Size = new System.Drawing.Size(302, 40);
            this.btnCompanyChange.TabIndex = 5;
            this.btnCompanyChange.Text = "Change";
            this.btnCompanyChange.UseVisualStyleBackColor = false;
            this.btnCompanyChange.Click += new System.EventHandler(this.btnCompanyChange_Click);
            // 
            // btnCompanyRemove
            // 
            this.btnCompanyRemove.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCompanyRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompanyRemove.FlatAppearance.BorderSize = 0;
            this.btnCompanyRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyRemove.ForeColor = System.Drawing.Color.White;
            this.btnCompanyRemove.Location = new System.Drawing.Point(0, 101);
            this.btnCompanyRemove.Name = "btnCompanyRemove";
            this.btnCompanyRemove.Size = new System.Drawing.Size(302, 40);
            this.btnCompanyRemove.TabIndex = 4;
            this.btnCompanyRemove.Text = "Remove";
            this.btnCompanyRemove.UseVisualStyleBackColor = false;
            this.btnCompanyRemove.Click += new System.EventHandler(this.btnCompanyRemove_Click);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCompanyAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompanyAdd.FlatAppearance.BorderSize = 0;
            this.btnCompanyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyAdd.ForeColor = System.Drawing.Color.White;
            this.btnCompanyAdd.Location = new System.Drawing.Point(0, 61);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(302, 40);
            this.btnCompanyAdd.TabIndex = 3;
            this.btnCompanyAdd.Text = "Add";
            this.btnCompanyAdd.UseVisualStyleBackColor = false;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompany.FlatAppearance.BorderSize = 0;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.ForeColor = System.Drawing.Color.White;
            this.btnCompany.Location = new System.Drawing.Point(0, 0);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(302, 61);
            this.btnCompany.TabIndex = 2;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.btnProductSearch);
            this.panelProduct.Controls.Add(this.btnRemoveCategory);
            this.panelProduct.Controls.Add(this.btnChangeCategory);
            this.panelProduct.Controls.Add(this.btnAddCategory);
            this.panelProduct.Controls.Add(this.btnProduct);
            this.panelProduct.Location = new System.Drawing.Point(3, 407);
            this.panelProduct.MaximumSize = new System.Drawing.Size(302, 219);
            this.panelProduct.MinimumSize = new System.Drawing.Size(302, 62);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(302, 62);
            this.panelProduct.TabIndex = 6;
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductSearch.FlatAppearance.BorderSize = 0;
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSearch.ForeColor = System.Drawing.Color.White;
            this.btnProductSearch.Location = new System.Drawing.Point(0, 181);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(302, 40);
            this.btnProductSearch.TabIndex = 9;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveCategory.FlatAppearance.BorderSize = 0;
            this.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCategory.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCategory.Location = new System.Drawing.Point(0, 141);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(302, 40);
            this.btnRemoveCategory.TabIndex = 8;
            this.btnRemoveCategory.Text = "Remove";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangeCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeCategory.FlatAppearance.BorderSize = 0;
            this.btnChangeCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCategory.ForeColor = System.Drawing.Color.White;
            this.btnChangeCategory.Location = new System.Drawing.Point(0, 101);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(302, 40);
            this.btnChangeCategory.TabIndex = 7;
            this.btnChangeCategory.Text = "Change Ctegory";
            this.btnChangeCategory.UseVisualStyleBackColor = false;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(0, 61);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(302, 40);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(302, 61);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // timerStock
            // 
            this.timerStock.Interval = 15;
            this.timerStock.Tick += new System.EventHandler(this.timerStock_Tick);
            // 
            // timerCompany
            // 
            this.timerCompany.Interval = 15;
            this.timerCompany.Tick += new System.EventHandler(this.timerCompany_Tick);
            // 
            // timerProduct
            // 
            this.timerProduct.Interval = 15;
            this.timerProduct.Tick += new System.EventHandler(this.timerProduct_Tick);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeight = 65;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(325, 0);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(993, 673);
            this.dgv.TabIndex = 1;
            // 
            // panelBottam
            // 
            this.panelBottam.BackColor = System.Drawing.Color.AliceBlue;
            this.panelBottam.Controls.Add(this.txtTaskBar);
            this.panelBottam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottam.Location = new System.Drawing.Point(325, 621);
            this.panelBottam.Name = "panelBottam";
            this.panelBottam.Size = new System.Drawing.Size(993, 52);
            this.panelBottam.TabIndex = 2;
            // 
            // txtTaskBar
            // 
            this.txtTaskBar.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTaskBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaskBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskBar.ForeColor = System.Drawing.Color.Black;
            this.txtTaskBar.Location = new System.Drawing.Point(0, 0);
            this.txtTaskBar.Multiline = true;
            this.txtTaskBar.Name = "txtTaskBar";
            this.txtTaskBar.ReadOnly = true;
            this.txtTaskBar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTaskBar.Size = new System.Drawing.Size(993, 52);
            this.txtTaskBar.TabIndex = 0;
            // 
            // timerTaskBar
            // 
            this.timerTaskBar.Tick += new System.EventHandler(this.timerTaskBar_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 673);
            this.Controls.Add(this.panelBottam);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelStock.ResumeLayout(false);
            this.panelCompany.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelBottam.ResumeLayout(false);
            this.panelBottam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timerStock;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelCompany;
        private System.Windows.Forms.Button btnCompanySearch;
        private System.Windows.Forms.Button btnCompanyChange;
        private System.Windows.Forms.Button btnCompanyRemove;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.Timer timerCompany;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Timer timerProduct;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panelBottam;
        private System.Windows.Forms.TextBox txtTaskBar;
        private System.Windows.Forms.Timer timerTaskBar;
    }
}