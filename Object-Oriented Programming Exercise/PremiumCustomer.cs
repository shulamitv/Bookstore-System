using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Exercise
{
    public class PremiumCustomer : Customer
    {
        private readonly string membershipId;
        private List<Book> books;

        public PremiumCustomer(string membershipId)
        {
            this.membershipId = membershipId;
            books = new List<Book>();
        }

        public string GetName()
        {
            return membershipId;
        }

        public void BuyBook(Book book)
        {
            books.Add(book);
            double discount = book.CalculateDiscount() + book.GetPrice() * 0.05;
            Console.WriteLine("Premium Member: " + membershipId + " bought the book " + book.GetTitle() + " with a discount of " + discount);
        }

        public List<Book> GetPurchasedBooks() => books;

    }
}
