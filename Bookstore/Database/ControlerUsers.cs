/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 13/05/2020
 * Hora: 16:17
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Bookstore.Database
{
	/// <summary>
	/// Description of ControlerUsers.
	/// </summary>
	public class ControlerUsers
	{
		private bool exists = false;
		private string message = "";
		SQLiteCommand sqlCom = new SQLiteCommand();
		ConnectionDB conn = new ConnectionDB();
		SQLiteDataReader dr;
		
		public ControlerUsers()
		{
			
		}
		
		public bool checkId(string id)
		{
			sqlCom.CommandText = "SELECT * FROM users WHERE id = @id";
			sqlCom.Parameters.AddWithValue("@id", id);
			try
			{
				sqlCom.Connection = conn.connectionDatabase();
				dr = sqlCom.ExecuteReader();
				if (dr.HasRows)
				{
					setExistsControl(true);
				}
				conn.disconnectDatabase();
				dr.Close();
			}
			catch(Exception)
			{
				setMessageControl("An error ocurred with the database");	
			}
			return getExistsControl();
		}
		
		public bool checkUser(string email, string password)
		{
			sqlCom.CommandText = "SELECT * FROM users WHERE email = @email AND password = @password";
			sqlCom.Parameters.AddWithValue("@email", email);
			sqlCom.Parameters.AddWithValue("@password", password);
			try
			{
				sqlCom.Connection = conn.connectionDatabase();
				dr = sqlCom.ExecuteReader();
				if (dr.HasRows)
				{
					setExistsControl(true);
				}
				conn.disconnectDatabase();
				dr.Close();
			}
			catch(SQLiteException)
			{
				setMessageControl("An error ocurred with the database");
			}
			return getExistsControl();
		}
		
		public string registerNewUser(string name, string email, string password, string confimPassword, string id)
		{
			setExistsControl(false);
			if(password.Equals(confimPassword))
			{
				sqlCom.CommandText = "INSERT INTO users VALUES (@id, @name, @email, @password)";
				sqlCom.Parameters.AddWithValue("@id", id);
				sqlCom.Parameters.AddWithValue("@name", name);
				sqlCom.Parameters.AddWithValue("@email", email);
				sqlCom.Parameters.AddWithValue("@password", password);
				
				try
				{
					sqlCom.Connection = conn.connectionDatabase();
					sqlCom.ExecuteNonQuery();
					conn.disconnectDatabase();
					setMessageControl("User successfully registred");
					setExistsControl(true);
				}
				catch(Exception)
				{
					setMessageControl("An error ocurred with the database");
				}
			}
			else
			{
				setMessageControl("Password do not match!");
			}
			return getMessageControl();
			
		}

		public void setExistsControl(bool exist)
		{
			this.exists = exist;
		}

		public bool getExistsControl()
		{
			return this.exists;
		}

		public void setMessageControl(string msg)
		{
			this.message = msg;
		}
		
		public string getMessageControl()
		{
			return this.message;
		}
	}
}
