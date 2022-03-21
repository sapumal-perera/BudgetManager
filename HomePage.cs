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
            TransactionDataStore.TransactionDataRow transaction = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction.Title = "Internet bill";
            transaction.Description = "Payed for mobitel";
            transaction.Category = "utility";
            transaction.Type = "expense";
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction);

            TransactionDataStore.TransactionDataRow transaction2 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction2.Title = "Resturant bill";
            transaction2.Description = "Payed for mobitel";
            transaction2.Category = "Food";
            transaction2.Type = "expense";
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction2);

            TransactionDataStore.TransactionDataRow transaction3 = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction3.Title = "CSE Dividends";
            transaction3.Description = "Dividends for stocks";
            transaction3.Category = "dividends";
            transaction3.Type = "income";
            this.transactionStore.TransactionData.AddTransactionDataRow(transaction3);
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
            addTransactionView.ShowDialog();

            transactionData = addTransactionView.newTransaction;
            TransactionDataStore.TransactionDataRow transaction = this.transactionStore.TransactionData.NewTransactionDataRow();
            transaction.Type = transactionData.Type;
            transaction.Date = transactionData.Date;
            transaction.Title = transactionData.Title;
            transaction.Description = transactionData.Description;
            transaction.Category = transactionData.Category;

            this.transactionStore.TransactionData.AddTransactionDataRow(transaction);
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
            this.filterFromDate = this.dtFilterFromDate.Value.Date;
            this.filterToDate = this.dtFilterToDate.Value.Date;
            this.filterType = this.cmbFilterType.Text;
            this.filterCategory = this.cmbFilterCategory.Text;
            DataView dv = new DataView(this.transactionStore.TransactionData);
          //  dv.RowFilter = "Category = '" + this.filterCategory + "' AND Type = '"+this.filterType+"'";

            dv.RowFilter = "Date > '" + this.filterFromDate + "' And  Date <'" + this.filterToDate + "'";
            this.dtgTransactionGrid.DataSource = dv;

        }

        private void onReserSummaryView(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.transactionStore.TransactionData);
            this.dtgTransactionGrid.DataSource = dv;
        }
    }
}
