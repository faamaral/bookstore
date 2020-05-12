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
	}
}
