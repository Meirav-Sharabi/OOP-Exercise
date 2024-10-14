using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP
{
    internal interface ICustomer
    {
        string GetName();
        void BuyBook(Book book);
        List<Book> GetPurchasedBooks();
    }
}
