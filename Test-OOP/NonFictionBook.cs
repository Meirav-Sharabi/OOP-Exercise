using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP
{
    internal class NonFictionBook : Book
    {
        private string subject;

        public NonFictionBook(string title, string author, double price, string subject)
            : base(title, author, price)
        {
            this.subject = subject;
        }

        public override double CalculateDiscount()
        {
            return price * 0.05;// 5% discount for non-fiction books
        }
    }
}
