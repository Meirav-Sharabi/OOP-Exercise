using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP
{
    internal class PremiumCustomer : RegularCustomer
    {
        private string membershipId;

        public PremiumCustomer(string name, string membershipId):base(name)
        {
            this.membershipId = membershipId;
        }

        public override void BuyBook(Book book)
        {
            double discount = book.CalculateDiscount() + (book.GetPrice() * 0.05);// Additional 5% discount
            base.GetPurchasedBooks().Add(book);
            Console.WriteLine($"{base.GetName()} (Premium Member {this.membershipId}) bought {book.GetTitle()} for {book.GetPrice() - discount}");
        }

    }
}
