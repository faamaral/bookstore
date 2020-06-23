namespace Bookstore.Forms
{
    partial class FmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAbout));
            this.pnlInfoAbout = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContactsAbout = new System.Windows.Forms.Panel();
            this.pbLinkFacebook = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLinkInstagram = new System.Windows.Forms.PictureBox();
            this.pbLinkTwitter = new System.Windows.Forms.PictureBox();
            this.pbLinkGithub = new System.Windows.Forms.PictureBox();
            this.pnlInfoAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContactsAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfoAbout
            // 
            this.pnlInfoAbout.Controls.Add(this.lblDescription);
            this.pnlInfoAbout.Controls.Add(this.pictureBox1);
            this.pnlInfoAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoAbout.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoAbout.Name = "pnlInfoAbout";
            this.pnlInfoAbout.Size = new System.Drawing.Size(1050, 385);
            this.pnlInfoAbout.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(29, 214);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(994, 117);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "This is a basic system for bookstore management, where \r\nthe main focus of its de" +
    "velopment was around improving the \r\ntactics and good practices of object-orient" +
    "ed programming.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContactsAbout
            // 
            this.pnlContactsAbout.Controls.Add(this.pbLinkGithub);
            this.pnlContactsAbout.Controls.Add(this.pbLinkTwitter);
            this.pnlContactsAbout.Controls.Add(this.pbLinkInstagram);
            this.pnlContactsAbout.Controls.Add(this.pbLinkFacebook);
            this.pnlContactsAbout.Controls.Add(this.label1);
            this.pnlContactsAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContactsAbout.Location = new System.Drawing.Point(0, 391);
            this.pnlContactsAbout.Name = "pnlContactsAbout";
            this.pnlContactsAbout.Size = new System.Drawing.Size(1050, 209);
            this.pnlContactsAbout.TabIndex = 1;
            // 
            // pbLinkFacebook
            // 
            this.pbLinkFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLinkFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pbLinkFacebook.Image")));
            this.pbLinkFacebook.Location = new System.Drawing.Point(573, 83);
            this.pbLinkFacebook.Name = "pbLinkFacebook";
            this.pbLinkFacebook.Size = new System.Drawing.Size(35, 35);
            this.pbLinkFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLinkFacebook.TabIndex = 1;
            this.pbLinkFacebook.TabStop = false;
            this.pbLinkFacebook.Click += new System.EventHandler(this.pbLinkFacebook_Click);
            this.pbLinkFacebook.MouseLeave += new System.EventHandler(this.pbLinkFacebook_MouseLeave);
            this.pbLinkFacebook.MouseHover += new System.EventHandler(this.pbLinkFacebook_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "follow my social networks:";
            // 
            // pbLinkInstagram
            // 
            this.pbLinkInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLinkInstagram.Image = ((System.Drawing.Image)(resources.GetObject("pbLinkInstagram.Image")));
            this.pbLinkInstagram.Location = new System.Drawing.Point(626, 83);
            this.pbLinkInstagram.Name = "pbLinkInstagram";
            this.pbLinkInstagram.Size = new System.Drawing.Size(35, 35);
            this.pbLinkInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLinkInstagram.TabIndex = 2;
            this.pbLinkInstagram.TabStop = false;
            this.pbLinkInstagram.Click += new System.EventHandler(this.pbLinkInstagram_Click);
            this.pbLinkInstagram.MouseLeave += new System.EventHandler(this.pbLinkInstagram_MouseLeave);
            this.pbLinkInstagram.MouseHover += new System.EventHandler(this.pbLinkInstagram_MouseHover);
            // 
            // pbLinkTwitter
            // 
            this.pbLinkTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLinkTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pbLinkTwitter.Image")));
            this.pbLinkTwitter.Location = new System.Drawing.Point(681, 83);
            this.pbLinkTwitter.Name = "pbLinkTwitter";
            this.pbLinkTwitter.Size = new System.Drawing.Size(35, 35);
            this.pbLinkTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLinkTwitter.TabIndex = 3;
            this.pbLinkTwitter.TabStop = false;
            this.pbLinkTwitter.Click += new System.EventHandler(this.pbLinkTwitter_Click);
            this.pbLinkTwitter.MouseLeave += new System.EventHandler(this.pbLinkTwitter_MouseLeave);
            this.pbLinkTwitter.MouseHover += new System.EventHandler(this.pbLinkTwitter_MouseHover);
            // 
            // pbLinkGithub
            // 
            this.pbLinkGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLinkGithub.Image = ((System.Drawing.Image)(resources.GetObject("pbLinkGithub.Image")));
            this.pbLinkGithub.Location = new System.Drawing.Point(734, 83);
            this.pbLinkGithub.Name = "pbLinkGithub";
            this.pbLinkGithub.Size = new System.Drawing.Size(35, 35);
            this.pbLinkGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLinkGithub.TabIndex = 4;
            this.pbLinkGithub.TabStop = false;
            this.pbLinkGithub.Click += new System.EventHandler(this.pbLinkGithub_Click);
            this.pbLinkGithub.MouseLeave += new System.EventHandler(this.pbLinkGithub_MouseLeave);
            this.pbLinkGithub.MouseHover += new System.EventHandler(this.pbLinkGithub_MouseHover);
            // 
            // FmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pnlContactsAbout);
            this.Controls.Add(this.pnlInfoAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAbout";
            this.Text = "FmAbout";
            this.pnlInfoAbout.ResumeLayout(false);
            this.pnlInfoAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContactsAbout.ResumeLayout(false);
            this.pnlContactsAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkGithub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfoAbout;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContactsAbout;
        private System.Windows.Forms.PictureBox pbLinkFacebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLinkGithub;
        private System.Windows.Forms.PictureBox pbLinkTwitter;
        private System.Windows.Forms.PictureBox pbLinkInstagram;
    }
}