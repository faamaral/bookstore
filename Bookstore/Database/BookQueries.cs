using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;

namespace Bookstore.Database
{
    public class BookQueries
    {
        private ConnectionSQLserverCE conn = new ConnectionSQLserverCE();
        SqlCeDataReader read;
        DataTable dataTable = new DataTable();
        SqlCeCommand command;

        public DataTable showData()
        {
            try
            {
                conn.openDB();
                string query = "SELECT * FROM books_stoke";
                command = new SqlCeCommand(query, conn.objConnection);
                read = command.ExecuteReader();
                dataTable.Load(read);
                conn.closeDB();
                return dataTable;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public void insertNewBook(string isbn, string title, string author, int year, string editora, string genre, int amount, decimal price)
        {
            try
            {
                string query = "insert into books_stoke(book_isbn, book_title, book_author, book_year, book_editora, book_genre, book_amount, book_price)" +
                    "values ('" + isbn + "','" + title + "', '" + author + "', " + year + ", '" + editora + "', '" + genre + "', " + amount + ", " + price + ")";
                conn.openDB();
                command = new SqlCeCommand(query, conn.objConnection);
                command.ExecuteNonQuery();

                conn.closeDB();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
