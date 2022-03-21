namespace BudgetManager
{
    partial class HomePage
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
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtFilterFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtFilterToDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtgTransactionGrid = new System.Windows.Forms.DataGridView();
            this.transactionDataStore = new BudgetManager.TransactionDataStore();
            this.transactionDataStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUser.Location = new System.Drawing.Point(11, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 82);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(75, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "\'s Budget Manager";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(723, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Predictor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OpenPredictor);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Expense";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddExpenseTransaction);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Income";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddIncomeTransaction);
            // 
            // dtFilterFromDate
            // 
            this.dtFilterFromDate.Location = new System.Drawing.Point(12, 114);
            this.dtFilterFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFilterFromDate.Name = "dtFilterFromDate";
            this.dtFilterFromDate.Size = new System.Drawing.Size(231, 22);
            this.dtFilterFromDate.TabIndex = 5;
            // 
            // dtFilterToDate
            // 
            this.dtFilterToDate.Location = new System.Drawing.Point(249, 114);
            this.dtFilterToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFilterToDate.Name = "dtFilterToDate";
            this.dtFilterToDate.Size = new System.Drawing.Size(230, 22);
            this.dtFilterToDate.TabIndex = 6;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "expense",
            "income"});
            this.cmbFilterType.Location = new System.Drawing.Point(485, 114);
            this.cmbFilterType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(103, 24);
            this.cmbFilterType.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(705, 114);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(47, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.onClickFilter);
            // 
            // dtgTransactionGrid
            // 
            this.dtgTransactionGrid.BackgroundColor = System.Drawing.Color.White;
            this.dtgTransactionGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTransactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransactionGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgTransactionGrid.GridColor = System.Drawing.Color.DarkGray;
            this.dtgTransactionGrid.Location = new System.Drawing.Point(0, 158);
            this.dtgTransactionGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgTransactionGrid.Name = "dtgTransactionGrid";
            this.dtgTransactionGrid.RowHeadersWidth = 51;
            this.dtgTransactionGrid.RowTemplate.Height = 24;
            this.dtgTransactionGrid.Size = new System.Drawing.Size(823, 331);
            this.dtgTransactionGrid.TabIndex = 11;
            // 
            // transactionDataStore
            // 
            this.transactionDataStore.DataSetName = "TransactionDataStore";
            this.transactionDataStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionDataStoreBindingSource
            // 
            this.transactionDataStoreBindingSource.DataSource = this.transactionDataStore;
            this.transactionDataStoreBindingSource.Position = 0;
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Items.AddRange(new object[] {
            "Food",
            "utility",
            "dividends"});
            this.cmbFilterCategory.Location = new System.Drawing.Point(595, 114);
            this.cmbFilterCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(104, 24);
            this.cmbFilterCategory.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 113);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onReserSummaryView);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 489);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbFilterCategory);
            this.Controls.Add(this.dtgTransactionGrid);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.dtFilterToDate);
            this.Controls.Add(this.dtFilterFromDate);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "Budget Manager Home";
            this.Load += new System.EventHandler(this.HpmePage_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFilterFromDate;
        private System.Windows.Forms.DateTimePicker dtFilterToDate;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Button btnFilter;
        private TransactionDataStore transactionDataStore;
        private System.Windows.Forms.BindingSource transactionDataStoreBindingSource;
        public System.Windows.Forms.DataGridView dtgTransactionGrid;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.Button button3;
    }
}