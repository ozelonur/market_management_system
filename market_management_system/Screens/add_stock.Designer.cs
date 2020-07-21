namespace market_management_system
{
    partial class add_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_stock));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Prodcut Name (required)";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(196, 44);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(160, 20);
            this.txtUnitPrice.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Unit Price";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(196, 78);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(160, 20);
            this.txtTax.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tax";
            // 
            // txtPiece
            // 
            this.txtPiece.Location = new System.Drawing.Point(196, 116);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(160, 20);
            this.txtPiece.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Piece";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(196, 8);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(159, 21);
            this.cmbProduct.TabIndex = 48;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveBtn.ImageKey = "save.png";
            this.saveBtn.ImageList = this.imageList1;
            this.saveBtn.Location = new System.Drawing.Point(12, 145);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 150);
            this.saveBtn.TabIndex = 49;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exit.png");
            this.imageList1.Images.SetKeyName(1, "save.png");
            this.imageList1.Images.SetKeyName(2, "update.png");
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.ImageKey = "exit.png";
            this.closeBtn.ImageList = this.imageList1;
            this.closeBtn.Location = new System.Drawing.Point(205, 145);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(150, 150);
            this.closeBtn.TabIndex = 50;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // add_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 311);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_stock";
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.add_stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button closeBtn;
        public System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.TextBox txtUnitPrice;
        public System.Windows.Forms.TextBox txtTax;
        public System.Windows.Forms.TextBox txtPiece;
        public System.Windows.Forms.ComboBox cmbProduct;
    }
}