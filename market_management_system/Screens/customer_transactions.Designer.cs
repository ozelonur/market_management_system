namespace market_management_system
{
    partial class customer_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_transactions));
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchCBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(140, 36);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(170, 20);
            this.searchTxt.TabIndex = 0;
            // 
            // searchCBox
            // 
            this.searchCBox.FormattingEnabled = true;
            this.searchCBox.Items.AddRange(new object[] {
            "All",
            "Name",
            "Surname",
            "ID Number",
            "Mobile Phone",
            "Home Phone",
            "Address"});
            this.searchCBox.Location = new System.Drawing.Point(316, 35);
            this.searchCBox.Name = "searchCBox";
            this.searchCBox.Size = new System.Drawing.Size(170, 21);
            this.searchCBox.TabIndex = 1;
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
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "exit.png");
            this.imageList1.Images.SetKeyName(4, "edit.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 251);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeBtn.ImageKey = "exit.png";
            this.closeBtn.ImageList = this.imageList1;
            this.closeBtn.Location = new System.Drawing.Point(668, 357);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(86, 81);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteBtn.ImageKey = "delete.png";
            this.deleteBtn.ImageList = this.imageList1;
            this.deleteBtn.Location = new System.Drawing.Point(571, 357);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(86, 81);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addBtn.ImageKey = "add.png";
            this.addBtn.ImageList = this.imageList1;
            this.addBtn.Location = new System.Drawing.Point(387, 357);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(86, 81);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editBtn.ImageKey = "edit.png";
            this.editBtn.ImageList = this.imageList1;
            this.editBtn.Location = new System.Drawing.Point(479, 357);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(86, 81);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Edit";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // customer_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchCBox);
            this.Controls.Add(this.searchTxt);
            this.Name = "customer_transactions";
            this.Text = "Customer Transactions";
            this.Load += new System.EventHandler(this.customer_transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox searchCBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}