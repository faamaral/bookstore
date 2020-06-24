/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 12/05/2020
 * Hora: 22:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Bookstore.Utils;
using System.IO;

namespace Bookstore.Forms
{
	/// <summary>
	/// Description of FmDashboard.
	/// </summary>
	public partial class FmDashboard : Form
	{
		Thread th;
		FmLogin fmLogin = new FmLogin();
		public FmDashboard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
		private void pbMenuDash_Click(object sender, EventArgs e)
		{
			if (pnlVerticalMenu.Width == 250)
			{
				pnlVerticalMenu.Width = 70;
			}
			else
			{
				pnlVerticalMenu.Width = 250;
			}
		}

		private void pbCloseWindowDash_Click(object sender, EventArgs e)
		{
			File.Delete("userLogged.txt");
			Application.Exit();
		}

		int lx, ly, sw, sh;
		private void pbMaximizeWindowDash_Click(object sender, EventArgs e)
		{

			lx = this.Location.X;
			ly = this.Location.Y;
			sw = this.Size.Width;
			sh = this.Size.Height;
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;
			//this.WindowState = FormWindowState.Maximized;
			pbMaximizeWindowDash.Visible = false;
			pbDropDownDash.Visible = true;
		}

		private void pbDropDownDash_Click(object sender, EventArgs e)
		{
			this.Size = new Size(sw, sh);
			this.Location = new Point(lx,ly);
			//this.WindowState = FormWindowState.Normal;
			pbDropDownDash.Visible = false;
			pbMaximizeWindowDash.Visible = true;
		}

		private void pbMinimizeDash_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void pbLogoDash_Click(object sender, EventArgs e)
		{
			openFormInPainelContainer(new FmHomePage());
			lblTitleDashboard.Text = "Home";
			resetColors();
		}

		private string receiveUserInfo()
		{
			Stream inUser = null;
			StreamReader reader = null;
			string info = "";

			try
			{
				if (File.Exists("userLogged.txt"))
				{
					inUser = File.Open("userLogged.txt", FileMode.Open);
					reader = new StreamReader(inUser);
					info = reader.ReadToEnd();					
				}
				return info;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{

				if (reader != null)
				{
					reader.Close();
				}

				if (inUser != null)
				{
					inUser.Close();
				}

				//File.Delete("userLogged.txt");
			}
		}

		private void FmDashboard_Load(object sender, EventArgs e)
		{
			pbLogoDash_Click(null, e);
			if (receiveUserInfo() != "")
			{
				btnNickUser.Text = receiveUserInfo();
			}
			lblTitleDashboard.Text = "Home";
			resetColors();
		}

		private void resetColors()
		{
			pnlBtnSale.BackColor = pnlVerticalMenu.BackColor;
			pnlBtnProductos.BackColor = pnlVerticalMenu.BackColor;
			pnlBtnAbout.BackColor = pnlVerticalMenu.BackColor;
		}

		private void btnSale_Click(object sender, EventArgs e)
		{
			openFormInPainelContainer(new FmSale());
			lblTitleDashboard.Text = "Sale";
			resetColors();
			pnlBtnSale.BackColor = Color.White;
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			openFormInPainelContainer(new FmAbout());
			lblTitleDashboard.Text = "About";
			resetColors();
			pnlBtnAbout.BackColor = Color.White;
		}

		private void pbShutDownDash_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you really want to leave?","Alert",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				File.Delete("userLogged.txt");
				this.Close();
				th = new Thread(ReturnLogin);
				th.SetApartmentState(ApartmentState.STA);
				th.Start();
			}
		}
		private void ReturnLogin()
		{
			Application.Run(new FmLogin());
		}

		private void pnlTop_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle,0x112, 0xf012, 0);
		}

		public void openFormInPainelContainer(object formChild)
		{
			if (this.pnlContainers.Controls.Count > 0)
			{
				this.pnlContainers.Controls.RemoveAt(0);
			}
			Form fh = formChild as Form;
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.pnlContainers.Controls.Add(fh);
			this.pnlContainers.Tag = fh;
			fh.Show();
		}
		private void btnProductos_Click(object sender, EventArgs e)
		{
			openFormInPainelContainer(new FmBooks());
			lblTitleDashboard.Text = "Productos";
			resetColors();
			pnlBtnProductos.BackColor = Color.White;
		}
	}
}
