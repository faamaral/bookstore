using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Bookstore.Models
{
    public class BookstoreContext: DbContext
    {
        public BookstoreContext() : base("BookstoreDB")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<BooksStoke> BooksStoke { get; set; }
    }
}
