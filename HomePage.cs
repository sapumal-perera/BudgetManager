using BudgetManager.Model;
using System;
using System.Collections.Generic;
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

        public String currentUser { get; set; }
        Transaction transactionData;
        DateTime filterFromDate;
        DateTime filterToDate;
        String filterCategory;
        String filterType;

        public HomePage()
        {
            InitializeComponent();
        }


        private void HpmePage_load(object sender, EventArgs e)
        {
          //  DateTime dateTime = DateTime.UtcNow.Date;
            //lblUser.Text = currentUser.ToString();
         this.ShowSummary();
        }

        private void AddExpenseTransaction(object sender, EventArgs e)
        {
            AddTransaction addTransactionView = new AddTransaction("expense");
            addTransactionView.ShowDialog();
            transactionData = addTransactionView.newTransaction;
            TransactionDataStore.TransactionDataRow transaction = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction.Type = transactionData.Type;
            transaction.Date = transactionData.Date;
            transaction.Title = transactionData.Title;
            transaction.Description = transactionData.Description;
            transaction.Category = transactionData.Category;

            this.transactionStore.TransactionData.AddTransactionDataRow(transaction);
           

        }

        private void AddIncomeTransaction(object sender, EventArgs e)
        {
            AddTransaction addTransactionView = new AddTransaction("income");
            addTransactionView.RecordAdded += CategoryAdded;
            addTransactionView.Show();

            transactionData = addTransactionView.newTransaction;
            //this.transactionStore.
        }
        private void CategoryAdded(object sender, Category catg)
        {
            CategoryDataStore.CategoryRow category = this.categoryStore.Category.NewCategoryRow();
            category.Type = catg.Type;
            category.Title = catg.Title;
            category.Description = catg.Description;
            category.Budget = catg.Budget;

            this.categoryStore.Category.AddCategoryRow(category);
        }

        private void ShowSummary()
        {
            this.dtgTransactionGrid.DataSource = this.transactionStore.TransactionData;
        }
        private void OpenPredictor(object sender, EventArgs e)
        {

        }

        private void onClickFilter(object sender, EventArgs e)
        {
            this.filterFromDate = this.dtFilterFromDate.Value;
            this.filterToDate = this.dtFilterToDate.Value;
            this.filterType = this.cmbFilterType.Text;
            this.filterCategory = this.cmbFilterCategory.Text;
        }
    }
}
