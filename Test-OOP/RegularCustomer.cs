using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP
{
    internal class RegularCustomer : ICustomer
    {
        private string name;
        private List<Book> purchasedBooks;

        public RegularCustomer(string name)
        {
            this.name = name;
            purchasedBooks = new List<Book>();
        }

        public string GetName()
        {
            return name;
        }

        public virtual void BuyBook(Book book)
        {
            purchasedBooks.Add(book);
            Console.WriteLine($"{name} bought {book.GetTitle()} for {book.GetPrice() - book.CalculateDiscount()}");
        }

        public List<Book> GetPurchasedBooks()
        {
            return purchasedBooks;
        }

    }
}
