using BudgetManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class HomePage : Form
    {
        TransactionDataStore transactionStore = new TransactionDataStore();
        CategoryDataStore categoryStore = new CategoryDataStore();
        public ObservableCollection<Category> expenseCategories = new ObservableCollection<Category>();
        public ObservableCollection<Category> incomeCategories = new ObservableCollection<Category>();
        public String currentUser { get; set; }
        Transaction transactionData;
        DateTime filterFromDate;
        DateTime filterToDate;
        String filterCategory;
        bool isFilterByDate;
        String filterType;

        String predictType;
        String predictCategory;
        DateTime predictDate;

        public HomePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// /handle home page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HpmePage_load(object sender, EventArgs e)
        {
            UpdateInitialDummyData();
            ShowSummary();
            UpdateCharts();
            updateTotal("");
            lblUser.Text = currentUser.ToString();
        }

        /// <summary>
        /// add set of dumy data to system
        /// </summary>
        private void UpdateInitialDummyData()
        {
            this.expenseCategories.Add(new Category("Food", "Food expenses", "expense", 0, 18000));
            this.expenseCategories.Add(new Category("Grocery", "Grocery expenses", "expense", 0, 2000));
            this.expenseCategories.Add(new Category("Utility", "Utility expenses", "expense", 0, 6000));
            this.expenseCategories.Add(new Category("Bank", "Bank expenses", "expense", 0, 0));
            this.expenseCategories.Add(new Category("Health", "Health expenses", "expense", 0, 0));
            this.expenseCategories.Add(new Category("Entertainment", "Entertainment expenses", "expense", 0, 4000));
            this.expenseCategories.Add(new Category("Household", "Household expenses", "expense", 0, 0));
            this.expenseCategories.Add(new Category("Personal", "Personal expenses", "expense", 0, 0));
            this.expenseCategories.Add(new Category("Other", "Other expenses", "expense", 0, 0));
            this.incomeCategories.Add(new Category("Salary", "Salary income", "income", 0, 40000));
            this.incomeCategories.Add(new Category("Profit", "Profit income", "income", 0, 0));
            this.incomeCategories.Add(new Category("Dividends", "Dividends income", "income", 0, 26000));

            foreach (Category categ in expenseCategories)
            {
                CategoryDataStore.CategoryRow category = this.categoryStore.Category.NewCategoryRow();
                category.Title = categ.Title;
                category.Description = categ.Description;
                category.Type = categ.Type;
                category.Budget = categ.Budget;
                category.CurrentTotal = categ.CurrentTotal;
                this.categoryStore.Category.AddCategoryRow(category);
            }

            foreach (Category categ in incomeCategories)
            {
                CategoryDataStore.CategoryRow category = this.categoryStore.Category.NewCategoryRow();
                category.Title = categ.Title;
                category.Description = categ.Description;
                category.Type = categ.Type;
                category.Budget = categ.Budget;
                category.CurrentTotal = categ.CurrentTotal;
                this.categoryStore.Category.AddCategoryRow(category);
            }

            TransactionDataStore.TransactionDataRow transaction7 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction7.Title = "Pizza bill";
            transaction7.Description = "Pizza hut delivery";
            transaction7.Category = "Food";
            transaction7.Type = "expense";
            transaction7.Ammount = 6000;
            transaction7.Date = new DateTime(2022, 2, 15);
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction7);

            TransactionDataStore.TransactionDataRow transaction = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction.Title = "Internet bill";
            transaction.Description = "Payed for mobitel";
            transaction.Category = "Utility";
            transaction.Type = "expense";
            transaction.Date = new DateTime(2022,2,22);
            transaction.Ammount = 6000;
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction);

            TransactionDataStore.TransactionDataRow transaction3 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction3.Title = "CSE Dividends";
            transaction3.Description = "Dividends for stocks";
            transaction3.Category = "Dividends";
            transaction3.Type = "income";
            transaction3.Ammount = 26000;
            transaction3.Date = new DateTime(2022, 3, 22);
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction3);

            TransactionDataStore.TransactionDataRow transaction4 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction4.Title = "Spiderman movie";
            transaction4.Description = "Watch in savoy";
            transaction4.Category = "Entertainment";
            transaction4.Type = "expense";
            transaction4.Ammount = 4000;
            transaction4.Date = new DateTime(2022, 3, 16);
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction4);

            TransactionDataStore.TransactionDataRow transaction5 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction5.Title = "Grocery";
            transaction5.Description = "Shop at keels ";
            transaction5.Category = "Grocery";
            transaction5.Type = "expense";
            transaction5.Ammount = 2000;
            transaction5.Date = new DateTime(2022, 3, 20);
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction5);

            TransactionDataStore.TransactionDataRow transaction2 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction2.Title = "Resturant bill";
            transaction2.Description = "KFC";
            transaction2.Category = "Food";
            transaction2.Type = "expense";
            transaction2.Ammount = 12000;
            transaction2.Date = new DateTime(2022, 3, 12);
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction2);

            TransactionDataStore.TransactionDataRow transaction6 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction6.Title = "January salary";
            transaction6.Description = "added bonus also";
            transaction6.Category = "Salary";
            transaction6.Type = "income";
            transaction6.Ammount = 40000;
            transaction6.Date = new DateTime(2022, 3, 11);
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction6);

        }

        /// <summary>
        /// call when expense transaction added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddExpenseTransaction(object sender, EventArgs e)
        {
            AddTransaction addTransactionView = new AddTransaction("expense", this.expenseCategories);
            addTransactionView.ShowDialog();
            transactionData = addTransactionView.newTransaction;
            TransactionDataStore.TransactionDataRow transaction = this.transactionStore.TransactionData.NewTransactionDataRow();
            if(transactionData != null)
            {
                transaction.Type = transactionData.Type;
                transaction.Date = transactionData.Date;
                transaction.Title = transactionData.Title;
                transaction.Description = transactionData.Description;
                transaction.Category = transactionData.Category;
                transaction.Ammount = transactionData.Ammount;
                this.transactionStore.TransactionData.AddTransactionDataRow(transaction);
                foreach (DataRow row in this.categoryStore.Category.Select("Title = '" + transaction.Category + "'"))
                    {
                    row["CurrentTotal"] = Convert.ToDouble(row["CurrentTotal"]) + transaction.Ammount;
                    }
                this.categoryStore.Tables[0].AcceptChanges();
                UpdateCharts();
            }    
        }
        /// <summary>
        /// call when income transactionn added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncomeTransaction(object sender, EventArgs e)
        {
            AddTransaction addTransactionView = new AddTransaction("income", this.incomeCategories);
          //  addTransactionView.RecordAdded += CategoryAdded;
            addTransactionView.ShowDialog();

            transactionData = addTransactionView.newTransaction;
            TransactionDataStore.TransactionDataRow transaction = this.transactionStore.TransactionData.NewTransactionDataRow();
            if(transactionData != null)
            {
                transaction.Type = transactionData.Type;
                transaction.Date = transactionData.Date;
                transaction.Title = transactionData.Title;
                transaction.Description = transactionData.Description;
                transaction.Category = transactionData.Category;
                transaction.Ammount = transactionData.Ammount;

                this.transactionStore.TransactionData.AddTransactionDataRow(transaction);
                foreach (DataRow row in this.categoryStore.Category.Select("Title = '" + transaction.Category + "'"))
                {
                    row["CurrentTotal"] = Convert.ToDouble(row["CurrentTotal"]) + transaction.Ammount;
                }
                this.categoryStore.Tables[0].AcceptChanges();
                UpdateCharts();
            }
        }
        /// <summary>
        /// update chart views (Income and Expense)
        /// </summary>
        public void UpdateCharts()
        {
            this.chrtCategory.Series["Expenses"].Points.Clear();
            foreach (DataRow row in this.categoryStore.Category.Select("Type = 'expense'"))
            {
                this.chrtCategory.Series["Expenses"].Points.AddXY(row["Title"], row["CurrentTotal"]);
            }
            this.chrtIncome.Series["Income"].Points.Clear();
            foreach (DataRow row in this.categoryStore.Category.Select("Type = 'income'"))
            {
                this.chrtIncome.Series["Income"].Points.AddXY(row["Title"], row["CurrentTotal"]);
            }
        }

        /// <summary>
        /// call when category added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="catg"></param>
        private void CategoryAdded(object sender, Category catg)
        {
            CategoryDataStore.CategoryRow category = this.categoryStore.Category.NewCategoryRow();
            if(catg != null)
            {
                category.Type = catg.Type;
                category.Title = catg.Title;
                category.Description = catg.Description;
                category.Budget = catg.Budget;
            }
            this.categoryStore.Category.AddCategoryRow(category);
        }
        /// <summary>
        /// update summary grid view
        /// </summary>
        private void ShowSummary()
        {
            this.dtgTransactionGrid.DataSource = this.transactionStore.TransactionData;
        }

        /// <summary>
        /// call when click on filter button.  Handles the filter queries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickFilter(object sender, EventArgs e)
        {
            this.filterFromDate = this.dtFilterFromDate.Value.Date;
            this.filterToDate = this.dtFilterToDate.Value.Date;
            this.filterType = this.cmbFilterType.Text;
            this.filterCategory = this.cmbFilterCategory.Text;
            this.isFilterByDate = this.chkIncludeDates.Checked;
            DataView dv = new DataView(this.transactionStore.TransactionData);
            String filterQuery = "";

            if(isFilterByDate)
            {
                if (this.filterFromDate != null && this.filterToDate != null && this.filterCategory != "" && this.filterType != "")
                {
                    filterQuery = "Date > '" + this.filterFromDate + "' And  Date <'" + this.filterToDate + "' And Category = '" + this.filterCategory + "' And Type = '" + this.filterType + "'";
                }
                else if (this.filterFromDate != null && this.filterToDate != null && this.filterCategory == "" && this.filterType == "")
                {
                    filterQuery = "Date > '" + this.filterFromDate + "' And  Date <'" + this.filterToDate + "'";
                }
                else if (this.filterFromDate != null && this.filterToDate != null && this.filterCategory == "" && this.filterType != "")
                {
                    filterQuery = "Date > '" + this.filterFromDate + "' And  Date <'" + this.filterToDate + "' And Type = '" + this.filterType + "'";
                }
                else if (this.filterFromDate != null && this.filterToDate != null && this.filterCategory != "" && this.filterType != "")
                {
                    filterQuery = "Date > '" + this.filterFromDate + "' And  Date <'" + this.filterToDate + "' And Category = '" + this.filterCategory + "' AND Type = '" + this.filterType + "'";
                }
            }
            else
            {
              
                if (this.filterCategory == "" && this.filterType != "")
                {
                    filterQuery = "Type = '" + this.filterType + "'";
                }
                else if (this.filterCategory != "" && this.filterType != "")
                {
                    filterQuery = "Category = '" + this.filterCategory + "' AND Type = '" + this.filterType + "'";
                }
            }
            if (filterQuery != "") {
                dv.RowFilter = filterQuery;
            }
            this.dtgTransactionGrid.DataSource = dv;
            updateTotal(filterQuery);
        }

      private void  updateTotal(String query)
        {
            double incomeTotal = 0;
            double expenseTotal = 0;

            foreach (DataRow row in this.transactionStore.TransactionData.Select(query))
            {
                String type = row["Type"].ToString();
                if(type == "income")
                {
                    incomeTotal = incomeTotal + Convert.ToDouble(row["Ammount"]);

                } else if (type == "expense")
                {
                    expenseTotal = expenseTotal + Convert.ToDouble(row["Ammount"]);
                }
                
            }
            this.lblTotalIncome.Text = incomeTotal.ToString();
            this.lblTotalExpence.Text = expenseTotal.ToString();
        }


        /// <summary>
        ///  cll when reset the filteres in summary. loads all.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onReserSummaryView(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.transactionStore.TransactionData);
            this.dtgTransactionGrid.DataSource = dv;
            updateTotal("");
        }

        /// <summary>
        /// bind categorie to the combo boxes
        /// </summary>
        private void bindCategories()
        {
            this.cmbFilterCategory.DataSource = null;
            if (this.filterType == "expense")
            {
                this.cmbFilterCategory.DataSource = this.expenseCategories;
            }
            else if (this.filterType == "income")
            {
                this.cmbFilterCategory.DataSource = this.incomeCategories;
            }
            this.cmbFilterCategory.DisplayMember = "Title";
            this.cmbFilterCategory.Refresh();
        }


        /// <summary>
        /// call when transaction type changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTypeChanged(object sender, EventArgs e)
        {
            this.filterType = this.cmbFilterType.Text;
            bindCategories();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            this.predictDate = this.dtPredictDatePicker.Value.Date;
            this.predictType = this.cmbPredictType.Text;
            this.predictCategory = this.cmbPredictCat.Text;
            DateTime lastmonth = DateTime.Today.AddMonths(-1);
            double totalValue30Days = 0;
            String filter = "";


            System.TimeSpan dateDiff = predictDate.Subtract(DateTime.Today);
            int numOfDays = Convert.ToInt32(dateDiff.TotalDays);
            if(numOfDays == 0)
            {
                numOfDays = 1;
            }

            DataView dv = new DataView(this.transactionStore.TransactionData);
            if (this.predictCategory != "" && this.predictType != "")
            {
                filter = "Date > '" + lastmonth + "' And Category = '" + this.predictCategory + "' And Type = '" + this.predictType + "'";
            }
            else if (this.predictCategory == "" && this.predictType != "")
            {
                filter = "Date > '" + lastmonth + "' And Type = '" + this.predictType + "'";
            }

            foreach (DataRow row in this.transactionStore.TransactionData.Select(filter))
            {
                totalValue30Days = totalValue30Days + Convert.ToDouble(row["Ammount"]);
            }

            double predictForDay = totalValue30Days / 30;

            lblPredictTotal.Text = Math.Round((predictForDay * numOfDays), 2).ToString();
            this.lblPredictDay2.Text = this.predictDate.ToShortDateString();

        }

        private void bindCategoriesForPredicView()
        {
            this.cmbPredictCat.DataSource = null;
            if (this.predictType == "expense")
            {
                this.cmbPredictCat.DataSource = this.expenseCategories;
            }
            else if (this.predictType == "income")
            {
                this.cmbPredictCat.DataSource = this.incomeCategories;
            }
            this.cmbPredictCat.DisplayMember = "Title";
            this.cmbPredictCat.Refresh();
        }

        private void OnPredicTypeChange(object sender, EventArgs e)
        {
            this.predictType = this.cmbPredictType.Text;
            bindCategoriesForPredicView();
        }
        private void ClickbtnLogout(object sender, EventArgs e)
        {
            LoginForm loginFrm = new LoginForm();
            this.Hide();
            loginFrm.Show();
        }

        private void tbSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void lblPredictDay2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPredictTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
  
        }


    }
}
