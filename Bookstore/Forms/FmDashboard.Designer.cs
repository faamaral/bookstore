/*
 * Criado por SharpDevelop.
 * Usuário: Fabiano
 * Data: 12/05/2020
 * Hora: 22:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Bookstore.Forms
{
	partial class FmDashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDashboard));
            this.pnlVerticalMenu = new System.Windows.Forms.Panel();
            this.btnNickUser = new System.Windows.Forms.Button();
            this.pbShutDownDash = new System.Windows.Forms.PictureBox();
            this.pnlBtnAbout = new System.Windows.Forms.Panel();
            this.pnlBtnProductos = new System.Windows.Forms.Panel();
            this.pnlBtnSale = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.pbLogoDash = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitleDashboard = new System.Windows.Forms.Label();
            this.pbMinimizeDash = new System.Windows.Forms.PictureBox();
            this.pbDropDownDash = new System.Windows.Forms.PictureBox();
            this.pbMaximizeWindowDash = new System.Windows.Forms.PictureBox();
            this.pbCloseWindowDash = new System.Windows.Forms.PictureBox();
            this.pbMenuDash = new System.Windows.Forms.PictureBox();
            this.pnlContainers = new System.Windows.Forms.Panel();
            this.pnlVerticalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShutDownDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDash)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDropDownDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizeWindowDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseWindowDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuDash)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVerticalMenu
            // 
            this.pnlVerticalMenu.BackColor = System.Drawing.Color.DarkRed;
            this.pnlVerticalMenu.Controls.Add(this.btnNickUser);
            this.pnlVerticalMenu.Controls.Add(this.pbShutDownDash);
            this.pnlVerticalMenu.Controls.Add(this.pnlBtnAbout);
            this.pnlVerticalMenu.Controls.Add(this.pnlBtnProductos);
            this.pnlVerticalMenu.Controls.Add(this.pnlBtnSale);
            this.pnlVerticalMenu.Controls.Add(this.btnAbout);
            this.pnlVerticalMenu.Controls.Add(this.btnProductos);
            this.pnlVerticalMenu.Controls.Add(this.btnSale);
            this.pnlVerticalMenu.Controls.Add(this.pbLogoDash);
            this.pnlVerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVerticalMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlVerticalMenu.Name = "pnlVerticalMenu";
            this.pnlVerticalMenu.Size = new System.Drawing.Size(250, 650);
            this.pnlVerticalMenu.TabIndex = 0;
            // 
            // btnNickUser
            // 
            this.btnNickUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNickUser.FlatAppearance.BorderSize = 0;
            this.btnNickUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNickUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNickUser.ForeColor = System.Drawing.Color.White;
            this.btnNickUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNickUser.Image")));
            this.btnNickUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNickUser.Location = new System.Drawing.Point(3, 556);
            this.btnNickUser.Name = "btnNickUser";
            this.btnNickUser.Size = new System.Drawing.Size(245, 40);
            this.btnNickUser.TabIndex = 8;
            this.btnNickUser.UseVisualStyleBackColor = true;
            // 
            // pbShutDownDash
            // 
            this.pbShutDownDash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbShutDownDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShutDownDash.Image = ((System.Drawing.Image)(resources.GetObject("pbShutDownDash.Image")));
            this.pbShutDownDash.Location = new System.Drawing.Point(6, 613);
            this.pbShutDownDash.Name = "pbShutDownDash";
            this.pbShutDownDash.Size = new System.Drawing.Size(30, 30);
            this.pbShutDownDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShutDownDash.TabIndex = 7;
            this.pbShutDownDash.TabStop = false;
            this.pbShutDownDash.Click += new System.EventHandler(this.pbShutDownDash_Click);
            // 
            // pnlBtnAbout
            // 
            this.pnlBtnAbout.BackColor = System.Drawing.Color.White;
            this.pnlBtnAbout.Location = new System.Drawing.Point(0, 161);
            this.pnlBtnAbout.Name = "pnlBtnAbout";
            this.pnlBtnAbout.Size = new System.Drawing.Size(5, 40);
            this.pnlBtnAbout.TabIndex = 6;
            // 
            // pnlBtnProductos
            // 
            this.pnlBtnProductos.BackColor = System.Drawing.Color.White;
            this.pnlBtnProductos.Location = new System.Drawing.Point(0, 115);
            this.pnlBtnProductos.Name = "pnlBtnProductos";
            this.pnlBtnProductos.Size = new System.Drawing.Size(5, 40);
            this.pnlBtnProductos.TabIndex = 5;
            // 
            // pnlBtnSale
            // 
            this.pnlBtnSale.BackColor = System.Drawing.Color.White;
            this.pnlBtnSale.Location = new System.Drawing.Point(0, 69);
            this.pnlBtnSale.Name = "pnlBtnSale";
            this.pnlBtnSale.Size = new System.Drawing.Size(5, 40);
            this.pnlBtnSale.TabIndex = 4;
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(5, 161);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(245, 40);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(5, 115);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(245, 40);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnSale
            // 
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(5, 69);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(245, 40);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // pbLogoDash
            // 
            this.pbLogoDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogoDash.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoDash.Image")));
            this.pbLogoDash.Location = new System.Drawing.Point(3, 7);
            this.pbLogoDash.Name = "pbLogoDash";
            this.pbLogoDash.Size = new System.Drawing.Size(192, 58);
            this.pbLogoDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoDash.TabIndex = 0;
            this.pbLogoDash.TabStop = false;
            this.pbLogoDash.Click += new System.EventHandler(this.pbLogoDash_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.lblTitleDashboard);
            this.pnlTop.Controls.Add(this.pbMinimizeDash);
            this.pnlTop.Controls.Add(this.pbDropDownDash);
            this.pnlTop.Controls.Add(this.pbMaximizeWindowDash);
            this.pnlTop.Controls.Add(this.pbCloseWindowDash);
            this.pnlTop.Controls.Add(this.pbMenuDash);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(250, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1050, 50);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // lblTitleDashboard
            // 
            this.lblTitleDashboard.AutoSize = true;
            this.lblTitleDashboard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDashboard.Location = new System.Drawing.Point(497, 14);
            this.lblTitleDashboard.Name = "lblTitleDashboard";
            this.lblTitleDashboard.Size = new System.Drawing.Size(56, 28);
            this.lblTitleDashboard.TabIndex = 5;
            this.lblTitleDashboard.Text = "Title";
            // 
            // pbMinimizeDash
            // 
            this.pbMinimizeDash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizeDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizeDash.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizeDash.Image")));
            this.pbMinimizeDash.Location = new System.Drawing.Point(958, 5);
            this.pbMinimizeDash.Name = "pbMinimizeDash";
            this.pbMinimizeDash.Size = new System.Drawing.Size(25, 25);
            this.pbMinimizeDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizeDash.TabIndex = 4;
            this.pbMinimizeDash.TabStop = false;
            this.pbMinimizeDash.Click += new System.EventHandler(this.pbMinimizeDash_Click);
            // 
            // pbDropDownDash
            // 
            this.pbDropDownDash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDropDownDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDropDownDash.Image = ((System.Drawing.Image)(resources.GetObject("pbDropDownDash.Image")));
            this.pbDropDownDash.Location = new System.Drawing.Point(989, 5);
            this.pbDropDownDash.Name = "pbDropDownDash";
            this.pbDropDownDash.Size = new System.Drawing.Size(25, 25);
            this.pbDropDownDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDropDownDash.TabIndex = 3;
            this.pbDropDownDash.TabStop = false;
            this.pbDropDownDash.Visible = false;
            this.pbDropDownDash.Click += new System.EventHandler(this.pbDropDownDash_Click);
            // 
            // pbMaximizeWindowDash
            // 
            this.pbMaximizeWindowDash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizeWindowDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximizeWindowDash.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizeWindowDash.Image")));
            this.pbMaximizeWindowDash.Location = new System.Drawing.Point(989, 5);
            this.pbMaximizeWindowDash.Name = "pbMaximizeWindowDash";
            this.pbMaximizeWindowDash.Size = new System.Drawing.Size(25, 25);
            this.pbMaximizeWindowDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizeWindowDash.TabIndex = 2;
            this.pbMaximizeWindowDash.TabStop = false;
            this.pbMaximizeWindowDash.Click += new System.EventHandler(this.pbMaximizeWindowDash_Click);
            // 
            // pbCloseWindowDash
            // 
            this.pbCloseWindowDash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCloseWindowDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseWindowDash.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseWindowDash.Image")));
            this.pbCloseWindowDash.Location = new System.Drawing.Point(1020, 5);
            this.pbCloseWindowDash.Name = "pbCloseWindowDash";
            this.pbCloseWindowDash.Size = new System.Drawing.Size(25, 25);
            this.pbCloseWindowDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseWindowDash.TabIndex = 1;
            this.pbCloseWindowDash.TabStop = false;
            this.pbCloseWindowDash.Click += new System.EventHandler(this.pbCloseWindowDash_Click);
            // 
            // pbMenuDash
            // 
            this.pbMenuDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenuDash.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuDash.Image")));
            this.pbMenuDash.Location = new System.Drawing.Point(6, 7);
            this.pbMenuDash.Name = "pbMenuDash";
            this.pbMenuDash.Size = new System.Drawing.Size(35, 35);
            this.pbMenuDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenuDash.TabIndex = 0;
            this.pbMenuDash.TabStop = false;
            this.pbMenuDash.Click += new System.EventHandler(this.pbMenuDash_Click);
            // 
            // pnlContainers
            // 
            this.pnlContainers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainers.Location = new System.Drawing.Point(250, 50);
            this.pnlContainers.Name = "pnlContainers";
            this.pnlContainers.Size = new System.Drawing.Size(1050, 600);
            this.pnlContainers.TabIndex = 2;
            // 
            // FmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContainers);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlVerticalMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmDashboard";
            this.Load += new System.EventHandler(this.FmDashboard_Load);
            this.pnlVerticalMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShutDownDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDash)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDropDownDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizeWindowDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseWindowDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuDash)).EndInit();
            this.ResumeLayout(false);

		}

		private System.Windows.Forms.Panel pnlVerticalMenu;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox pbMenuDash;
		private System.Windows.Forms.Panel pnlContainers;
        private System.Windows.Forms.PictureBox pbLogoDash;
        private System.Windows.Forms.PictureBox pbMinimizeDash;
        private System.Windows.Forms.PictureBox pbDropDownDash;
        private System.Windows.Forms.PictureBox pbMaximizeWindowDash;
        private System.Windows.Forms.PictureBox pbCloseWindowDash;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pbShutDownDash;
        private System.Windows.Forms.Panel pnlBtnAbout;
        private System.Windows.Forms.Panel pnlBtnProductos;
        private System.Windows.Forms.Panel pnlBtnSale;
        private System.Windows.Forms.Button btnNickUser;
        private System.Windows.Forms.Label lblTitleDashboard;
    }
}
