using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Bookstore.Database
{
    class SaleControl
    {
        BookQueries queries = new BookQueries();
        
        public DataTable showSearchSale(string isbn)
        {
            BookQueries query = new BookQueries();
            DataTable data = new DataTable();
            data = query.showDataSearch(isbn);
            return data;
        }
    }
}
