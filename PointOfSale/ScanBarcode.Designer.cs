namespace PointOfSale
{
    partial class ScanBarcode
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
            this.txtBarcodeValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBarcodeValue
            // 
            this.txtBarcodeValue.Location = new System.Drawing.Point(0, 0);
            this.txtBarcodeValue.Name = "txtBarcodeValue";
            this.txtBarcodeValue.Size = new System.Drawing.Size(302, 22);
            this.txtBarcodeValue.TabIndex = 0;
            this.txtBarcodeValue.TextChanged += new System.EventHandler(this.txtBarcodeValue_TextChanged);
            this.txtBarcodeValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeValue_KeyDown);
            // 
            // ScanBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(302, 22);
            this.Controls.Add(this.txtBarcodeValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScanBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan Barcode";
            this.Load += new System.EventHandler(this.ScanBarcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcodeValue;
    }
}