namespace Bookstore.Forms
{
    partial class FmAddOrUpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAddOrUpdateBook));
            this.pnlTopFmAddBook = new System.Windows.Forms.Panel();
            this.lblTitleAddBook = new System.Windows.Forms.Label();
            this.txtTitleBook = new System.Windows.Forms.TextBox();
            this.txtYearBook = new System.Windows.Forms.TextBox();
            this.txtAuthorBook = new System.Windows.Forms.TextBox();
            this.txteditoraBook = new System.Windows.Forms.TextBox();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.cbGenreBook = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.mtxtISBN = new System.Windows.Forms.MaskedTextBox();
            this.lblTitleBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPriceBook = new System.Windows.Forms.TextBox();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.btnCancelbook = new System.Windows.Forms.Button();
            this.pnlTopFmAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopFmAddBook
            // 
            this.pnlTopFmAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.pnlTopFmAddBook.Controls.Add(this.lblTitleAddBook);
            this.pnlTopFmAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFmAddBook.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            this.pnlTopFmAddBook.Size = new System.Drawing.Size(506, 33);
            this.pnlTopFmAddBook.TabIndex = 0;
            // 
            // lblTitleAddBook
            // 
            this.lblTitleAddBook.AutoSize = true;
            this.lblTitleAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleAddBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAddBook.ForeColor = System.Drawing.Color.White;
            this.lblTitleAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleAddBook.Location = new System.Drawing.Point(180, 7);
            this.lblTitleAddBook.Name = "lblTitleAddBook";
            this.lblTitleAddBook.Size = new System.Drawing.Size(139, 19);
            this.lblTitleAddBook.TabIndex = 0;
            this.lblTitleAddBook.Text = "Add a new book";
            this.lblTitleAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitleBook
            // 
            this.txtTitleBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleBook.Location = new System.Drawing.Point(184, 95);
            this.txtTitleBook.Multiline = true;
            this.txtTitleBook.Name = "txtTitleBook";
            this.txtTitleBook.Size = new System.Drawing.Size(264, 20);
            this.txtTitleBook.TabIndex = 2;
            // 
            // txtYearBook
            // 
            this.txtYearBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYearBook.Location = new System.Drawing.Point(184, 147);
            this.txtYearBook.MaxLength = 4;
            this.txtYearBook.Multiline = true;
            this.txtYearBook.Name = "txtYearBook";
            this.txtYearBook.Size = new System.Drawing.Size(264, 20);
            this.txtYearBook.TabIndex = 3;
            this.txtYearBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearBook_KeyPress);
            // 
            // txtAuthorBook
            // 
            this.txtAuthorBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthorBook.Location = new System.Drawing.Point(184, 121);
            this.txtAuthorBook.Multiline = true;
            this.txtAuthorBook.Name = "txtAuthorBook";
            this.txtAuthorBook.Size = new System.Drawing.Size(264, 20);
            this.txtAuthorBook.TabIndex = 4;
            // 
            // txteditoraBook
            // 
            this.txteditoraBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txteditoraBook.Location = new System.Drawing.Point(184, 173);
            this.txteditoraBook.Multiline = true;
            this.txteditoraBook.Name = "txteditoraBook";
            this.txteditoraBook.Size = new System.Drawing.Size(264, 20);
            this.txteditoraBook.TabIndex = 5;
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountBook.Location = new System.Drawing.Point(184, 225);
            this.txtAmountBook.Multiline = true;
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(264, 20);
            this.txtAmountBook.TabIndex = 6;
            this.txtAmountBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountBook_KeyPress);
            // 
            // cbGenreBook
            // 
            this.cbGenreBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGenreBook.FormattingEnabled = true;
            this.cbGenreBook.Location = new System.Drawing.Point(215, 196);
            this.cbGenreBook.Name = "cbGenreBook";
            this.cbGenreBook.Size = new System.Drawing.Size(202, 21);
            this.cbGenreBook.TabIndex = 8;
            this.cbGenreBook.Text = "Select the  book genre:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(77, 64);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(42, 19);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "ISBN";
            // 
            // mtxtISBN
            // 
            this.mtxtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtISBN.Location = new System.Drawing.Point(184, 69);
            this.mtxtISBN.Mask = "ISBN 000-&&&&&&&&&-0";
            this.mtxtISBN.Name = "mtxtISBN";
            this.mtxtISBN.Size = new System.Drawing.Size(264, 13);
            this.mtxtISBN.TabIndex = 10;
            // 
            // lblTitleBook
            // 
            this.lblTitleBook.AutoSize = true;
            this.lblTitleBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBook.ForeColor = System.Drawing.Color.White;
            this.lblTitleBook.Location = new System.Drawing.Point(79, 90);
            this.lblTitleBook.Name = "lblTitleBook";
            this.lblTitleBook.Size = new System.Drawing.Size(38, 19);
            this.lblTitleBook.TabIndex = 11;
            this.lblTitleBook.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(64, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Price R$";
            // 
            // txtPriceBook
            // 
            this.txtPriceBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceBook.Location = new System.Drawing.Point(184, 251);
            this.txtPriceBook.MaxLength = 20;
            this.txtPriceBook.Multiline = true;
            this.txtPriceBook.Name = "txtPriceBook";
            this.txtPriceBook.Size = new System.Drawing.Size(264, 20);
            this.txtPriceBook.TabIndex = 18;
            this.txtPriceBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceBook_KeyPress);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnSaveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBook.FlatAppearance.BorderSize = 0;
            this.btnSaveBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBook.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBook.ForeColor = System.Drawing.Color.White;
            this.btnSaveBook.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBook.Image")));
            this.btnSaveBook.Location = new System.Drawing.Point(184, 307);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(117, 45);
            this.btnSaveBook.TabIndex = 19;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveBook.UseVisualStyleBackColor = false;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // btnCancelbook
            // 
            this.btnCancelbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnCancelbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelbook.FlatAppearance.BorderSize = 0;
            this.btnCancelbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancelbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelbook.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelbook.ForeColor = System.Drawing.Color.White;
            this.btnCancelbook.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelbook.Image")));
            this.btnCancelbook.Location = new System.Drawing.Point(331, 307);
            this.btnCancelbook.Name = "btnCancelbook";
            this.btnCancelbook.Size = new System.Drawing.Size(117, 45);
            this.btnCancelbook.TabIndex = 20;
            this.btnCancelbook.Text = "Cancel";
            this.btnCancelbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelbook.UseVisualStyleBackColor = false;
            this.btnCancelbook.Click += new System.EventHandler(this.btnCancelbook_Click);
            // 
            // FmAddOrUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(506, 435);
            this.Controls.Add(this.btnCancelbook);
            this.Controls.Add(this.btnSaveBook);
            this.Controls.Add(this.txtPriceBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitleBook);
            this.Controls.Add(this.mtxtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.cbGenreBook);
            this.Controls.Add(this.txtAmountBook);
            this.Controls.Add(this.txteditoraBook);
            this.Controls.Add(this.txtAuthorBook);
            this.Controls.Add(this.txtYearBook);
            this.Controls.Add(this.txtTitleBook);
            this.Controls.Add(this.pnlTopFmAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAddOrUpdateBook";
            this.Text = "FmAddOrUpdateBook";
            this.Load += new System.EventHandler(this.FmAddOrUpdateBook_Load);
            this.pnlTopFmAddBook.ResumeLayout(false);
            this.pnlTopFmAddBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopFmAddBook;
        private System.Windows.Forms.Label lblTitleAddBook;
        private System.Windows.Forms.TextBox txtTitleBook;
        private System.Windows.Forms.TextBox txtYearBook;
        private System.Windows.Forms.TextBox txtAuthorBook;
        private System.Windows.Forms.TextBox txteditoraBook;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.ComboBox cbGenreBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.MaskedTextBox mtxtISBN;
        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPriceBook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Button btnCancelbook;
    }
}