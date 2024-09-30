using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Exercise
{
    public interface Customer
    {
        string GetName();

        void BuyBook(Book book);

        List<Book> GetPurchasedBooks();

    }
}
