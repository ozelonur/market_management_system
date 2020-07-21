namespace market_management_system
{
    partial class sales_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales_transactions));
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.billNumLabel = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerSurName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChckOut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnSale = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.salePriceTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(11, 94);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(776, 251);
            this.dgvSales.TabIndex = 7;
            this.dgvSales.DoubleClick += new System.EventHandler(this.dgvSales_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.ImageKey = "search.png";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(511, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 62);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "All",
            "Bill Number",
            "Customer Name",
            "Customer Surname",
            "ID Number",
            "Product Name",
            "Sale Price",
            "Piece",
            "Total Amount",
            "Checkout Number"});
            this.cmbSearch.Location = new System.Drawing.Point(315, 29);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(170, 21);
            this.cmbSearch.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // billNumLabel
            // 
            this.billNumLabel.AutoSize = true;
            this.billNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumLabel.Location = new System.Drawing.Point(12, 369);
            this.billNumLabel.Name = "billNumLabel";
            this.billNumLabel.Size = new System.Drawing.Size(71, 13);
            this.billNumLabel.TabIndex = 8;
            this.billNumLabel.Text = "Bill Number";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(130, 366);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(121, 20);
            this.txtBillNumber.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(130, 392);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Name";
            // 
            // txtCustomerSurName
            // 
            this.txtCustomerSurName.Location = new System.Drawing.Point(130, 418);
            this.txtCustomerSurName.Name = "txtCustomerSurName";
            this.txtCustomerSurName.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerSurName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer Surname";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(130, 444);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(121, 20);
            this.txtIdNumber.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID Number";
            // 
            // pNameLabel
            // 
            this.pNameLabel.AutoSize = true;
            this.pNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.Location = new System.Drawing.Point(12, 473);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(87, 13);
            this.pNameLabel.TabIndex = 16;
            this.pNameLabel.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sales Price";
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(130, 470);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(121, 21);
            this.cmbProductName.TabIndex = 20;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date";
            // 
            // txtChckOut
            // 
            this.txtChckOut.Location = new System.Drawing.Point(413, 444);
            this.txtChckOut.Name = "txtChckOut";
            this.txtChckOut.Size = new System.Drawing.Size(121, 20);
            this.txtChckOut.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Checkout Number";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(413, 418);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(121, 20);
            this.txtTotalAmount.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total Amount";
            // 
            // txtPiece
            // 
            this.txtPiece.Location = new System.Drawing.Point(413, 392);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(121, 20);
            this.txtPiece.TabIndex = 22;
            this.txtPiece.TextChanged += new System.EventHandler(this.txtPiece_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Piece";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(413, 471);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(121, 20);
            this.dtDate.TabIndex = 28;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSale.ImageKey = "sale.png";
            this.btnSale.ImageList = this.imageList2;
            this.btnSale.Location = new System.Drawing.Point(563, 392);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(99, 99);
            this.btnSale.TabIndex = 29;
            this.btnSale.Text = "Sell";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "exit.png");
            this.imageList2.Images.SetKeyName(1, "sale.png");
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.ImageKey = "exit.png";
            this.btnClose.ImageList = this.imageList2;
            this.btnClose.Location = new System.Drawing.Point(688, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(99, 99);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // salePriceTxt
            // 
            this.salePriceTxt.Location = new System.Drawing.Point(130, 496);
            this.salePriceTxt.Name = "salePriceTxt";
            this.salePriceTxt.Size = new System.Drawing.Size(121, 20);
            this.salePriceTxt.TabIndex = 31;
            // 
            // sales_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.salePriceTxt);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChckOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pNameLabel);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerSurName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.billNumLabel);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "sales_transactions";
            this.Text = "Sales Transactions";
            this.Load += new System.EventHandler(this.sales_transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label billNumLabel;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerSurName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChckOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPiece;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox salePriceTxt;
    }
}