/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 13/05/2020
 * Hora: 19:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Runtime.Remoting.Messaging;

namespace Bookstore.Database
{
	/// <summary>
	/// Description of UsersManager.
	/// </summary>
	public class UsersManager
	{
		private bool exists = false;
		private string message = "";
		ControlerUsers usr = new ControlerUsers();
		public UsersManager()
		{
		}
		private string idGenerator()
		{
			var r = new Random();
			int a = r.Next(1000, 5000);
			string hexValue = a.ToString("X");
			while (checkId(hexValue))
			{
				return idGenerator();
			}
			
			return hexValue;
		}
		
		public bool acess(string email, string password)
		{
			setExistsUser(usr.checkUser(email, password));
			
			if (!usr.getMessageControl().Equals(""))
			{
				setMessageUser(usr.getMessageControl());
			}
			return getExistsUser();
		}
		
		public string register(string name, string email, string password, string confirmPassword)
		{
			string id = idGenerator();
			usr.registerNewUser(name, email, password, confimPassword, id);
			if (usr.getExistsControl())
			{
				setExistsUser(true);
				setMessageUser(usr.getMessageControl());
			}
			return getMessageUser();
		}
		
		public void setExistsUser(bool exist)
		{
			this.exists = exist;
		}
		public bool getExistsUser()
		{
			return exists;
		}
		public void setMessageUser(string msg)
		{
			this.message = msg;
		}
		public string getMessageUser()
		{
			return message;
		}
		
		
	}
}
