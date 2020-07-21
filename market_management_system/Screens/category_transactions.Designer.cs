namespace market_management_system
{
    partial class category_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(category_transactions));
            this.dgvCatecory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.categoryNameTxt = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatecory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCatecory
            // 
            this.dgvCatecory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatecory.Location = new System.Drawing.Point(12, 12);
            this.dgvCatecory.Name = "dgvCatecory";
            this.dgvCatecory.Size = new System.Drawing.Size(460, 150);
            this.dgvCatecory.TabIndex = 0;
            this.dgvCatecory.DoubleClick += new System.EventHandler(this.dgvCatecory_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addCategoryBtn);
            this.groupBox1.Controls.Add(this.categoryNameTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Name";
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Location = new System.Drawing.Point(48, 84);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(119, 40);
            this.addCategoryBtn.TabIndex = 2;
            this.addCategoryBtn.Text = "Add";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // categoryNameTxt
            // 
            this.categoryNameTxt.Location = new System.Drawing.Point(6, 57);
            this.categoryNameTxt.Name = "categoryNameTxt";
            this.categoryNameTxt.Size = new System.Drawing.Size(205, 21);
            this.categoryNameTxt.TabIndex = 1;
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
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "exit.png");
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
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // category_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCatecory);
            this.Name = "category_transactions";
            this.Text = "Category Transactions";
            this.Load += new System.EventHandler(this.category_transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatecory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatecory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.TextBox categoryNameTxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button closeBtn;
    }
}