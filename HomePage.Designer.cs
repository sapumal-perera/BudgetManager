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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtFilterFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtFilterToDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtgTransactionGrid = new System.Windows.Forms.DataGridView();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbSummary = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkIncludeDates = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chrtIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPredictCat = new System.Windows.Forms.ComboBox();
            this.cmbPredictType = new System.Windows.Forms.ComboBox();
            this.dtPredictDatePicker = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.transactionDataStore = new BudgetManager.TransactionDataStore();
            this.transactionDataStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPredictTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTotalExpence = new System.Windows.Forms.Label();
            this.lblPredictDay2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactionGrid)).BeginInit();
            this.tbSummary.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCategory)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblUser.Location = new System.Drawing.Point(11, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 54);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(691, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = " + Income";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.AddIncomeTransaction);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(85, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "\'s Budget Manager";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(802, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = " + Expense";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddExpenseTransaction);
            // 
            // dtFilterFromDate
            // 
            this.dtFilterFromDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtFilterFromDate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtFilterFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFilterFromDate.Location = new System.Drawing.Point(3, 18);
            this.dtFilterFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFilterFromDate.Name = "dtFilterFromDate";
            this.dtFilterFromDate.Size = new System.Drawing.Size(279, 24);
            this.dtFilterFromDate.TabIndex = 5;
            // 
            // dtFilterToDate
            // 
            this.dtFilterToDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtFilterToDate.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtFilterToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFilterToDate.Location = new System.Drawing.Point(302, 18);
            this.dtFilterToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFilterToDate.Name = "dtFilterToDate";
            this.dtFilterToDate.Size = new System.Drawing.Size(279, 24);
            this.dtFilterToDate.TabIndex = 6;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "expense",
            "income"});
            this.cmbFilterType.Location = new System.Drawing.Point(604, 18);
            this.cmbFilterType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(178, 26);
            this.cmbFilterType.TabIndex = 9;
            this.cmbFilterType.SelectedValueChanged += new System.EventHandler(this.OnTypeChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(6, 53);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(74, 33);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.onClickFilter);
            // 
            // dtgTransactionGrid
            // 
            this.dtgTransactionGrid.AllowUserToOrderColumns = true;
            this.dtgTransactionGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgTransactionGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTransactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransactionGrid.GridColor = System.Drawing.Color.DarkGray;
            this.dtgTransactionGrid.Location = new System.Drawing.Point(6, 127);
            this.dtgTransactionGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgTransactionGrid.Name = "dtgTransactionGrid";
            this.dtgTransactionGrid.RowHeadersWidth = 51;
            this.dtgTransactionGrid.RowTemplate.Height = 24;
            this.dtgTransactionGrid.Size = new System.Drawing.Size(990, 337);
            this.dtgTransactionGrid.TabIndex = 11;
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Items.AddRange(new object[] {
            "Food",
            "utility",
            "dividends"});
            this.cmbFilterCategory.Location = new System.Drawing.Point(798, 18);
            this.cmbFilterCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(178, 26);
            this.cmbFilterCategory.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(86, 53);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 33);
            this.button3.TabIndex = 13;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.onReserSummaryView);
            // 
            // tbSummary
            // 
            this.tbSummary.Controls.Add(this.tabPage1);
            this.tbSummary.Controls.Add(this.tabPage2);
            this.tbSummary.Controls.Add(this.tabPage3);
            this.tbSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSummary.Location = new System.Drawing.Point(0, 72);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.SelectedIndex = 0;
            this.tbSummary.Size = new System.Drawing.Size(1001, 476);
            this.tbSummary.TabIndex = 14;
            this.tbSummary.SelectedIndexChanged += new System.EventHandler(this.tbSummary_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lblTotalExpence);
            this.tabPage1.Controls.Add(this.lblTotalIncome);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.chkIncludeDates);
            this.tabPage1.Controls.Add(this.dtgTransactionGrid);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.cmbFilterType);
            this.tabPage1.Controls.Add(this.cmbFilterCategory);
            this.tabPage1.Controls.Add(this.dtFilterFromDate);
            this.tabPage1.Controls.Add(this.btnFilter);
            this.tabPage1.Controls.Add(this.dtFilterToDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Treansaction";
            // 
            // chkIncludeDates
            // 
            this.chkIncludeDates.AutoSize = true;
            this.chkIncludeDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeDates.ForeColor = System.Drawing.Color.DimGray;
            this.chkIncludeDates.Location = new System.Drawing.Point(174, 64);
            this.chkIncludeDates.Name = "chkIncludeDates";
            this.chkIncludeDates.Size = new System.Drawing.Size(108, 22);
            this.chkIncludeDates.TabIndex = 14;
            this.chkIncludeDates.Text = "filter by date";
            this.chkIncludeDates.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.chrtIncome);
            this.tabPage2.Controls.Add(this.chrtCategory);
            this.tabPage2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(993, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Summary Graphs";
            // 
            // chrtIncome
            // 
            this.chrtIncome.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea9.Name = "ChartArea1";
            this.chrtIncome.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chrtIncome.Legends.Add(legend9);
            this.chrtIncome.Location = new System.Drawing.Point(551, 12);
            this.chrtIncome.Name = "chrtIncome";
            this.chrtIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Income";
            this.chrtIncome.Series.Add(series9);
            this.chrtIncome.Size = new System.Drawing.Size(417, 401);
            this.chrtIncome.TabIndex = 1;
            this.chrtIncome.Text = "Income";
            title9.Name = "Income chart";
            this.chrtIncome.Titles.Add(title9);
            // 
            // chrtCategory
            // 
            this.chrtCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.Name = "ChartArea1";
            this.chrtCategory.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chrtCategory.Legends.Add(legend10);
            this.chrtCategory.Location = new System.Drawing.Point(31, 12);
            this.chrtCategory.Name = "chrtCategory";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Expenses";
            this.chrtCategory.Series.Add(series10);
            this.chrtCategory.Size = new System.Drawing.Size(495, 401);
            this.chrtCategory.TabIndex = 0;
            this.chrtCategory.Text = "chart1";
            title10.Name = "Categorywise expenes";
            this.chrtCategory.Titles.Add(title10);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lblPredictDay2);
            this.tabPage3.Controls.Add(this.lblPredictTotal);
            this.tabPage3.Controls.Add(this.cmbCategory);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnPredict);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbPredictCat);
            this.tabPage3.Controls.Add(this.cmbPredictType);
            this.tabPage3.Controls.Add(this.dtPredictDatePicker);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(993, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Predictor";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoSize = true;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.Location = new System.Drawing.Point(75, 224);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(62, 16);
            this.cmbCategory.TabIndex = 17;
            this.cmbCategory.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Required date";
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.ForeColor = System.Drawing.Color.Transparent;
            this.btnPredict.Location = new System.Drawing.Point(188, 327);
            this.btnPredict.Margin = new System.Windows.Forms.Padding(4);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(100, 28);
            this.btnPredict.TabIndex = 14;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Predicted total up to";
            // 
            // cmbPredictCat
            // 
            this.cmbPredictCat.FormattingEnabled = true;
            this.cmbPredictCat.Location = new System.Drawing.Point(188, 220);
            this.cmbPredictCat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPredictCat.Name = "cmbPredictCat";
            this.cmbPredictCat.Size = new System.Drawing.Size(369, 26);
            this.cmbPredictCat.TabIndex = 11;
            // 
            // cmbPredictType
            // 
            this.cmbPredictType.FormattingEnabled = true;
            this.cmbPredictType.Items.AddRange(new object[] {
            "income",
            "expense"});
            this.cmbPredictType.Location = new System.Drawing.Point(188, 151);
            this.cmbPredictType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPredictType.Name = "cmbPredictType";
            this.cmbPredictType.Size = new System.Drawing.Size(369, 26);
            this.cmbPredictType.TabIndex = 10;
            this.cmbPredictType.SelectedValueChanged += new System.EventHandler(this.OnPredicTypeChange);
            // 
            // dtPredictDatePicker
            // 
            this.dtPredictDatePicker.Location = new System.Drawing.Point(188, 71);
            this.dtPredictDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dtPredictDatePicker.MinDate = new System.DateTime(2022, 3, 26, 0, 0, 0, 0);
            this.dtPredictDatePicker.Name = "dtPredictDatePicker";
            this.dtPredictDatePicker.Size = new System.Drawing.Size(369, 24);
            this.dtPredictDatePicker.TabIndex = 9;
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
            // lblPredictTotal
            // 
            this.lblPredictTotal.AutoSize = true;
            this.lblPredictTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredictTotal.Location = new System.Drawing.Point(739, 165);
            this.lblPredictTotal.Name = "lblPredictTotal";
            this.lblPredictTotal.Size = new System.Drawing.Size(28, 31);
            this.lblPredictTotal.TabIndex = 19;
            this.lblPredictTotal.Text = "0";
            this.lblPredictTotal.Click += new System.EventHandler(this.lblPredictTotal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Expence :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Income :";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(722, 78);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(16, 18);
            this.lblTotalIncome.TabIndex = 17;
            this.lblTotalIncome.Text = "0";
            // 
            // lblTotalExpence
            // 
            this.lblTotalExpence.AutoSize = true;
            this.lblTotalExpence.Location = new System.Drawing.Point(916, 78);
            this.lblTotalExpence.Name = "lblTotalExpence";
            this.lblTotalExpence.Size = new System.Drawing.Size(16, 18);
            this.lblTotalExpence.TabIndex = 18;
            this.lblTotalExpence.Text = "0";
            // 
            // lblPredictDay2
            // 
            this.lblPredictDay2.AutoSize = true;
            this.lblPredictDay2.Location = new System.Drawing.Point(848, 90);
            this.lblPredictDay2.Name = "lblPredictDay2";
            this.lblPredictDay2.Size = new System.Drawing.Size(40, 18);
            this.lblPredictDay2.TabIndex = 21;
            this.lblPredictDay2.Text = "../../..";
            this.lblPredictDay2.Click += new System.EventHandler(this.lblPredictDay2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "from today";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(402, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "* your transaction in last 30 Days will be used for predictions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(739, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "LKR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(611, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "(LKR)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(795, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "(LKR)";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(929, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(66, 33);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.ClickbtnLogout);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1001, 548);
            this.Controls.Add(this.tbSummary);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "Budget Manager Home";
            this.Load += new System.EventHandler(this.HpmePage_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactionGrid)).EndInit();
            this.tbSummary.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCategory)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataStoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TabControl tbSummary;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPredictCat;
        private System.Windows.Forms.ComboBox cmbPredictType;
        private System.Windows.Forms.DateTimePicker dtPredictDatePicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIncome;
        private System.Windows.Forms.CheckBox chkIncludeDates;
        private System.Windows.Forms.Label lblPredictTotal;
        private System.Windows.Forms.Label lblTotalExpence;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPredictDay2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLogout;
    }
}