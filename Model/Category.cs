using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Model
{
    public class Category
    {
        public int Id { get; set; }
        private String title;
        private String description;

        public Category(int id, string title, string description)
        {
            Id = id;
            this.title = title;
            this.description = description;
        }
    }
}
