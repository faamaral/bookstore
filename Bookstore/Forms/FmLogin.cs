/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 10/05/2020
 * Hora: 20:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using Bookstore.Database;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Bookstore.Forms
{
	/// <summary>
	/// Description of FmLogin.
	/// </summary>
	public partial class FmLogin : Form
	{
		FmRegister form = new FmRegister();
		UsersManager manager = new UsersManager();
		crudUsers usr = new crudUsers();
		public string str = "";
		Thread th;
		public FmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			// Inicia o form no centro da tela de login
			form.StartPosition = FormStartPosition.CenterParent;
//			removeBackground(pbEmail, pbIconEmail);
//			removeBackground(pbPassword, pbIconPassword);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
//		void removeBackground(PictureBox pb, PictureBox pb2)
//		{
//			var pos = this.PointToScreen(pb2.Location);
//			pos = pb.PointToClient(pos);
//			pb2.Parent = pb;
//			pb2.Location = pos;
//			pb2.BackColor = Color.Transparent;
//			
//		}

		private void initFrame()
		{
			Application.Run(new FmDashboard());
		}
		void PbExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void LblRegisterClick(object sender, EventArgs e)
		{
			lblRegister.ForeColor = Color.DarkMagenta;
			form.ShowDialog();
			lblRegister.ForeColor = Color.FromArgb(255, 128, 0);
			
		}
		void PbCloseLoginClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void LblRegisterMouseHover(object sender, EventArgs e)
		{
			lblRegister.ForeColor = Color.DarkMagenta;
		}
		void LblRegisterMouseLeave(object sender, EventArgs e)
		{
			lblRegister.ForeColor = Color.FromArgb(255, 128, 0);
		}
		void PictureBox5MouseHover(object sender, EventArgs e)
		{
	
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			if (txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
			{
				MessageBox.Show("Todos os campos devem estar preenchidos!!!");
				txtEmail.Focus();
			}
			else
			{
				usr.checkUsers(txtEmail.Text, txtPassword.Text);
				if (usr.getHas())
				{
						str = txtEmail.Text;
						this.Close();
						th = new Thread(initFrame);
						th.SetApartmentState(ApartmentState.STA);
						th.Start();
				}
				else
				{
						MessageBox.Show("Usuario Invalido!! \nOu senha incorreta");
				}
			}
		}
	}
}
