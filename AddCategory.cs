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
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label label4;
        public Category newcategory;
        public String type;
        public AddCategory(String type)
        {
            this.type = type;
            InitializeComponent();
        }

        /// <summary>
        ///  adding new category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewCategory(object sender, EventArgs e)
        {
            String title = this.txtTitle.Text;
            String description = this.txtDescription.Text;
            String type = this.cmbType.Text;
            Double budget = type == "expense" ? Convert.ToDouble(this.txtBudget.Text) : 0;
            newcategory = new Model.Category(title: title, description: description, budget: budget, type: type, currentTotal: 0);
            this.Hide();
        }

        /// <summary>
        /// label of budget input field generate
        /// </summary>
        private void GenerateBudgetInputLabel()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(140, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Budget";
            this.Controls.Add(this.label4);
            this.label4.Visible = true;
        }

        /// <summary>
        ///  txtBudget. budget input field generate
        /// </summary>
        private void GenerateBudgetInput() {
            GenerateBudgetInputLabel();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudget.Location = new System.Drawing.Point(198, 250);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(230, 24);
            this.txtBudget.TabIndex = 17;
            this.Controls.Add(this.txtBudget);
            this.txtBudget.Visible = true;
        }

        /// <summary>
        /// on add category page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoadAddCategory(object sender, EventArgs e)
        {
            showBudgetTextBox();
        }

        /// <summary>
        /// on transction type canges
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTypeChanged(object sender, EventArgs e)
        {
            this.type = this.cmbType.Text;
            showBudgetTextBox();

        }

        /// <summary>
        /// decide to show or hide budget text box
        /// </summary>
        private void showBudgetTextBox()
        {
            if (this.type == "expense")
            {
                GenerateBudgetInput();
               // this.cmbType.SelectedText = "expense";
            }
            else
            {
                this.Controls.Remove(this.txtBudget);
                this.Controls.Remove(this.label4);
              //  this.cmbType.SelectedText = "income";
            }
        }
    }
}
