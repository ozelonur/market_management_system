namespace market_management_system
{
    partial class product_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product_transactions));
            this.addProductBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchCmb = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductBtn
            // 
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addProductBtn.ImageKey = "add.png";
            this.addProductBtn.ImageList = this.imageList1;
            this.addProductBtn.Location = new System.Drawing.Point(426, 357);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(86, 81);
            this.addProductBtn.TabIndex = 13;
            this.addProductBtn.Text = "Add";
            this.addProductBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "exit.png");
            this.imageList1.Images.SetKeyName(3, "search.png");
            this.imageList1.Images.SetKeyName(4, "edit.png");
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteProductBtn.ImageKey = "delete.png";
            this.deleteProductBtn.ImageList = this.imageList1;
            this.deleteProductBtn.Location = new System.Drawing.Point(610, 357);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(86, 81);
            this.deleteProductBtn.TabIndex = 12;
            this.deleteProductBtn.Text = "Delete";
            this.deleteProductBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.ImageKey = "exit.png";
            this.closeBtn.ImageList = this.imageList1;
            this.closeBtn.Location = new System.Drawing.Point(702, 357);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(86, 81);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 100);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(776, 251);
            this.dgvProduct.TabIndex = 10;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.ImageKey = "search.png";
            this.searchBtn.ImageList = this.imageList1;
            this.searchBtn.Location = new System.Drawing.Point(512, 13);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(120, 62);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchCmb
            // 
            this.searchCmb.FormattingEnabled = true;
            this.searchCmb.Items.AddRange(new object[] {
            "Choose",
            "Product Name",
            "Product Code",
            "Company Name",
            "Purchase Price",
            "Sale Price",
            "Category Name"});
            this.searchCmb.Location = new System.Drawing.Point(316, 35);
            this.searchCmb.Name = "searchCmb";
            this.searchCmb.Size = new System.Drawing.Size(170, 21);
            this.searchCmb.TabIndex = 8;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(140, 36);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(170, 20);
            this.searchTxt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "edit.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(518, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 81);
            this.button1.TabIndex = 14;
            this.button1.Text = "Edit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // product_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchCmb);
            this.Controls.Add(this.searchTxt);
            this.Name = "product_transactions";
            this.Text = "Product Transactions";
            this.Load += new System.EventHandler(this.product_transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox searchCmb;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}