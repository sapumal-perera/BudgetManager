using BudgetManager.Model;
using System;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class AddTransaction : Form
    {
        String type;
        public Transaction newTransaction;
        public AddTransaction(String type)
        {   this.type = type;
            InitializeComponent();
        }

        private void CreateTransaction(object sender, EventArgs e)
        {
           String title = this.txtTitle.Text;
           String description = this.txtBudget.Text;
           String category = this.cmbCategory.Text;
           String type = this.type;
           newTransaction = new Model.Transaction(title: title, description: description, date: DateTime.Today, category: category, type: type);
            this.Hide();
        }




    }
}
