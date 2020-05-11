/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 10/05/2020
 * Hora: 20:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bookstore.Forms
{
	/// <summary>
	/// Description of FmLogin.
	/// </summary>
	public partial class FmLogin : Form
	{
		public FmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
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
		void PbExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
