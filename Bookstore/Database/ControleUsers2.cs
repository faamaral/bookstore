using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Bookstore.Database
{
    class ControleUsers2
    {
        connectionSQLITE con = new connectionSQLITE();
        private bool exist2 = false;
        private string message2 = "";

       
        public bool checkId2(string id)
        {
            con.connectToDb();
            try
            {
                
                string query = "SELECT * FROM users WHERE id= '" + id + "'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(query, con.conn);
                DataTable users = new DataTable();
                data.Fill(users);
                if (users.Rows.Count < 0)
                {
                    setMessage2("user not found");
                    return getExist2();
                }
                else
                {
                    setExist2(true);
                }
                con.disconnectToDB();
            }
            catch (Exception)
            {
                setMessage2("An error ocurred with the database");
            }

            return getExist2();

        }

        public bool checkUser2(string user, string password)
        {
            try
            {
                con.connectToDb();
                string query = "SELECT * FROM users WHERE email='"+user+"' AND password='"+password+"'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(query, con.conn);
                DataTable users = new DataTable();
                data.Fill(users);
                if(users.Rows.Count < 0)
                {
                    setMessage2("user not found");
                    return getExist2(); 
                }
                else
                {
                    setExist2(true);
                }
                con.disconnectToDB();
            }
            catch (Exception e)
            {
                setMessage2("An error ocurred with the database");
            }

            return getExist2();
        }

        public string registerNewUser2(string id, string name, string user, string password, string repeatPassword)
        {
            setExist2(false);
            if (password.Equals(repeatPassword))
            {
                try
                {
                    con.connectToDb();
                    string query = "INSERT INTO user(id, name, email, password) VALUES('" + id + "', '" + name + "', '" + user + "', '" + password + "')";
                
                    SQLiteCommand cmd = new SQLiteCommand(query, con.conn);
                    cmd.ExecuteNonQuery();

                    con.disconnectToDB();
                    setExist2(true);
                    setMessage2("User successfully registred");

                }
                catch (Exception e)
                {
                    setMessage2("An error ocurred with the database");
                }
            }
            return getMessage2();
        }

        public void setMessage2(string msg)
        {
            this.message2 = msg;
        }

        public string getMessage2()
        {
            return this.message2;
        }

        public void setExist2(bool par)
        {
            this.exist2 = par;
        }
        public bool getExist2()
        {
            return this.exist2;
        }


    }
}
