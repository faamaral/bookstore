using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Bookstore.Database
{
    public class BookControl
    {
        private BookQueries bookQuery = new BookQueries();

        public DataTable showBooks()
        {
            DataTable data = new DataTable();
            data = bookQuery.showData();
            return data;
        }

        public void insertBooksControl(string isbn, string title, string author, string year, string editora, string genre, string amount, string price)
        {
            bookQuery.insertNewBook(isbn, title, author, Convert.ToInt32(year), editora, genre, Convert.ToInt32(amount), Convert.ToDecimal(price));
        }
    }
}
