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
    public partial class FmAddOrUpdateBook : Form
    {
        private string titleForm;
        BookControl bookControl = new BookControl();

        public FmAddOrUpdateBook()
        {
            InitializeComponent();
            //AplicarEventos(txtPriceBook);
            
        }

        private void FmAddOrUpdateBook_Load(object sender, EventArgs e)
        {
            lblTitleAddBook.Text = getTitle();

            cbGenreBook.Items.Add("Fiction");
            cbGenreBook.Items.Add("Adventure");
            cbGenreBook.Items.Add("Comedy");
        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        public void setTitle(string v)
        {
            this.titleForm = v;
        }

        public string getTitle()
        {
            return titleForm;
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
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

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        //private void btnCancelAddBook_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        public void enableButtosFMBooks()
        {
            FmBooks fmBooks = new FmBooks();
        }
        private void btnCancelbook_Click(object sender, EventArgs e)
        {
            //FmBooks fmBooks = new FmBooks();
            this.Close();
            //fmBooks.ValidaEnableButtons();
            //fmBooks.refreshForm();
            
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
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

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            try
            {
                FmBooks fmBooks = new FmBooks();
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
                        fmBooks.refreshForm();
                        this.Close();
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
