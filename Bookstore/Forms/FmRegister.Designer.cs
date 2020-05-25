/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 11/05/2020
 * Hora: 20:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Bookstore.Forms
{
	partial class FmRegister
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pbBGRegister;
		private System.Windows.Forms.TextBox txtEmailRegister;
		private System.Windows.Forms.TextBox txtNameRegister;
		private System.Windows.Forms.PictureBox pbPasswordRegister;
		private System.Windows.Forms.PictureBox pbEmailRegister;
		private System.Windows.Forms.PictureBox pbIconUserRegister;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.TextBox txtPasswordRegister;
		private System.Windows.Forms.PictureBox pbRegisterNowRegoster;
		private System.Windows.Forms.PictureBox pbCloseRegister;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pbIconPassword;
		private System.Windows.Forms.PictureBox pbIconEmail;
		private System.Windows.Forms.PictureBox pictureBox4;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmRegister));
			this.pbBGRegister = new System.Windows.Forms.PictureBox();
			this.txtEmailRegister = new System.Windows.Forms.TextBox();
			this.txtNameRegister = new System.Windows.Forms.TextBox();
			this.pbPasswordRegister = new System.Windows.Forms.PictureBox();
			this.pbEmailRegister = new System.Windows.Forms.PictureBox();
			this.pbIconUserRegister = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.txtPasswordRegister = new System.Windows.Forms.TextBox();
			this.pbRegisterNowRegoster = new System.Windows.Forms.PictureBox();
			this.pbCloseRegister = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pbIconPassword = new System.Windows.Forms.PictureBox();
			this.pbIconEmail = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbBGRegister)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPasswordRegister)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEmailRegister)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconUserRegister)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRegisterNowRegoster)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCloseRegister)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pbBGRegister
			// 
			this.pbBGRegister.Image = ((System.Drawing.Image)(resources.GetObject("pbBGRegister.Image")));
			this.pbBGRegister.Location = new System.Drawing.Point(0, 0);
			this.pbBGRegister.Name = "pbBGRegister";
			this.pbBGRegister.Size = new System.Drawing.Size(400, 397);
			this.pbBGRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbBGRegister.TabIndex = 1;
			this.pbBGRegister.TabStop = false;
			// 
			// txtEmailRegister
			// 
			this.txtEmailRegister.BackColor = System.Drawing.Color.DarkGray;
			this.txtEmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEmailRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtEmailRegister.Location = new System.Drawing.Point(370, 161);
			this.txtEmailRegister.Multiline = true;
			this.txtEmailRegister.Name = "txtEmailRegister";
			this.txtEmailRegister.Size = new System.Drawing.Size(218, 27);
			this.txtEmailRegister.TabIndex = 11;
			this.txtEmailRegister.Text = "Type here your e-mail address";
			this.txtEmailRegister.Click += new System.EventHandler(this.TxtEmailRegisterClick);
			// 
			// txtNameRegister
			// 
			this.txtNameRegister.BackColor = System.Drawing.Color.DarkGray;
			this.txtNameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNameRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtNameRegister.Location = new System.Drawing.Point(370, 110);
			this.txtNameRegister.Multiline = true;
			this.txtNameRegister.Name = "txtNameRegister";
			this.txtNameRegister.Size = new System.Drawing.Size(218, 20);
			this.txtNameRegister.TabIndex = 10;
			this.txtNameRegister.Text = "TYPE HERE YOUR FULL NAME";
			this.txtNameRegister.Click += new System.EventHandler(this.TxtNameRegisterClick);
			// 
			// pbPasswordRegister
			// 
			this.pbPasswordRegister.Image = ((System.Drawing.Image)(resources.GetObject("pbPasswordRegister.Image")));
			this.pbPasswordRegister.Location = new System.Drawing.Point(313, 149);
			this.pbPasswordRegister.Name = "pbPasswordRegister";
			this.pbPasswordRegister.Size = new System.Drawing.Size(298, 52);
			this.pbPasswordRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPasswordRegister.TabIndex = 9;
			this.pbPasswordRegister.TabStop = false;
			// 
			// pbEmailRegister
			// 
			this.pbEmailRegister.Image = ((System.Drawing.Image)(resources.GetObject("pbEmailRegister.Image")));
			this.pbEmailRegister.Location = new System.Drawing.Point(313, 97);
			this.pbEmailRegister.Name = "pbEmailRegister";
			this.pbEmailRegister.Size = new System.Drawing.Size(298, 45);
			this.pbEmailRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbEmailRegister.TabIndex = 8;
			this.pbEmailRegister.TabStop = false;
			// 
			// pbIconUserRegister
			// 
			this.pbIconUserRegister.Image = ((System.Drawing.Image)(resources.GetObject("pbIconUserRegister.Image")));
			this.pbIconUserRegister.Location = new System.Drawing.Point(430, 12);
			this.pbIconUserRegister.Name = "pbIconUserRegister";
			this.pbIconUserRegister.Size = new System.Drawing.Size(58, 46);
			this.pbIconUserRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconUserRegister.TabIndex = 7;
			this.pbIconUserRegister.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(313, 259);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(298, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(313, 208);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(298, 45);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.BackColor = System.Drawing.Color.DarkGray;
			this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtConfirmPassword.Location = new System.Drawing.Point(370, 271);
			this.txtConfirmPassword.Multiline = true;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(218, 20);
			this.txtConfirmPassword.TabIndex = 15;
			this.txtConfirmPassword.Text = "Repeat your password";
			this.txtConfirmPassword.Click += new System.EventHandler(this.TxtConfirmPasswordClick);
			// 
			// txtPasswordRegister
			// 
			this.txtPasswordRegister.BackColor = System.Drawing.Color.DarkGray;
			this.txtPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPasswordRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.txtPasswordRegister.Location = new System.Drawing.Point(370, 220);
			this.txtPasswordRegister.Multiline = true;
			this.txtPasswordRegister.Name = "txtPasswordRegister";
			this.txtPasswordRegister.Size = new System.Drawing.Size(218, 20);
			this.txtPasswordRegister.TabIndex = 14;
			this.txtPasswordRegister.Text = "Type here your password";
			this.txtPasswordRegister.Click += new System.EventHandler(this.TxtPasswordRegisterClick);
			// 
			// pbRegisterNowRegoster
			// 
			this.pbRegisterNowRegoster.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbRegisterNowRegoster.Image = ((System.Drawing.Image)(resources.GetObject("pbRegisterNowRegoster.Image")));
			this.pbRegisterNowRegoster.Location = new System.Drawing.Point(341, 324);
			this.pbRegisterNowRegoster.Name = "pbRegisterNowRegoster";
			this.pbRegisterNowRegoster.Size = new System.Drawing.Size(238, 49);
			this.pbRegisterNowRegoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbRegisterNowRegoster.TabIndex = 16;
			this.pbRegisterNowRegoster.TabStop = false;
			this.pbRegisterNowRegoster.Click += new System.EventHandler(this.PbRegisterNowRegosterClick);
			// 
			// pbCloseRegister
			// 
			this.pbCloseRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbCloseRegister.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseRegister.Image")));
			this.pbCloseRegister.Location = new System.Drawing.Point(605, 12);
			this.pbCloseRegister.Name = "pbCloseRegister";
			this.pbCloseRegister.Size = new System.Drawing.Size(28, 18);
			this.pbCloseRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbCloseRegister.TabIndex = 17;
			this.pbCloseRegister.TabStop = false;
			this.pbCloseRegister.Click += new System.EventHandler(this.PbCloseRegisterClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("ArtBrush", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(381, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Register now to join us";
			// 
			// pbIconPassword
			// 
			this.pbIconPassword.BackColor = System.Drawing.Color.DarkGray;
			this.pbIconPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbIconPassword.Image")));
			this.pbIconPassword.Location = new System.Drawing.Point(332, 218);
			this.pbIconPassword.Name = "pbIconPassword";
			this.pbIconPassword.Size = new System.Drawing.Size(32, 27);
			this.pbIconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconPassword.TabIndex = 21;
			this.pbIconPassword.TabStop = false;
			// 
			// pbIconEmail
			// 
			this.pbIconEmail.BackColor = System.Drawing.Color.DarkGray;
			this.pbIconEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbIconEmail.Image")));
			this.pbIconEmail.Location = new System.Drawing.Point(332, 161);
			this.pbIconEmail.Name = "pbIconEmail";
			this.pbIconEmail.Size = new System.Drawing.Size(32, 27);
			this.pbIconEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIconEmail.TabIndex = 20;
			this.pbIconEmail.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(332, 268);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 27);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 22;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.DarkGray;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(332, 106);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 27);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// FmRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(645, 394);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pbIconPassword);
			this.Controls.Add(this.pbIconEmail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbCloseRegister);
			this.Controls.Add(this.pbRegisterNowRegoster);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.txtPasswordRegister);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtEmailRegister);
			this.Controls.Add(this.txtNameRegister);
			this.Controls.Add(this.pbPasswordRegister);
			this.Controls.Add(this.pbEmailRegister);
			this.Controls.Add(this.pbIconUserRegister);
			this.Controls.Add(this.pbBGRegister);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FmRegister";
			this.Text = "FmRegister";
			((System.ComponentModel.ISupportInitialize)(this.pbBGRegister)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPasswordRegister)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEmailRegister)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconUserRegister)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRegisterNowRegoster)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCloseRegister)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbIconEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
