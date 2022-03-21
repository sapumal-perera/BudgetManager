using BudgetManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class AddTransaction : Form
    {
        String type;
        public Transaction newTransaction;
        public Category category;
        public ObservableCollection<Category> categories = new ObservableCollection<Category>();
        public event EventHandler<Category> RecordAdded;
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
           DateTime date = this.dateTimePicker1.Value.Date;
            newTransaction = new Model.Transaction(title: title, description: description, date: date, category: category, type: type);
           this.Hide();
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
           AddCategory addCategoryView = new AddCategory(this.type);
            this.Hide();
            addCategoryView.ShowDialog();
            this.Show();
            category = addCategoryView.newcategory;
            this.categories.Add(category);
          //  this.cmbCategory.Items.Add(category);
            var handler = RecordAdded;
            if (RecordAdded != null)
            {
                RecordAdded.Invoke(this, category);
            }
            this.bindCategories();
            this.Refresh();
           
        }

        private void AddTransaction_load(object sender, EventArgs e)
        {
            this.categories.Add(new Category("rrr", "aaa", "bbb", "ccc"));
           this.cmbCategory.DataSource = this.categories;
            this.cmbCategory.DisplayMember = "Title";
        }

        private void bindCategories() 
        {
            this.cmbCategory.Refresh();
        }
    }
}
