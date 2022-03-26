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
        public ObservableCollection<Category> expenseCategories = new ObservableCollection<Category>();
        public ObservableCollection<Category> incomeCategories = new ObservableCollection<Category>();
        public event EventHandler<Category> RecordAdded;


        /// <summary>
        /// parametered constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="categories"></param>
        public AddTransaction(String type, ObservableCollection<Category> categories)
        {   this.type = type;
            if(this.type == "income")
            {
                this.incomeCategories = categories;
            } else if (this.type == "expense")
            {
                this.expenseCategories = categories;
            }
            InitializeComponent();
        }


        /// <summary>
        /// handle create transaction 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTransaction(object sender, EventArgs e)
        {
           String title = this.txtTitle.Text;
           String description = this.txtNote.Text;
           String category = this.cmbCategory.Text;
           String type = this.type;
           DateTime date = this.dateTimePicker1.Value.Date;
            Boolean isRecurring = this.chkRecurring.Checked;
            Double ammount = Convert.ToDouble(this.txtAmmount.Text);
            newTransaction = new Model.Transaction(title: title, description: description,ammount:ammount, date: date,
                category: category, type: type, isRecurring: isRecurring);
           this.Hide();
        }

        /// <summary>
        /// hande add new category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewCategory(object sender, EventArgs e)
        {
           AddCategory addCategoryView = new AddCategory(this.type);
            addCategoryView.ShowDialog();
            category = addCategoryView.newcategory;
            if(category != null)
            {
                this.expenseCategories.Add(category);
            }
      
            var handler = RecordAdded;
            if (RecordAdded != null)
            {
                RecordAdded.Invoke(this, category);
            }
            this.bindCategories();
            this.Refresh();
           
        }

        /// <summary>
        /// handle add tranaction page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTransaction_load(object sender, EventArgs e)
        {this.lblType.Text = this.type.ToString();
            this.bindCategories();
        }

        /// <summary>
        /// bind categories to combo boxes
        /// </summary>
        private void bindCategories()
        {
            this.cmbCategory.DataSource = null;
            if (this.type == "expense")
            {
                this.cmbCategory.DataSource = this.expenseCategories;
            }
            else if (this.type == "income")
            {
                this.cmbCategory.DataSource = this.incomeCategories;
            }
            this.cmbCategory.DisplayMember = "Title";
            this.cmbCategory.Refresh();
        }
    }
}
