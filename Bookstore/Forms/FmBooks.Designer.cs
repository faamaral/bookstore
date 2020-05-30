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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBooksGrid = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.pnlContainerFmAddOrUpdateBook = new System.Windows.Forms.Panel();
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
            this.pnlButtosBooks.Controls.Add(this.button3);
            this.pnlButtosBooks.Controls.Add(this.button2);
            this.pnlButtosBooks.Controls.Add(this.button1);
            this.pnlButtosBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtosBooks.Location = new System.Drawing.Point(0, 0);
            this.pnlButtosBooks.Name = "pnlButtosBooks";
            this.pnlButtosBooks.Size = new System.Drawing.Size(522, 600);
            this.pnlButtosBooks.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(354, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update data";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(183, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search book now";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add a new book";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // pnlContainerFmAddOrUpdateBook
            // 
            this.pnlContainerFmAddOrUpdateBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContainerFmAddOrUpdateBook.Location = new System.Drawing.Point(0, 126);
            this.pnlContainerFmAddOrUpdateBook.Name = "pnlContainerFmAddOrUpdateBook";
            this.pnlContainerFmAddOrUpdateBook.Size = new System.Drawing.Size(522, 474);
            this.pnlContainerFmAddOrUpdateBook.TabIndex = 3;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlBooksGrid;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel pnlContainerFmAddOrUpdateBook;
    }
}