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
		crudUsers cd = new crudUsers();
		public FmRegister()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			txtNameRegister.Focus();
			txtNameRegister.Select(0,0);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		private int nickExist(string s)
		{
			if (cd.checkNick(s))
			{
				return 1;
			}
			return 0;
		}
		void PbCloseRegisterClick(object sender, EventArgs e)
		{
			this.Close();
		}


		void PbRegisterNowRegosterClick(object sender, EventArgs e)
		{
			if (txtNameRegister.Text.Equals("")||txtEmailRegister.Text.Equals("")||
			    txtPasswordRegister.Text.Equals("")||txtConfirmPassword.Text.Equals("")|| cbFunctionUser.Text.Equals("Choose a function")) {
				
				if (checkText(txtNameRegister.Text)||checkText(txtEmailRegister.Text)||checkText(txtPasswordRegister.Text)
				    ||checkText(txtConfirmPassword.Text)) {
					
					MessageBox.Show("Complete the fields correctly please!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				crudUsers usr = new crudUsers();
				if(nickExist(txtEmailRegister.Text)==1)
				{
					MessageBox.Show("Nick already existed in our system, try again with other nick");
					txtEmailRegister.Clear();
					txtEmailRegister.Focus();
				}
				else
				{
                    string funcao = cbFunctionUser.SelectedItem.ToString();

                    if (txtPasswordRegister.Text.Equals(txtConfirmPassword.Text))
                    {
                        string msg = usr.registerUsers(txtNameRegister.Text, txtEmailRegister.Text, txtPasswordRegister.Text, funcao);
                        if (msg == "Sucess!")
                        {
                            MessageBox.Show(msg, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Any Error has ocurred on register!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords aren't equals");
                    }
                }



            }
		}
		void TxtNameRegisterClick(object sender, EventArgs e)
		{
			//if(txtNameRegister.Text.Equals("TYPE HERE YOUR FULL NAME"))
			//{
			//	txtNameRegister.Clear();
			//}
		}
		void TxtEmailRegisterClick(object sender, EventArgs e)
		{
			
			
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
			//if(checkText(txtPasswordRegister.Text))
			//{
			//	txtPasswordRegister.Clear();
			//}
		}
		void TxtConfirmPasswordClick(object sender, EventArgs e)
		{
			//if(checkText(txtConfirmPassword.Text))
			//{
			//	txtConfirmPassword.Clear();
			//}
		}

		private void FmRegister_Load(object sender, EventArgs e)
		{
			cbFunctionUser.Items.Add("Administrator");
			cbFunctionUser.Items.Add("Sale Manager");
			cbFunctionUser.Items.Add("Stoke Manager");
			cbFunctionUser.Items.Add("Other");
		}

		private void cbFunctionUser_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void pbRegisterNowRegoster_MouseDown(object sender, MouseEventArgs e)
		{
			pbRegisterNowRegoster.Width = pbRegisterNowRegoster.Width - 2;
			pbRegisterNowRegoster.Width -= 2;
		}

		private void txtNameRegister_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtNameRegister.Text.Equals("TYPE HERE YOUR FULL NAME"))
			{
				txtNameRegister.Clear();
			}
		}

		private void txtNameRegister_Leave(object sender, EventArgs e)
		{
			if (txtNameRegister.Text.Equals(""))
				txtNameRegister.Text = "TYPE HERE YOUR FULL NAME";
		}

		private void txtEmailRegister_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtEmailRegister.Text.Equals("Type here your e-mail address"))
			{
				txtEmailRegister.Clear();
			}
		}

		private void txtEmailRegister_Leave(object sender, EventArgs e)
		{
			if (txtEmailRegister.Text.Equals(""))
				txtEmailRegister.Text = "Type here your e-mail address";
		}

		private void txtPasswordRegister_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtPasswordRegister.Text.Equals("Type here your password"))
			{
				txtPasswordRegister.Clear();
			}
			txtPasswordRegister.PasswordChar = '*';
		}

		private void txtPasswordRegister_Leave(object sender, EventArgs e)
		{
			if (txtPasswordRegister.Text.Equals(""))
			{
				if (txtPasswordRegister.PasswordChar.Equals('*'))
				{
					txtPasswordRegister.PasswordChar = '\0';
					txtPasswordRegister.Text = "Type here your password";
				}
				else
				{
					txtPasswordRegister.Text = "Type here your password";
				}

				//txtPassword.ResetText();

			}
		}

		private void txtConfirmPassword_Leave(object sender, EventArgs e)
		{
			if (txtConfirmPassword.Text.Equals(""))
			{
				if (txtConfirmPassword.PasswordChar.Equals('*'))
				{
					txtConfirmPassword.PasswordChar = '\0';
					txtConfirmPassword.Text = "Repeat your password";
				}
				else
				{
					txtConfirmPassword.Text = "Repeat your password";
				}

				//txtPassword.ResetText();

			}
		}

		private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtConfirmPassword.Text.Equals("Repeat your password"))
			{
				txtConfirmPassword.Clear();
			}
			txtConfirmPassword.PasswordChar = '*';
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
