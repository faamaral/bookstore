using System.Data.SQLite;
using System;
using System.Data;

namespace Bookstore.Database
{
    class connectionSQLITE
    {
        public SQLiteConnection conn = new SQLiteConnection("Data Source = dbBookstore.db");
        public void connectToDb()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void disconnectToDB()
        {
            if(conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    
}
