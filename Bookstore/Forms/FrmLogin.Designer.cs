/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 10/05/2020
 * Hora: 16:25
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Bookstore.Frames
{
	partial class FrmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pbMain;
		private System.Windows.Forms.PictureBox pbUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.PictureBox pbIconEmail;
		private System.Windows.Forms.PictureBox pbIconPassoword;
		private System.Windows.Forms.TextBox txtPassword;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.pbMain = new System.Windows.Forms.PictureBox();
			this.pbUser = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pbIconEmail = new System.Windows.Forms.PictureBox();
			this.pbIconPassoword = new System.Windows.Forms.PictureBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconPassoword)).BeginInit();
			this.SuspendLayout();
			// 
			// pbMain
			// 
			this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
			this.pbMain.Location = new System.Drawing.Point(1, -112);
			this.pbMain.Name = "pbMain";
			this.pbMain.Size = new System.Drawing.Size(439, 663);
			this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMain.TabIndex = 0;
			this.pbMain.TabStop = false;
			// 
			// pbUser
			// 
			this.pbUser.BackColor = System.Drawing.Color.Transparent;
			this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
			this.pbUser.Location = new System.Drawing.Point(432, 24);
			this.pbUser.Name = "pbUser";
			this.pbUser.Size = new System.Drawing.Size(110, 65);
			this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbUser.TabIndex = 1;
			this.pbUser.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("ArtBrush", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label1.Location = new System.Drawing.Point(415, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "start managing our bookstore right now!";
			// 
			// pbIconEmail
			// 
			this.pbIconEmail.BackColor = System.Drawing.Color.Transparent;
			this.pbIconEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbIconEmail.Image")));
			this.pbIconEmail.Location = new System.Drawing.Point(326, 141);
			this.pbIconEmail.Name = "pbIconEmail";
			this.pbIconEmail.Size = new System.Drawing.Size(325, 41);
			this.pbIconEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconEmail.TabIndex = 7;
			this.pbIconEmail.TabStop = false;
			// 
			// pbIconPassoword
			// 
			this.pbIconPassoword.BackColor = System.Drawing.Color.Transparent;
			this.pbIconPassoword.Image = ((System.Drawing.Image)(resources.GetObject("pbIconPassoword.Image")));
			this.pbIconPassoword.Location = new System.Drawing.Point(326, 188);
			this.pbIconPassoword.Name = "pbIconPassoword";
			this.pbIconPassoword.Size = new System.Drawing.Size(325, 41);
			this.pbIconPassoword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconPassoword.TabIndex = 8;
			this.pbIconPassoword.TabStop = false;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.DarkGray;
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEmail.ForeColor = System.Drawing.Color.LightGray;
			this.txtEmail.Location = new System.Drawing.Point(415, 153);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(194, 20);
			this.txtEmail.TabIndex = 9;
			this.txtEmail.Text = "Type here your e-mail address";
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.DarkGray;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.ForeColor = System.Drawing.Color.LightGray;
			this.txtPassword.Location = new System.Drawing.Point(415, 197);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(194, 20);
			this.txtPassword.TabIndex = 10;
			this.txtPassword.Text = "Type here your password";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(663, 426);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.pbIconPassoword);
			this.Controls.Add(this.pbIconEmail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbUser);
			this.Controls.Add(this.pbMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconPassoword)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
