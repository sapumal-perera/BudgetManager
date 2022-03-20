using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Model
{
    public class UserProfile
    {
        List<String> userList = new List<String> {"Steve", "Bill"};
        public Boolean LoginUser(string username, string password)
        {
           if(userList.Contains(username) && password.Equals("123"))
            {
                return true;
            } else
            {
               return false;
            }
        }
    }
}
