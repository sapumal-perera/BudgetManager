using BudgetManager.Model;
using System;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpenseAppLogIn(object sender, EventArgs e)
        {
            String username = this.txtUserName.Text;
            String password = this.txtPassword.Text;
            UserProfile userprofile = new UserProfile();
            Boolean result = userprofile.LoginUser(username, password);

            if (result == true)
            {
                HomePage homePage = new HomePage();
                homePage.currentUser = username;
                homePage.Show();
                this.Hide();
            }


        }
    }
}
