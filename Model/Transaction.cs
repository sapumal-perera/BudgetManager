using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager.Model
{
    public class Transaction
    {

        public int Id { get; set; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Category { get => category; set => category = value; }
        public string Type { get => type; set => type = value; }

        private String title;
        private String description;
        private DateTime date;
        private String category;
        private String type;

        public Transaction(string title, string description, DateTime date, string category, string type)
        {
            this.Title = title;
            this.description = description;
            this.date = date;
            this.category = category;
            this.type = type;
        }

    }
}
