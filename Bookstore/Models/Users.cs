using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Users
    {
        [Key]
        [MaxLength(100)]
        public string UserId { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string UserNick { get; set; }

        [MaxLength(100)]
        public string UserPassword { get; set; }

        [MaxLength(100)]
        public string UserFunction { get; set; }
    }

    public class Books
    {
        [Key]
        [MaxLength(100)]
        public string BookIsbn { get; set; }

        public int BookId { get; set; }

        [MaxLength(100)]
        public string BookTitle { get; set; }

        [MaxLength(100)]
        public string BookAuthor { get; set; }

        public decimal BookYear { get; set; }  // numérico(18,2) mapeado como decimal

        [MaxLength(100)]
        public string BookEditora { get; set; }

        [MaxLength(100)]
        public string BookGenre { get; set; }

        public int BookAmount { get; set; }

        public float BookPrice { get; set; }  // real
    }

    public class BooksStoke
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(100)]
        public string BookIsbn { get; set; }

        [MaxLength(100)]
        public string BookTitle { get; set; }

        [MaxLength(100)]
        public string BookAuthor { get; set; }

        public int BookYear { get; set; }

        [MaxLength(100)]
        public string BookEditora { get; set; }

        [MaxLength(100)]
        public string BookGenre { get; set; }

        public int BookAmount { get; set; }

        public decimal BookPrice { get; set; }
    }
}
