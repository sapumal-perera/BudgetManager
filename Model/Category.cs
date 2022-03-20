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
        public string Description { get => description; set => description = value; }
        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
        public string Budget { get => budget; set => budget = value; }

        private String title;
        private String description;
        private String type;
        private String budget;

        public Category(string title, string description, string type, string budget)
        {
            this.title = title;
            this.description = description;
            this.type = type;
            this.budget = budget;
        }
    }
}
