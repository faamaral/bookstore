using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Bookstore.Database
{
    public class BookControl
    {
        BookQueries bookQuery = new BookQueries();

        public DataTable showBooks()
        {
            BookQueries bookQuery = new BookQueries();
            DataTable data = new DataTable();
            data = bookQuery.showData();
            return data;
        }

        public void insertBooksControl(string isbn, string title, string author, string year, string editora, string genre, string amount, string price)
        {
            bookQuery.insertNewBook(isbn, title, author, Convert.ToInt32(year), editora, genre, Convert.ToInt32(amount), Convert.ToDecimal(price));
        }

        public string updateDataControl(string id, string isbn, string title, string author, string year, string editora, string genre, string amount, string price)
        {
            string str = bookQuery.updateData(Convert.ToInt32(id), isbn, title, author, Convert.ToInt32(year), editora, genre, Convert.ToInt32(amount), Convert.ToDecimal(price));
            return str;
        }

        public bool checkISBNControl(string v)
        {
            if(bookQuery.checkISBN(v)== false)
            {
                // ainda não existe no banco de dados
                return false;
            }
            else
            {
                //Existe no banco de dados
                return true;
            }
        }
    }
}
