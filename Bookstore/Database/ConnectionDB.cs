/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 13/05/2020
 * Hora: 14:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data.SQLite;
using System.Data;

namespace Bookstore.Database
{
	/// <summary>
	/// Description of ConnectionDB.
	/// </summary>
	public class ConnectionDB
	{
		private static SQLiteConnection connection;
		public ConnectionDB()
		{
			// string de conexão com o banco de dados
			connection = new SQLiteConnection("Data Source = dbBookstore.db");
		}
		
		// metodo com finalidade de fazer a abertura do banco de dados
		public SQLiteConnection connectionDatabase()
		{
			// verifica se a conexão esta fechada, caso esteja a conexão será aberta
			if(connection.State == System.Data.ConnectionState.Closed)
			{
				connection.Open();
			}
			return connection;
		}
		public void disconnectDatabase()
		{
			if(connection.State == System.Data.ConnectionState.Open)
			{
				connection.Close();
			}
		}
		
	}
}
