namespace Lesson6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.datePickerEntryDate = new System.Windows.Forms.DateTimePicker();
            this.tableEntry = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelBalanceValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(45, 6);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(44, 13);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Сумма:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(53, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Дата:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.AccessibleName = "";
            this.textBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmount.Location = new System.Drawing.Point(95, 6);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(476, 20);
            this.textBoxAmount.TabIndex = 2;
            // 
            // datePickerEntryDate
            // 
            this.datePickerEntryDate.AccessibleName = "";
            this.datePickerEntryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerEntryDate.Location = new System.Drawing.Point(95, 32);
            this.datePickerEntryDate.Name = "datePickerEntryDate";
            this.datePickerEntryDate.Size = new System.Drawing.Size(476, 20);
            this.datePickerEntryDate.TabIndex = 4;
            // 
            // tableEntry
            // 
            this.tableEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Amount,
            this.Date,
            this.Category,
            this.Description});
            this.tableEntry.Location = new System.Drawing.Point(15, 142);
            this.tableEntry.Name = "tableEntry";
            this.tableEntry.Size = new System.Drawing.Size(556, 227);
            this.tableEntry.TabIndex = 5;
            this.tableEntry.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableEntry_CellValueChanged);
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Сумма";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleName = "";
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(189, 113);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(382, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(26, 58);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(63, 13);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "Категория:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(29, 87);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Описание:";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCategory.Location = new System.Drawing.Point(95, 58);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(476, 20);
            this.textBoxCategory.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(95, 87);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(476, 20);
            this.textBoxDescription.TabIndex = 10;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(12, 372);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(47, 13);
            this.labelBalance.TabIndex = 11;
            this.labelBalance.Text = "Баланс:";
            // 
            // labelBalanceValue
            // 
            this.labelBalanceValue.AutoSize = true;
            this.labelBalanceValue.Location = new System.Drawing.Point(65, 372);
            this.labelBalanceValue.Name = "labelBalanceValue";
            this.labelBalanceValue.Size = new System.Drawing.Size(13, 13);
            this.labelBalanceValue.TabIndex = 12;
            this.labelBalanceValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 394);
            this.Controls.Add(this.labelBalanceValue);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tableEntry);
            this.Controls.Add(this.datePickerEntryDate);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.DateTimePicker datePickerEntryDate;
        private System.Windows.Forms.DataGridView tableEntry;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelBalanceValue;
    }
}

