using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP
{
    internal abstract class Book
    {
        private string title;
        private string author;
        protected double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public double GetPrice()
        {
            return price;
        }

        public abstract double CalculateDiscount();
    }
}
