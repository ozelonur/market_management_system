namespace market_management_system
{
    partial class company_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(company_transactions));
            this.closeBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCompanyBtn = new System.Windows.Forms.Button();
            this.companyNameTxt = new System.Windows.Forms.TextBox();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.ImageKey = "exit.png";
            this.closeBtn.ImageList = this.imageList1;
            this.closeBtn.Location = new System.Drawing.Point(372, 186);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 100);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "exit.png");
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteBtn.ImageKey = "delete.png";
            this.deleteBtn.ImageList = this.imageList1;
            this.deleteBtn.Location = new System.Drawing.Point(249, 186);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 100);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addCompanyBtn);
            this.groupBox1.Controls.Add(this.companyNameTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(6, 74);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(205, 21);
            this.addressTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Company Name";
            // 
            // addCompanyBtn
            // 
            this.addCompanyBtn.Location = new System.Drawing.Point(63, 101);
            this.addCompanyBtn.Name = "addCompanyBtn";
            this.addCompanyBtn.Size = new System.Drawing.Size(86, 21);
            this.addCompanyBtn.TabIndex = 2;
            this.addCompanyBtn.Text = "Add";
            this.addCompanyBtn.UseVisualStyleBackColor = true;
            this.addCompanyBtn.Click += new System.EventHandler(this.addCompanyBtn_Click);
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.Location = new System.Drawing.Point(6, 34);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(205, 21);
            this.companyNameTxt.TabIndex = 1;
            // 
            // dgvCompany
            // 
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Location = new System.Drawing.Point(12, 12);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.Size = new System.Drawing.Size(460, 150);
            this.dgvCompany.TabIndex = 4;
            this.dgvCompany.DoubleClick += new System.EventHandler(this.dgvCompany_DoubleClick);
            // 
            // company_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCompany);
            this.Name = "company_transactions";
            this.Text = "Company Transactions";
            this.Load += new System.EventHandler(this.company_transactions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCompanyBtn;
        private System.Windows.Forms.TextBox companyNameTxt;
        private System.Windows.Forms.DataGridView dgvCompany;
    }
}