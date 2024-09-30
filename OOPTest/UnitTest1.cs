using Object_Oriented_Programming_Exercise;

namespace OOPTest
{
    public class Tests
    {
        private Customer regularCustomer;
        private Customer premiumCustomer;
        private Book fiction;
        private Book nonFiction;

        [SetUp]
        public void Setup()
        {
            fiction = new FictionBook("My Country", "Yael Lev", 75.5, "Classic");
            nonFiction = new NonFictionBook("The Great Child", "Natan Tal", 60.5, "History");

            regularCustomer = new RegularCustomer("Dan Cohen");
            premiumCustomer = new PremiumCustomer("123");
        }


        [Test]
        public void RegularCustomerCanBuyMultipleBooks()
        {
            // Regular customer buys both fiction and non-fiction books
            regularCustomer.BuyBook(fiction);
            regularCustomer.BuyBook(nonFiction);

            // Get the purchased books
            List<Book> purchasedBooks = regularCustomer.GetPurchasedBooks();

            // Assert that both books were purchased successfully
            Assert.AreEqual(2, purchasedBooks.Count);
            Assert.AreEqual(fiction.GetTitle(), purchasedBooks[0].GetTitle());
            Assert.AreEqual(nonFiction.GetTitle(), purchasedBooks[1].GetTitle());
        }

        [Test]
        public void PremiumCustomerCanBuyMultipleBooks()
        {
            // premium customer buys both fiction and non-fiction books
            premiumCustomer.BuyBook(fiction);
            premiumCustomer.BuyBook(nonFiction);

            // Get the purchased books
            List<Book> purchasedBooks = premiumCustomer.GetPurchasedBooks();

            // Assert that both books were purchased successfully
            Assert.AreEqual(2, purchasedBooks.Count);
            Assert.AreEqual(fiction.GetTitle(), purchasedBooks[0].GetTitle());
            Assert.AreEqual(nonFiction.GetTitle(), purchasedBooks[1].GetTitle());
        }

    }
}
