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
        private string id = null;
        //FmAddOrUpdateBook fmAdd = new FmAddOrUpdateBook();

        BookControl bookControl = new BookControl();
        public FmBooks()
        {
            InitializeComponent();
            //pnlContainerFmAddOrUpdateBook.BackColor = Color.DimGray;
            panelAddVisible(false);
            this.lblTitleAddBook.Text = "";
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
            enableButtonsBooks(false);

        }

        private void enableButtonsBooks(bool v)
        {
            if(v)
            {
                btnAddNewBook.Enabled = true;
                btnUpdateData.Enabled = true;
                btnDeleteBook.Enabled = true;
            }
            else
            {
                btnAddNewBook.Enabled = false;
                btnUpdateData.Enabled = false;
                btnDeleteBook.Enabled = false;
            }
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
            enableButtonsBooks(true);
        }

        private void panelAddVisible(bool v)
        {
            pnlContainerFmAddOrUpdateBook.Visible = v;
        }

        private void clearAddNewTextBox()
        {
            //cbGenreBook.SelectedItem           
            
            this.txtPriceBook.Clear();
            this.txtAmountBook.Clear();
            this.mtxtISBN.Clear();
            this.txtAuthorBook.Clear();
            this.txteditoraBook.Clear();
            this.txtTitleBook.Clear();
            this.txtYearBook.Clear();
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
                    if (bookControl.checkISBNControl(mtxtISBN.Text) && lblTitleAddBook.Text.Equals("Add a new book"))
                    {
                        MessageBox.Show("This ISBN has existed in our database");
                        mtxtISBN.Clear();
                        mtxtISBN.Focus();
                    }
                    else
                    {
                        if (lblTitleAddBook.Text.Equals("Add a new book"))
                        {
                            string result = bookControl.insertBooksControl(mtxtISBN.Text, txtTitleBook.Text, txtAuthorBook.Text, txtYearBook.Text, txteditoraBook.Text, cbGenreBook.SelectedItem.ToString(), txtAmountBook.Text, txtPriceBook.Text);
                            if (result.Equals("sucess"))
                            {
                                clearAddNewTextBox();
                                panelAddVisible(false);
                                lblTitleAddBook.Text = "";
                                showBooksInDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("Error: its not possible add a book!");
                            }
                            //this.Refresh();
                            

                            //fmBooks.refreshForm();
                            //this.Close();
                            //fmBooks.ValidaEnableButtons();
                        }
                        else if(lblTitleAddBook.Text.Equals("Update data"))
                        {
                            string str = bookControl.updateDataControl(id, mtxtISBN.Text, txtTitleBook.Text, txtAuthorBook.Text, txtYearBook.Text, txteditoraBook.Text, cbGenreBook.SelectedItem.ToString(), txtAmountBook.Text, txtPriceBook.Text);
                            if (str.Equals("sucess"))
                            {
                                MessageBox.Show("Update finished with sucess!");
                                this.Refresh();
                                clearAddNewTextBox();
                                panelAddVisible(false);
                                lblTitleAddBook.Text = "";
                                mtxtISBN.ReadOnly = false;
                                showBooksInDataGrid();
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count > 0)
                {
                    pnlContainerFmAddOrUpdateBook.BackColor = Color.DimGray;
                    this.setTitleLabel("Update data");
                    lblTitleAddBook.Text = getTitleLabel();
                    panelAddVisible(true);
                    enableButtonsBooks(false);
                    

                    mtxtISBN.Text = dgvBooks.CurrentRow.Cells["book_isbn"].Value.ToString();
                    txtTitleBook.Text = dgvBooks.CurrentRow.Cells["book_title"].Value.ToString();
                    txtAuthorBook.Text = dgvBooks.CurrentRow.Cells["book_author"].Value.ToString();
                    txtYearBook.Text = dgvBooks.CurrentRow.Cells["book_year"].Value.ToString();
                    txteditoraBook.Text = dgvBooks.CurrentRow.Cells["book_editora"].Value.ToString();
                    cbGenreBook.SelectedIndex = cbGenreBook.FindString(dgvBooks.CurrentRow.Cells["book_genre"].Value.ToString());
                   
                    txtAmountBook.Text = dgvBooks.CurrentRow.Cells["book_amount"].Value.ToString();
                    txtPriceBook.Text = dgvBooks.CurrentRow.Cells["book_price"].Value.ToString();
                    this.id = dgvBooks.CurrentRow.Cells["book_id"].Value.ToString();

                    mtxtISBN.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("Please, select a row!");
                }

                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

            if (dgvBooks.SelectedRows.Count > 0)
            {
                string isbn = dgvBooks.CurrentRow.Cells["book_isbn"].Value.ToString();
                
                
                if (MessageBox.Show("Do you really want to delete these data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string result = bookControl.deleteDataControl(isbn);
                    if (result.Equals("sucess"))
                    {
                        MessageBox.Show("Delete data has been sucessed!");
                        showBooksInDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Delete data it was possible!");
                    }
                }

            }
        }

        private void txtFilterData_TextChanged(object sender, EventArgs e)
        {

            //var termo = (sender as TextBox).Text.ToLowerInvariant();
            //bool semTermo = String.IsNullOrEmpty(termo);

            //foreach (DataGridViewRow linha in dgvBooks.Rows)
            //{
            //    if ((linha.Cells[COL_NOME.Index].Value as string).ToLowerInvariant().Contains(termo) || semTermo)
            //        linha.Visible = true;
            //    else
            //        linha.Visible = false;
            //}
            if (!txtFilterData.Text.Equals("Type here the book title"))
            {
                (dgvBooks.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("book_title LIKE '{0}%' OR book_title LIKE '% {0}%'", txtFilterData.Text);
            }
            
        }

        private void txtFilterData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFilterData.Text.Equals("Type here the book title"))
            {
                txtFilterData.Clear();
            }
        }

        private void txtFilterData_Leave(object sender, EventArgs e)
        {
            if (txtFilterData.Text.Equals(""))
            {
                txtFilterData.Text = "Type here the book title";
            }
        }

        private void txtAmountBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbCloseFmBooks_Click(object sender, EventArgs e)
        {
            
        }
    }
}
