namespace market_management_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCustomerTrans = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnProductTrans = new System.Windows.Forms.Button();
            this.btnStaffTrans = new System.Windows.Forms.Button();
            this.btnStckTrans = new System.Windows.Forms.Button();
            this.btnSaleTrans = new System.Windows.Forms.Button();
            this.btnExitTrans = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDtp = new System.Windows.Forms.DateTimePicker();
            this.btnShowTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerTrans
            // 
            this.btnCustomerTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomerTrans.ImageKey = "customer_trans.png";
            this.btnCustomerTrans.ImageList = this.imageList1;
            this.btnCustomerTrans.Location = new System.Drawing.Point(12, 12);
            this.btnCustomerTrans.Name = "btnCustomerTrans";
            this.btnCustomerTrans.Size = new System.Drawing.Size(124, 72);
            this.btnCustomerTrans.TabIndex = 0;
            this.btnCustomerTrans.Text = "Customer Transactions";
            this.btnCustomerTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerTrans.UseVisualStyleBackColor = true;
            this.btnCustomerTrans.Click += new System.EventHandler(this.btnCustomerTrans_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "product.png");
            this.imageList1.Images.SetKeyName(1, "staff.png");
            this.imageList1.Images.SetKeyName(2, "customer_trans.png");
            this.imageList1.Images.SetKeyName(3, "stock.png");
            this.imageList1.Images.SetKeyName(4, "sales.png");
            this.imageList1.Images.SetKeyName(5, "exit.png");
            this.imageList1.Images.SetKeyName(6, "list_show.png");
            // 
            // btnProductTrans
            // 
            this.btnProductTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductTrans.ImageKey = "product.png";
            this.btnProductTrans.ImageList = this.imageList1;
            this.btnProductTrans.Location = new System.Drawing.Point(142, 12);
            this.btnProductTrans.Name = "btnProductTrans";
            this.btnProductTrans.Size = new System.Drawing.Size(124, 72);
            this.btnProductTrans.TabIndex = 1;
            this.btnProductTrans.Text = "Product Transactions";
            this.btnProductTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductTrans.UseVisualStyleBackColor = true;
            this.btnProductTrans.Click += new System.EventHandler(this.btnProductTrans_Click);
            // 
            // btnStaffTrans
            // 
            this.btnStaffTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaffTrans.ImageIndex = 1;
            this.btnStaffTrans.ImageList = this.imageList1;
            this.btnStaffTrans.Location = new System.Drawing.Point(272, 12);
            this.btnStaffTrans.Name = "btnStaffTrans";
            this.btnStaffTrans.Size = new System.Drawing.Size(124, 72);
            this.btnStaffTrans.TabIndex = 2;
            this.btnStaffTrans.Text = "Staff Transactions";
            this.btnStaffTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaffTrans.UseVisualStyleBackColor = true;
            this.btnStaffTrans.Click += new System.EventHandler(this.btnStaffTrans_Click);
            // 
            // btnStckTrans
            // 
            this.btnStckTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStckTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStckTrans.ImageIndex = 3;
            this.btnStckTrans.ImageList = this.imageList1;
            this.btnStckTrans.Location = new System.Drawing.Point(402, 12);
            this.btnStckTrans.Name = "btnStckTrans";
            this.btnStckTrans.Size = new System.Drawing.Size(124, 72);
            this.btnStckTrans.TabIndex = 3;
            this.btnStckTrans.Text = "Stock Transactions";
            this.btnStckTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStckTrans.UseVisualStyleBackColor = true;
            this.btnStckTrans.Click += new System.EventHandler(this.btnStckTrans_Click);
            // 
            // btnSaleTrans
            // 
            this.btnSaleTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaleTrans.ImageIndex = 4;
            this.btnSaleTrans.ImageList = this.imageList1;
            this.btnSaleTrans.Location = new System.Drawing.Point(532, 12);
            this.btnSaleTrans.Name = "btnSaleTrans";
            this.btnSaleTrans.Size = new System.Drawing.Size(124, 72);
            this.btnSaleTrans.TabIndex = 4;
            this.btnSaleTrans.Text = "Sales Transactions";
            this.btnSaleTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaleTrans.UseVisualStyleBackColor = true;
            this.btnSaleTrans.Click += new System.EventHandler(this.btnSaleTrans_Click);
            // 
            // btnExitTrans
            // 
            this.btnExitTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExitTrans.ImageIndex = 5;
            this.btnExitTrans.ImageList = this.imageList1;
            this.btnExitTrans.Location = new System.Drawing.Point(662, 12);
            this.btnExitTrans.Name = "btnExitTrans";
            this.btnExitTrans.Size = new System.Drawing.Size(124, 72);
            this.btnExitTrans.TabIndex = 5;
            this.btnExitTrans.Text = "Exit";
            this.btnExitTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExitTrans.UseVisualStyleBackColor = true;
            this.btnExitTrans.Click += new System.EventHandler(this.btnExitTrans_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 218);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(773, 220);
            this.dgvMain.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sales List";
            // 
            // mainDtp
            // 
            this.mainDtp.Location = new System.Drawing.Point(12, 192);
            this.mainDtp.Name = "mainDtp";
            this.mainDtp.Size = new System.Drawing.Size(195, 20);
            this.mainDtp.TabIndex = 8;
            // 
            // btnShowTrans
            // 
            this.btnShowTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowTrans.ImageKey = "list_show.png";
            this.btnShowTrans.ImageList = this.imageList1;
            this.btnShowTrans.Location = new System.Drawing.Point(661, 140);
            this.btnShowTrans.Name = "btnShowTrans";
            this.btnShowTrans.Size = new System.Drawing.Size(124, 72);
            this.btnShowTrans.TabIndex = 9;
            this.btnShowTrans.Text = "Show";
            this.btnShowTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowTrans.UseVisualStyleBackColor = true;
            this.btnShowTrans.Click += new System.EventHandler(this.btnShowTrans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowTrans);
            this.Controls.Add(this.mainDtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnExitTrans);
            this.Controls.Add(this.btnSaleTrans);
            this.Controls.Add(this.btnStckTrans);
            this.Controls.Add(this.btnStaffTrans);
            this.Controls.Add(this.btnProductTrans);
            this.Controls.Add(this.btnCustomerTrans);
            this.Name = "Form1";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerTrans;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnProductTrans;
        private System.Windows.Forms.Button btnStaffTrans;
        private System.Windows.Forms.Button btnStckTrans;
        private System.Windows.Forms.Button btnSaleTrans;
        private System.Windows.Forms.Button btnExitTrans;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker mainDtp;
        private System.Windows.Forms.Button btnShowTrans;
    }
}

