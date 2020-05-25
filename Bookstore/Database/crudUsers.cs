using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;

namespace Bookstore.Database
{
    class crudUsers
    {
        private ConnectionSQLserverCE conn = new ConnectionSQLserverCE();
        private SqlCeCommand sql = new SqlCeCommand();
        private SqlCeDataReader dr;
        SqlCeDataAdapter data;
        DataTable users = new DataTable();
        
        private bool has = false;

        public bool checkUsers(string user_nick, string user_password)
        {
            string str = "SELECT * FROM users WHERE user_nick = @user_nick AND  user_password = @user_password";
            try
            {
                conn.openDB();
                sql.CommandText = str;
                data = new SqlCeDataAdapter(str, conn.objConnection);
                data.SelectCommand.Parameters.AddWithValue("@user_nick", user_nick);
                data.SelectCommand.Parameters.AddWithValue("@user_password", user_password);
                data.Fill(users);
                data.Dispose();
                conn.closeDB();
                
                if (users.Rows.Count == 0)
                {
                    return getHas();
                }
                else
                {
                    setHas(true);
                }

            }
            catch(Exception e)
            {
                throw e;
            }
            return getHas();
        }

        public void setHas(bool v)
        {
            this.has = v;
        }

        public bool getHas()
        {
            return has;
        }
    }
}
