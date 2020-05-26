using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Security.Cryptography;
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
        private string result = "none";

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

        public bool checkId(string user_id)
        {
            bool exist = false;
            string str = "SELECT * FROM users WHERE user_id = @user_id";
            try
            {
                conn.openDB();
                sql.CommandText = str;
                data = new SqlCeDataAdapter(str, conn.objConnection);
                data.SelectCommand.Parameters.AddWithValue("@user_id", user_id);
                data.Fill(users);
                data.Dispose();
                conn.closeDB();

                if (users.Rows.Count == 0)
                {
                    return exist;
                }
                else
                {
                    exist = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            return exist;
        }

        public bool checkNick(string user_nick)
        {
            bool exist = false;
            string str = "SELECT * FROM users WHERE user_nick = @user_nick";
            try
            {
                conn.openDB();
                sql.CommandText = str;
                data = new SqlCeDataAdapter(str, conn.objConnection);
                data.SelectCommand.Parameters.AddWithValue("@user_nick", user_nick);
                data.Fill(users);
                data.Dispose();
                conn.closeDB();

                if (users.Rows.Count == 0)
                {
                    return exist;
                }
                else
                {
                    exist = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            return exist;
        }

        public string Get8Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return String.Format("{0:D8}", random);
        }

        public string addId()
        {
            string id = Get8Digits();
            if (checkId(id))
            {
                id = Get8Digits();
            }
            return id;
        }

        public string registerUsers(string user_name, string user_nick, string user_password, string user_function)
        {
            string user_id = this.addId();
            try
            {
                conn.openDB();
                

                string query = "INSERT INTO users VALUES(@user_id, @user_name, @user_nick, @user_password, @user_function)";
                SqlCeCommand sql = new SqlCeCommand(query, conn.objConnection);
                //sql.CommandText = query;
                sql.Parameters.AddWithValue("@user_id", user_id);
                sql.Parameters.AddWithValue("@user_name", user_name);
                sql.Parameters.AddWithValue("@user_nick", user_nick);
                sql.Parameters.AddWithValue("@user_password", user_password);
                sql.Parameters.AddWithValue("@user_function", user_function);
                sql.ExecuteNonQuery();

                conn.closeDB();
                setResult("Sucess!");



            }
            catch (Exception e)
            {
                throw e;
            }

            return getResult();
        }

        public void setResult(string v)
        {
            result = v;
        }

        public string getResult()
        {
            return result;
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
