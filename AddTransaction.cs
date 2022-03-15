using BudgetManager.Model;
using System;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class AddTransaction : Form
    {
        public Transaction newTransaction;
        public AddTransaction()
        {
            InitializeComponent();
        }

        private void CreateTransaction(object sender, EventArgs e)
        {
           String title = this.txtTitle.Text;
           String description = this.txtBudget.Text;
           String category = this.cmbCategory.Text;
           String type = this.cmbType.Text;
           newTransaction = new Model.Transaction(title: title, description: description, date: DateTime.Today, category: category, type: type);
        }




    }
}
