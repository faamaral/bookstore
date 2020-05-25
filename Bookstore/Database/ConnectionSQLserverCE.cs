using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Configuration;

namespace Bookstore.Database
{
    class ConnectionSQLserverCE
    {
        public SqlCeConnection objConnection = new SqlCeConnection(ConfigurationManager.ConnectionStrings["bookstoreDB"].ToString().Trim());

        public ConnectionSQLserverCE()
        {
            
        }

        public SqlCeConnection openDB()
        {
            try
            {
                if (objConnection.State == System.Data.ConnectionState.Closed)
                {
                    objConnection.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return objConnection;
        }

        public void closeDB()
        {
            try
            {
                if (objConnection.State == System.Data.ConnectionState.Open)
                {
                    objConnection.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
