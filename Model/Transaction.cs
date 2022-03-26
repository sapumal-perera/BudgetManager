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
        public bool IsRecurring { get => isRecurring; set => isRecurring = value; }
        public double Ammount { get => ammount; set => ammount = value; }

        private String title;
        private String description;
        private Double ammount;
        private DateTime date;
        private String category;
        private String type;
        private Boolean isRecurring;

        public Transaction(string title, string description, double ammount, DateTime date, string category, string type, bool isRecurring)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.category = category;
            this.type = type;
            this.isRecurring = isRecurring;
            this.Ammount = ammount;

        }
    }
}
