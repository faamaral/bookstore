/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 13/05/2020
 * Hora: 19:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System.Security.Cryptography;
using System;
using System.Linq;
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
		ControleUsers2 usr = new ControleUsers2();

		public UsersManager()
		{
		}

		private string idGenerator()
		{
			var r = new Random();
			int a = r.Next(1000, 5000);
			string hexValue = a.ToString("X");
			if (usr.checkId2(hexValue))
			{
				return idGenerator();
			}
			
			return hexValue;
		}

		public string Get8Digits()
		{
			var bytes = new byte[4];
			var rng = RandomNumberGenerator.Create();
			rng.GetBytes(bytes);
			uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
			return String.Format("{0:D8}", random);
		}

		public bool acess(string email, string password)
		{
			setExistsUser(usr.checkUser2(email, password));
			
			if (!usr.getMessage2().Equals(""))
			{
				setMessageUser(usr.getMessage2());
			}
			return getExistsUser();
		}
		
		public string register(string name, string email, string password, string confirmPassword)
		{
			//string id = idGenerator();
			//string id = Get8Digits();
			string id = "1234ABCD";
			usr.registerNewUser2(id, name, email, password, confirmPassword);
			if (usr.getExist2())
			{
				setExistsUser(true);
				setMessageUser(usr.getMessage2());
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
