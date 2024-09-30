using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Exercise
{
    public class RegularCustomer : Customer
    {
        private readonly string name;
        private List<Book> books;

        public RegularCustomer(string name)
        {
            this.name = name;
            books = new List<Book>();
        }

        public string GetName() => name;

        public void BuyBook(Book book)
        {
            books.Add(book);
            Console.WriteLine(name + " bought the book " + book.GetTitle() + " by " + book.GetAuthor() + " at " + book.GetPrice() + " with a discount of " + book.CalculateDiscount());
        }

        public List<Book> GetPurchasedBooks() => books;

    }
}
