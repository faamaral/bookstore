/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 11/05/2020
 * Hora: 20:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Bookstore.Database;

namespace Bookstore.Forms
{
	/// <summary>
	/// Description of FmRegister.
	/// </summary>
	public partial class FmRegister : Form
	{
		public FmRegister()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PbCloseRegisterClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void PbRegisterNowRegosterClick(object sender, EventArgs e)
		{
			if (txtNameRegister.Text.Equals("")||txtEmailRegister.Text.Equals("")||
			    txtPasswordRegister.Text.Equals("")||txtConfirmPassword.Text.Equals("")) {
				
				if (checkText(txtNameRegister.Text)||checkText(txtEmailRegister.Text)||checkText(txtPasswordRegister.Text)
				    ||checkText(txtConfirmPassword.Text)) {
					
					MessageBox.Show("Complete the fields correctly please!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				UsersManager usr = new UsersManager();
				string msg = usr.register(txtNameRegister.Text, txtEmailRegister.Text, txtPasswordRegister.Text, txtConfirmPassword.Text);
				if (usr.getExistsUser())
				{
					MessageBox.Show(msg, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show(msg);
				}
			}
		}
		void TxtNameRegisterClick(object sender, EventArgs e)
		{
			if(txtNameRegister.Text.Equals("TYPE HERE YOUR FULL NAME"))
			{
				txtNameRegister.Clear();
			}
		}
		void TxtEmailRegisterClick(object sender, EventArgs e)
		{
			
			if(txtEmailRegister.Text.Equals("Type here your e-mail address"))
			{
				txtEmailRegister.Clear();
			}
		}
		
		
		
		private bool checkText(string msg)
		{
			if(msg.Equals("TYPE HERE YOUR FULL NAME"))
			{
				return true;
			}
			else if (msg.Equals("Type here your e-mail address"))
			{
				return true;
			}
			else if (msg.Equals("Type here your password"))
			{
				return true;
			}
			else if (msg.Equals("Repeat your password"))
			{
				return true;
			}
				
			return false;
		}
		void TxtPasswordRegisterClick(object sender, EventArgs e)
		{
			if(checkText(txtPasswordRegister.Text))
			{
				txtPasswordRegister.Clear();
			}
		}
		void TxtConfirmPasswordClick(object sender, EventArgs e)
		{
			if(checkText(txtConfirmPassword.Text))
			{
				txtConfirmPassword.Clear();
			}
		}
		
		
		
//		void TxtNameRegisterEnter(object sender, EventArgs e)
//		{
//			if(checkText(txtNameRegister.Text))
//			{
//				txtNameRegister.Text += "";
//			}
//		}
		
		
	}
}
