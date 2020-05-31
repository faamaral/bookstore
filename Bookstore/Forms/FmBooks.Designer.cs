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
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.pnlBooksGrid = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseFmBooks)).BeginInit();
            this.pnlButtosBooks.SuspendLayout();
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
            this.pnlButtosBooks.Controls.Add(this.btnSearchBook);
            this.pnlButtosBooks.Controls.Add(this.btnAddNewBook);
            this.pnlButtosBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtosBooks.Location = new System.Drawing.Point(0, 0);
            this.pnlButtosBooks.Name = "pnlButtosBooks";
            this.pnlButtosBooks.Size = new System.Drawing.Size(522, 600);
            this.pnlButtosBooks.TabIndex = 2;
            // 
            // pnlContainerFmAddOrUpdateBook
            // 
            this.pnlContainerFmAddOrUpdateBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContainerFmAddOrUpdateBook.Location = new System.Drawing.Point(0, 126);
            this.pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            this.pnlContainerFmAddOrUpdateBook.Size = new System.Drawing.Size(522, 474);
            this.pnlContainerFmAddOrUpdateBook.TabIndex = 3;
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
            this.btnSearchBook.Location = new System.Drawing.Point(183, 51);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(154, 69);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "Search book now";
            this.btnSearchBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearchBook.UseVisualStyleBackColor = false;
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
            // pnlBooksGrid
            // 
            this.pnlBooksGrid.Controls.Add(this.dgvBooks);
            this.pnlBooksGrid.Controls.Add(this.pbCloseFmBooks);
            this.pnlBooksGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBooksGrid.Location = new System.Drawing.Point(528, 0);
            this.pnlBooksGrid.Name = "pnlBooksGrid";
            this.pnlBooksGrid.Size = new System.Drawing.Size(522, 600);
            this.pnlBooksGrid.TabIndex = 3;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(13, 51);
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
            this.pnlBooksGrid.ResumeLayout(false);
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
    }
}