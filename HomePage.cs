﻿using BudgetManager.Model;
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

        public String currentUser { get; set; }
        Transaction transactionData;
        public HomePage()
        {
            InitializeComponent();
        }


        private void HpmePage_load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            lblUser.Text = currentUser.ToString();
            lblDate.Text = dateTime.ToString();
        }

        private void AddExpenseTransaction(object sender, EventArgs e)
        {
            AddTransaction addTransactionView = new AddTransaction();
            addTransactionView.Show();
            transactionData = addTransactionView.newTransaction;
            this.transactionStore.

        }

        private void AddIncomeTransaction(object sender, EventArgs e)
        {

        }

        private void ShowWeklySummary(object sender, EventArgs e)
        {

        }

        private void OpenPredictor(object sender, EventArgs e)
        {

        }
    }
}