namespace PBL3___Cosmetics_Store_Management_App
{
    partial class usProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lbPrice);
            this.guna2ShadowPanel1.Controls.Add(this.lbStock);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.picProduct);
            this.guna2ShadowPanel1.Controls.Add(this.lbName);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(162, 218);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.lbPrice.Location = new System.Drawing.Point(6, 165);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(153, 23);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "150,000";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.ForeColor = System.Drawing.Color.Gray;
            this.lbStock.Location = new System.Drawing.Point(54, 191);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(44, 16);
            this.lbStock.TabIndex = 4;
            this.lbStock.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(10, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stock:";
            // 
            // picProduct
            // 
            this.picProduct.ImageRotate = 0F;
            this.picProduct.Location = new System.Drawing.Point(35, 14);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(88, 102);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 2;
            this.picProduct.TabStop = false;
            this.picProduct.UseTransparentBackground = true;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(11, 119);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(141, 49);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "SRM Innisfree";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 113);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(149, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // usProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "usProduct";
            this.Size = new System.Drawing.Size(162, 218);
            this.Load += new System.EventHandler(this.usProduct_Load);
            this.Click += new System.EventHandler(this.RaiseProductClick);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox picProduct;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice;
    }
}
