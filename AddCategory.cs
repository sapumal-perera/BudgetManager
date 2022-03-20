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
    public partial class AddCategory : Form
    {
        public Category newcategory;
        public String type;
        public AddCategory(String type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
            String title = this.txtTitle.Text;
            String description = this.txtDescription.Text;
            String type = this.cmbType.Text;
            String budget = this.txtBudget.Text;
            newcategory = new Model.Category(title: title, description: description, budget: budget, type: type);
            this.Hide();
        }
    }
}
