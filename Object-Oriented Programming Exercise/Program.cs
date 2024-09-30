using Object_Oriented_Programming_Exercise;

Book fiction = new FictionBook("My Country", "Yael Lev", 75.5, "Classic");
Book nonFiction = new NonFictionBook("The Great child", "Natan Tal", 60.5, "History");


Customer regularCustomer = new RegularCustomer("Dan Cohen");
Customer premiumCustomer = new PremiumCustomer("123");

regularCustomer.BuyBook(fiction);
premiumCustomer.BuyBook(fiction);

regularCustomer.BuyBook(nonFiction);

Console.WriteLine("\nDan Cohen's Purchased Books:");
foreach (Book book in regularCustomer.GetPurchasedBooks())
{
    Console.WriteLine(book.GetTitle() + " by " + book.GetAuthor());
}


