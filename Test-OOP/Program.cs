using Test_OOP;

class Bookstore
{
    static void Main(string[] args)
    {
        // Creating book instances
        Book fiction = new FictionBook("The Hobbit", "J.R.R. Tolkien", 20.00, "Fantasy");
        Book nonFiction = new NonFictionBook("Sapiens", "Y.N", 25.00, "History");

        // Creating customer instances
        ICustomer regularCustomer = new RegularCustomer("Dan");
        ICustomer premiumCustomer = new PremiumCustomer("Yoav", "MEM12345");

        // Simulate purchases
        regularCustomer.BuyBook(fiction);
        premiumCustomer.BuyBook(nonFiction);

        // Display purchased books
        Console.WriteLine($"{regularCustomer.GetName()} purchased books:");
        foreach (var book in regularCustomer.GetPurchasedBooks())
        {
            Console.WriteLine($"- {book.GetTitle()} by {book.GetAuthor()}");
        }

        Console.WriteLine($"{premiumCustomer.GetName()} purchased books:");
        foreach (var book in premiumCustomer.GetPurchasedBooks())
        {
            Console.WriteLine($"- {book.GetTitle()} by {book.GetAuthor()}");
        }
    }
}
