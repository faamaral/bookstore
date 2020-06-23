using Bookstore.Database;
using Bookstore.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bookstore.Forms
{
    public partial class FmSale : Form
    {
        SaleControl sControl = new SaleControl();
        private string priceDefalt;
        SaleProd sp = new SaleProd();
        public FmSale()
        {
            InitializeComponent();
            pnlCalcDiscount.Visible = false;
            
        }

        private void btnSearchBookSale_Click(object sender, EventArgs e)
        {
            if (sControl.showSearchSale(mtxtSearchBookSale.Text).Rows.Count <= 0)
            {
                MessageBox.Show("There are no book with this ISBN!");
            }
            else
            {
                pnlDgvSearchPro.Visible = true;
                dgvSearchProd.DataSource = sControl.showSearchSale(mtxtSearchBookSale.Text);

                if (dgvSearchProd.SelectedRows.Count > 0)
                {
                    txtIdProd.Text = dgvSearchProd.CurrentRow.Cells["book_id"].Value.ToString();
                    txtIsbnProd.Text = dgvSearchProd.CurrentRow.Cells["book_isbn"].Value.ToString();
                    txtNameProd.Text = dgvSearchProd.CurrentRow.Cells["book_title"].Value.ToString();
                    txtAmountProd.Text = "1";
                    priceDefalt  = dgvSearchProd.CurrentRow.Cells["book_price"].Value.ToString();
                    txtPriceProd.Text = priceDefalt;
                }
            }
        }

        private void txtAmountProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPriceProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private string calculo(string amount, string preco)
        {
            string rpl;
            if (preco.Contains(","))
            {
                preco.Replace(",", ".");
            }
            rpl = preco;
            decimal a = Convert.ToDecimal(amount);
            decimal b = Convert.ToDecimal(rpl);
            decimal result = a * b;
            string answer = result.ToString();
            if (answer.Contains("."))
            {
                answer.Replace(".",",");
            }
            
            return answer;
        }

        private void txtAmountProd_TextChanged(object sender, EventArgs e)
        {


            if ((!txtAmountProd.Text.Equals("1")) && txtAmountProd.Text.Length > 0)
            {
                txtPriceProd.Text = calculo(txtAmountProd.Text, txtPriceProd.Text);
            }
            if (txtAmountProd.Text.Equals("1") || txtAmountProd.Text.Equals(""))
            {
                txtPriceProd.Text = priceDefalt;
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            dgvShoppingCart.Rows.Add(txtIdProd.Text,txtIsbnProd.Text,txtNameProd.Text,txtAmountProd.Text,txtPriceProd.Text);
            sp.calcPriceTotal(Convert.ToDecimal(txtPriceProd.Text));
            txtPriceTotalSale.Text = Convert.ToString(sp.priceTotal_prod);
            dgvSearchProd.DataSource = null;
            mtxtSearchBookSale.Clear();
            txtIdProd.Clear();
            txtIsbnProd.Clear();
            txtNameProd.Clear();
            txtAmountProd.Clear();
            txtPriceProd.Clear();

        }

        private void btnCancelAddCart_Click(object sender, EventArgs e)
        {
            dgvSearchProd.DataSource = null;
            mtxtSearchBookSale.Clear();
            txtIdProd.Clear();
            txtIsbnProd.Clear();
            txtNameProd.Clear();
            txtAmountProd.Clear();
            txtPriceProd.Clear();
        }

        private void cbApplyDiscount_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        

        private void txtDiscountValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 09)
            {
                e.Handled = true;
            }
        }

        private void txtDiscountValue_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscountValue.Text.Equals(""))
            {
                btnApplyDiscount.Enabled = false;
            }
            else
                btnApplyDiscount.Enabled = true;
        }

        

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            sp.priceFinal_prod = (sp.priceTotal_prod - sp.calcDiscountValue(Convert.ToDecimal(txtDiscountValue.Text), sp.priceTotal_prod));
            txtPriceTotalSale.Text = sp.priceFinal_prod.ToString();
            pnlPartSeachProd.Enabled = false;
        }

        private void cbApplyDiscount_Click(object sender, EventArgs e)
        {
            if (dgvShoppingCart.Rows.Count != 0)
            {
                if (cbApplyDiscount.Checked)
                {
                    pnlCalcDiscount.Visible = true;
                }
                else
                {
                    pnlCalcDiscount.Visible = false;
                }
            }

        }

        private void btnFinishShop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your purchase worth"+sp.priceFinal_prod.ToString()+"has successfully completed", "Congratulations");
            if (pnlPartSeachProd.Enabled != true)
                pnlPartSeachProd.Enabled = true;
            dgvShoppingCart.DataSource = null;
            cbApplyDiscount.Checked = false;
            pnlCalcDiscount.Visible = false;
            txtPriceTotalSale.Text = "";
            sp.priceTotal_prod = 0;
            sp.priceFinal_prod = sp.priceTotal_prod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlPartSeachProd.Enabled != true)
                pnlPartSeachProd.Enabled = true;
            dgvShoppingCart.DataSource = null;
            cbApplyDiscount.Checked = false;
            pnlCalcDiscount.Visible = false;
            txtPriceTotalSale.Text = "";
            sp.priceTotal_prod = 0;
            sp.priceFinal_prod = sp.priceTotal_prod;
        }
    }
}
