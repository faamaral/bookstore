using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Configuration;
using System.Reflection;
using System.IO;

namespace Bookstore.Database
{
    class ConnectionSQLserverCE
    {
        //string startPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        //string conSTR = Path.Combine(startPath, "bookstoreDB.sdf");
        //public SqlCeConnection objConnection = new SqlCeConnection("Data Source ="+Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "bookstoreDB.sdf"));
        //public SqlCeConnection objConnection = new SqlCeConnection(ConfigurationManager.ConnectionStrings["bookstoreDB"].ToString().Trim());

        public SqlCeConnection objConnection = new SqlCeConnection("Data Source = bookstoreDB.sdf");
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
