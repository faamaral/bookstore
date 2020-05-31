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
        private string titleLabel;
        FmAddOrUpdateBook fmAdd = new FmAddOrUpdateBook();

        BookControl bookControl = new BookControl();
        public FmBooks()
        {
            InitializeComponent();
            //pnlContainerFmAddOrUpdateBook.BackColor = Color.DimGray;
            panelAddVisible(false);
            cbGenreBook.Items.Add("Fiction");
            cbGenreBook.Items.Add("Adventure");
            cbGenreBook.Items.Add("Comedy");
        }

        public void setTitleLabel(string s)
        {
            this.titleLabel = s;
        }
        public string getTitleLabel()
        {
            return this.titleLabel;
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

        public void disableButtonsBooks()
        {
            btnAddNewBook.Enabled = false;
            btnSearchBook.Enabled = false;
            btnUpdateData.Enabled = false;
        }
        public void enableButtonsBook()
        {
            btnAddNewBook.Enabled = true;
            btnSearchBook.Enabled = true;
            btnUpdateData.Enabled = true;
        }

        public void ValidaEnableButtons()
        {
            this.enableButtonsBook();
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

        public void refreshForm()
        {
            this.Refresh();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            //openInPanelContainerBook(new FmAddOrUpdateBook());
            //fmAdd.setTitle("Add a new Book");
            //this.disableButtonsBooks();
            pnlContainerFmAddOrUpdateBook.BackColor = Color.DimGray;
            this.setTitleLabel("Add a new book");
            lblTitleAddBook.Text = getTitleLabel();
            panelAddVisible(true);
        }

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void pnlTopFmAddBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtYearBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtAmountBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPriceBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void btnCancelbook_Click(object sender, EventArgs e)
        {
            clearAddNewTextBox();
            panelAddVisible(false);
        }

        private void panelAddVisible(bool v)
        {
            pnlContainerFmAddOrUpdateBook.Visible = v;
        }

        private void clearAddNewTextBox()
        {
            this.txtAmountBook.Clear();
            this.mtxtISBN.Clear();
            this.txtAuthorBook.Clear();
            this.txteditoraBook.Clear();
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            try
            {
                //FmBooks fmBooks = new FmBooks();
                if (cbGenreBook.Text.Equals("Select the  book genre:") && cbGenreBook.SelectedIndex < 0)
                {
                    MessageBox.Show("Please, select a genre the book!");
                    cbGenreBook.Focus();
                }
                else
                {
                    if (bookControl.checkISBNControl(mtxtISBN.Text))
                    {
                        MessageBox.Show("This ISBN has existed in our database");
                        mtxtISBN.Clear();
                        mtxtISBN.Focus();
                    }
                    else
                    {
                        bookControl.insertBooksControl(mtxtISBN.Text, txtTitleBook.Text, txtAuthorBook.Text, txtYearBook.Text, txteditoraBook.Text, cbGenreBook.SelectedItem.ToString(), txtAmountBook.Text, txtPriceBook.Text);

                        this.Refresh();
                        clearAddNewTextBox();
                        panelAddVisible(false);
                        //fmBooks.refreshForm();
                        //this.Close();
                        //fmBooks.ValidaEnableButtons();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
