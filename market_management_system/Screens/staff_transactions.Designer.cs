namespace market_management_system
{
    partial class staff_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff_transactions));
            this.addStaffBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addStaffBtn.ImageKey = "add.png";
            this.addStaffBtn.ImageList = this.imageList1;
            this.addStaffBtn.Location = new System.Drawing.Point(426, 357);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(86, 81);
            this.addStaffBtn.TabIndex = 13;
            this.addStaffBtn.Text = "Add";
            this.addStaffBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addStaffBtn.UseVisualStyleBackColor = true;
            this.addStaffBtn.Click += new System.EventHandler(this.addStaffBtn_Click);
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
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteBtn.ImageKey = "delete.png";
            this.deleteBtn.ImageList = this.imageList1;
            this.deleteBtn.Location = new System.Drawing.Point(610, 357);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(86, 81);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(12, 100);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(776, 251);
            this.dgvStaff.TabIndex = 10;
            this.dgvStaff.DoubleClick += new System.EventHandler(this.dgvStaff_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.ImageKey = "search.png";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(512, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 62);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Choose",
            "Name",
            "Surname",
            "ID Number",
            "Mobile Phone",
            "Home Phone",
            "Address",
            "Salary",
            "Checkout Number",
            "Date of Start",
            "Date of Quit",
            ""});
            this.cmbSearch.Location = new System.Drawing.Point(316, 35);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(170, 21);
            this.cmbSearch.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editBtn.ImageKey = "edit.png";
            this.editBtn.ImageList = this.imageList1;
            this.editBtn.Location = new System.Drawing.Point(518, 357);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(86, 81);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "Edit";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // staff_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addStaffBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "staff_transactions";
            this.Text = "Staff Transactions";
            this.Load += new System.EventHandler(this.staff_transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button editBtn;
    }
}