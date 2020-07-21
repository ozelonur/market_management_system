namespace market_management_system
{
    partial class add_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_product));
            this.closeBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sPriceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pCodeTxt = new System.Windows.Forms.TextBox();
            this.pCodeLabel = new System.Windows.Forms.Label();
            this.pNameTxt = new System.Windows.Forms.TextBox();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.cNameCbx = new System.Windows.Forms.ComboBox();
            this.categoryCbx = new System.Windows.Forms.ComboBox();
            this.addCompanyBtn = new System.Windows.Forms.PictureBox();
            this.addCategoryBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addCompanyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.ImageKey = "exit.png";
            this.closeBtn.ImageList = this.imageList1;
            this.closeBtn.Location = new System.Drawing.Point(223, 216);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(191, 150);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "exit.png");
            this.imageList1.Images.SetKeyName(2, "update.png");
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveBtn.ImageKey = "save.png";
            this.saveBtn.ImageList = this.imageList1;
            this.saveBtn.Location = new System.Drawing.Point(16, 216);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(190, 150);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Category";
            // 
            // sPriceTxt
            // 
            this.sPriceTxt.Location = new System.Drawing.Point(223, 144);
            this.sPriceTxt.Name = "sPriceTxt";
            this.sPriceTxt.Size = new System.Drawing.Size(160, 20);
            this.sPriceTxt.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sale Price";
            // 
            // pPriceTxt
            // 
            this.pPriceTxt.Location = new System.Drawing.Point(223, 111);
            this.pPriceTxt.Name = "pPriceTxt";
            this.pPriceTxt.Size = new System.Drawing.Size(160, 20);
            this.pPriceTxt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Purchase Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Company Name";
            // 
            // pCodeTxt
            // 
            this.pCodeTxt.Location = new System.Drawing.Point(223, 45);
            this.pCodeTxt.Name = "pCodeTxt";
            this.pCodeTxt.Size = new System.Drawing.Size(160, 20);
            this.pCodeTxt.TabIndex = 17;
            // 
            // pCodeLabel
            // 
            this.pCodeLabel.AutoSize = true;
            this.pCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeLabel.Location = new System.Drawing.Point(12, 43);
            this.pCodeLabel.Name = "pCodeLabel";
            this.pCodeLabel.Size = new System.Drawing.Size(201, 20);
            this.pCodeLabel.TabIndex = 16;
            this.pCodeLabel.Text = "Product Code (required)";
            // 
            // pNameTxt
            // 
            this.pNameTxt.Location = new System.Drawing.Point(223, 12);
            this.pNameTxt.Name = "pNameTxt";
            this.pNameTxt.Size = new System.Drawing.Size(160, 20);
            this.pNameTxt.TabIndex = 15;
            // 
            // pNameLabel
            // 
            this.pNameLabel.AutoSize = true;
            this.pNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.Location = new System.Drawing.Point(12, 10);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(205, 20);
            this.pNameLabel.TabIndex = 14;
            this.pNameLabel.Text = "Product Name (required)";
            // 
            // cNameCbx
            // 
            this.cNameCbx.FormattingEnabled = true;
            this.cNameCbx.Items.AddRange(new object[] {
            "Choose"});
            this.cNameCbx.Location = new System.Drawing.Point(223, 78);
            this.cNameCbx.Name = "cNameCbx";
            this.cNameCbx.Size = new System.Drawing.Size(160, 21);
            this.cNameCbx.TabIndex = 28;
            // 
            // categoryCbx
            // 
            this.categoryCbx.FormattingEnabled = true;
            this.categoryCbx.Location = new System.Drawing.Point(223, 179);
            this.categoryCbx.Name = "categoryCbx";
            this.categoryCbx.Size = new System.Drawing.Size(160, 21);
            this.categoryCbx.TabIndex = 29;
            // 
            // addCompanyBtn
            // 
            this.addCompanyBtn.Image = global::market_management_system.Properties.Resources.add;
            this.addCompanyBtn.Location = new System.Drawing.Point(389, 78);
            this.addCompanyBtn.Name = "addCompanyBtn";
            this.addCompanyBtn.Size = new System.Drawing.Size(24, 23);
            this.addCompanyBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addCompanyBtn.TabIndex = 30;
            this.addCompanyBtn.TabStop = false;
            this.addCompanyBtn.Click += new System.EventHandler(this.addCompanyBtn_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Image = global::market_management_system.Properties.Resources.add;
            this.addCategoryBtn.Location = new System.Drawing.Point(389, 179);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(24, 23);
            this.addCategoryBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addCategoryBtn.TabIndex = 31;
            this.addCategoryBtn.TabStop = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 381);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.addCompanyBtn);
            this.Controls.Add(this.categoryCbx);
            this.Controls.Add(this.cNameCbx);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sPriceTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pPriceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pCodeTxt);
            this.Controls.Add(this.pCodeLabel);
            this.Controls.Add(this.pNameTxt);
            this.Controls.Add(this.pNameLabel);
            this.Name = "add_product";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.add_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addCompanyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pCodeLabel;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.PictureBox addCompanyBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox addCategoryBtn;
        public System.Windows.Forms.TextBox sPriceTxt;
        public System.Windows.Forms.TextBox pPriceTxt;
        public System.Windows.Forms.TextBox pCodeTxt;
        public System.Windows.Forms.TextBox pNameTxt;
        public System.Windows.Forms.ComboBox cNameCbx;
        public System.Windows.Forms.ComboBox categoryCbx;
        public System.Windows.Forms.Button saveBtn;
    }
}