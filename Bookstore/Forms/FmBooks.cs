using Bookstore.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bookstore.Forms
{
    public partial class FmBooks : Form
    {

        FmAddOrUpdateBook fmAdd = new FmAddOrUpdateBook();

        BookControl bookControl = new BookControl();
        public FmBooks()
        {
            InitializeComponent();
        }

        private void pnlButtosBooks_Paint(object sender, PaintEventArgs e)
        {

        }

        public void FmBooks_Load(object sender, EventArgs e)
        {
            showBooksInDataGrid();
        }

        public void showBooksInDataGrid()
        {
            dgvBooks.DataSource = bookControl.showBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openInPanelContainerBook(new FmAddOrUpdateBook());
            fmAdd.setTitle("Add a new Book");
        }
        private void openInPanelContainerBook(object form)
        {
            if (this.pnlContainerFmAddOrUpdateBook.Controls.Count > 0)
            {
                this.pnlContainerFmAddOrUpdateBook.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContainerFmAddOrUpdateBook.Controls.Add(fh);
            this.pnlContainerFmAddOrUpdateBook.Tag = fh;
            fh.Show();
        }
    }
}
