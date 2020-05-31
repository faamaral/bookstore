namespace Bookstore.Forms
{
    partial class FmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBooks));
            this.pbCloseFmBooks = new System.Windows.Forms.PictureBox();
            this.pnlButtosBooks = new System.Windows.Forms.Panel();
            this.pnlContainerFmAddOrUpdateBook = new System.Windows.Forms.Panel();
            this.pnlTopFmAddBook = new System.Windows.Forms.Panel();
            this.lblTitleAddBook = new System.Windows.Forms.Label();
            this.btnCancelbook = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.txtPriceBook = new System.Windows.Forms.TextBox();
            this.mtxtISBN = new System.Windows.Forms.MaskedTextBox();
            this.cbGenreBook = new System.Windows.Forms.ComboBox();
            this.txtAmountBook = new System.Windows.Forms.TextBox();
            this.txteditoraBook = new System.Windows.Forms.TextBox();
            this.txtAuthorBook = new System.Windows.Forms.TextBox();
            this.txtYearBook = new System.Windows.Forms.TextBox();
            this.txtTitleBook = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitleBook = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.pnlBooksGrid = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseFmBooks)).BeginInit();
            this.pnlButtosBooks.SuspendLayout();
            this.pnlContainerFmAddOrUpdateBook.SuspendLayout();
            this.pnlTopFmAddBook.SuspendLayout();
            this.pnlBooksGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCloseFmBooks
            // 
            this.pbCloseFmBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCloseFmBooks.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseFmBooks.Image")));
            this.pbCloseFmBooks.Location = new System.Drawing.Point(485, 12);
            this.pbCloseFmBooks.Name = "pbCloseFmBooks";
            this.pbCloseFmBooks.Size = new System.Drawing.Size(25, 25);
            this.pbCloseFmBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseFmBooks.TabIndex = 1;
            this.pbCloseFmBooks.TabStop = false;
            // 
            // pnlButtosBooks
            // 
            this.pnlButtosBooks.Controls.Add(this.pnlContainerFmAddOrUpdateBook);
            this.pnlButtosBooks.Controls.Add(this.btnUpdateData);
            this.pnlButtosBooks.Controls.Add(this.btnAddNewBook);
            this.pnlButtosBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtosBooks.Location = new System.Drawing.Point(0, 0);
            this.pnlButtosBooks.Name = "pnlButtosBooks";
            this.pnlButtosBooks.Size = new System.Drawing.Size(522, 600);
            this.pnlButtosBooks.TabIndex = 2;
            // 
            // pnlContainerFmAddOrUpdateBook
            // 
            this.pnlContainerFmAddOrUpdateBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainerFmAddOrUpdateBook.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.pnlTopFmAddBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.btnCancelbook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.btnSaveBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.txtPriceBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.mtxtISBN);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.cbGenreBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.txtAmountBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.txteditoraBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.txtAuthorBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.txtYearBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.txtTitleBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.label7);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.label6);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.label5);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.label4);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.label3);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.label2);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.lblTitleBook);
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(this.lblISBN);
            this.pnlContainerFmAddOrUpdateBook.Location = new System.Drawing.Point(0, 126);
            this.pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            this.pnlContainerFmAddOrUpdateBook.Size = new System.Drawing.Size(522, 474);
            this.pnlContainerFmAddOrUpdateBook.TabIndex = 3;
            // 
            // pnlTopFmAddBook
            // 
            this.pnlTopFmAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.pnlTopFmAddBook.Controls.Add(this.lblTitleAddBook);
            this.pnlTopFmAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFmAddBook.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFmAddBook.Name = "pnlTopFmAddBook";
            this.pnlTopFmAddBook.Size = new System.Drawing.Size(522, 33);
            this.pnlTopFmAddBook.TabIndex = 36;
            this.pnlTopFmAddBook.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopFmAddBook_Paint);
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
            this.btnCancelbook.Location = new System.Drawing.Point(311, 313);
            this.btnCancelbook.Name = "btnCancelbook";
            this.btnCancelbook.Size = new System.Drawing.Size(117, 45);
            this.btnCancelbook.TabIndex = 35;
            this.btnCancelbook.Text = "Cancel";
            this.btnCancelbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelbook.UseVisualStyleBackColor = false;
            this.btnCancelbook.Click += new System.EventHandler(this.btnCancelbook_Click);
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
            this.btnSaveBook.Location = new System.Drawing.Point(164, 313);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(117, 45);
            this.btnSaveBook.TabIndex = 34;
            this.btnSaveBook.Text = "Save";
            this.btnSaveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveBook.UseVisualStyleBackColor = false;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // txtPriceBook
            // 
            this.txtPriceBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceBook.Location = new System.Drawing.Point(164, 273);
            this.txtPriceBook.MaxLength = 20;
            this.txtPriceBook.Multiline = true;
            this.txtPriceBook.Name = "txtPriceBook";
            this.txtPriceBook.Size = new System.Drawing.Size(264, 20);
            this.txtPriceBook.TabIndex = 33;
            this.txtPriceBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceBook_KeyPress);
            // 
            // mtxtISBN
            // 
            this.mtxtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtISBN.Location = new System.Drawing.Point(164, 91);
            this.mtxtISBN.Mask = "ISBN 000-&&&&&&&&&-0";
            this.mtxtISBN.Name = "mtxtISBN";
            this.mtxtISBN.Size = new System.Drawing.Size(264, 13);
            this.mtxtISBN.TabIndex = 32;
            // 
            // cbGenreBook
            // 
            this.cbGenreBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGenreBook.FormattingEnabled = true;
            this.cbGenreBook.Location = new System.Drawing.Point(195, 218);
            this.cbGenreBook.Name = "cbGenreBook";
            this.cbGenreBook.Size = new System.Drawing.Size(202, 21);
            this.cbGenreBook.TabIndex = 31;
            this.cbGenreBook.Text = "Select the  book genre:";
            // 
            // txtAmountBook
            // 
            this.txtAmountBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountBook.Location = new System.Drawing.Point(164, 247);
            this.txtAmountBook.Multiline = true;
            this.txtAmountBook.Name = "txtAmountBook";
            this.txtAmountBook.Size = new System.Drawing.Size(264, 20);
            this.txtAmountBook.TabIndex = 30;
            this.txtAmountBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountBook_KeyPress);
            // 
            // txteditoraBook
            // 
            this.txteditoraBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txteditoraBook.Location = new System.Drawing.Point(164, 195);
            this.txteditoraBook.Multiline = true;
            this.txteditoraBook.Name = "txteditoraBook";
            this.txteditoraBook.Size = new System.Drawing.Size(264, 20);
            this.txteditoraBook.TabIndex = 29;
            // 
            // txtAuthorBook
            // 
            this.txtAuthorBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthorBook.Location = new System.Drawing.Point(164, 143);
            this.txtAuthorBook.Multiline = true;
            this.txtAuthorBook.Name = "txtAuthorBook";
            this.txtAuthorBook.Size = new System.Drawing.Size(264, 20);
            this.txtAuthorBook.TabIndex = 28;
            // 
            // txtYearBook
            // 
            this.txtYearBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYearBook.Location = new System.Drawing.Point(164, 169);
            this.txtYearBook.MaxLength = 4;
            this.txtYearBook.Multiline = true;
            this.txtYearBook.Name = "txtYearBook";
            this.txtYearBook.Size = new System.Drawing.Size(264, 20);
            this.txtYearBook.TabIndex = 27;
            this.txtYearBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearBook_KeyPress);
            // 
            // txtTitleBook
            // 
            this.txtTitleBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleBook.Location = new System.Drawing.Point(164, 117);
            this.txtTitleBook.Multiline = true;
            this.txtTitleBook.Name = "txtTitleBook";
            this.txtTitleBook.Size = new System.Drawing.Size(264, 20);
            this.txtTitleBook.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Price R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(64, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Editora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Author";
            // 
            // lblTitleBook
            // 
            this.lblTitleBook.AutoSize = true;
            this.lblTitleBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBook.ForeColor = System.Drawing.Color.White;
            this.lblTitleBook.Location = new System.Drawing.Point(80, 112);
            this.lblTitleBook.Name = "lblTitleBook";
            this.lblTitleBook.Size = new System.Drawing.Size(38, 19);
            this.lblTitleBook.TabIndex = 19;
            this.lblTitleBook.Text = "Title";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(78, 86);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(42, 19);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN";
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.btnUpdateData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateData.FlatAppearance.BorderSize = 0;
            this.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateData.ForeColor = System.Drawing.Color.White;
            this.btnUpdateData.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateData.Image")));
            this.btnUpdateData.Location = new System.Drawing.Point(354, 51);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(154, 69);
            this.btnUpdateData.TabIndex = 2;
            this.btnUpdateData.Text = "Update data";
            this.btnUpdateData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateData.UseVisualStyleBackColor = false;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnAddNewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.Image")));
            this.btnAddNewBook.Location = new System.Drawing.Point(12, 51);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(154, 69);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.Text = "Add a new book";
            this.btnAddNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNewBook.UseVisualStyleBackColor = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBook.Image")));
            this.btnSearchBook.Location = new System.Drawing.Point(463, 73);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(47, 47);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // pnlBooksGrid
            // 
            this.pnlBooksGrid.Controls.Add(this.label1);
            this.pnlBooksGrid.Controls.Add(this.txtSearchBook);
            this.pnlBooksGrid.Controls.Add(this.dgvBooks);
            this.pnlBooksGrid.Controls.Add(this.pbCloseFmBooks);
            this.pnlBooksGrid.Controls.Add(this.btnSearchBook);
            this.pnlBooksGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBooksGrid.Location = new System.Drawing.Point(528, 0);
            this.pnlBooksGrid.Name = "pnlBooksGrid";
            this.pnlBooksGrid.Size = new System.Drawing.Size(522, 600);
            this.pnlBooksGrid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search book now";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBook.Location = new System.Drawing.Point(13, 73);
            this.txtSearchBook.Multiline = true;
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(444, 47);
            this.txtSearchBook.TabIndex = 3;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(13, 135);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(497, 275);
            this.dgvBooks.TabIndex = 2;
            // 
            // FmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pnlBooksGrid);
            this.Controls.Add(this.pnlButtosBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmBooks";
            this.Text = "FmBooks";
            this.Load += new System.EventHandler(this.FmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseFmBooks)).EndInit();
            this.pnlButtosBooks.ResumeLayout(false);
            this.pnlContainerFmAddOrUpdateBook.ResumeLayout(false);
            this.pnlContainerFmAddOrUpdateBook.PerformLayout();
            this.pnlTopFmAddBook.ResumeLayout(false);
            this.pnlTopFmAddBook.PerformLayout();
            this.pnlBooksGrid.ResumeLayout(false);
            this.pnlBooksGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCloseFmBooks;
        private System.Windows.Forms.Panel pnlButtosBooks;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Panel pnlBooksGrid;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel pnlContainerFmAddOrUpdateBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtPriceBook;
        private System.Windows.Forms.MaskedTextBox mtxtISBN;
        private System.Windows.Forms.ComboBox cbGenreBook;
        private System.Windows.Forms.TextBox txtAmountBook;
        private System.Windows.Forms.TextBox txteditoraBook;
        private System.Windows.Forms.TextBox txtAuthorBook;
        private System.Windows.Forms.TextBox txtYearBook;
        private System.Windows.Forms.TextBox txtTitleBook;
        private System.Windows.Forms.Button btnCancelbook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Panel pnlTopFmAddBook;
        private System.Windows.Forms.Label lblTitleAddBook;
    }
}