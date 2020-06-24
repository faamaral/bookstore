namespace Bookstore.Forms
{
    partial class FmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbApplyDiscount = new System.Windows.Forms.CheckBox();
            this.pnlCalcDiscount = new System.Windows.Forms.Panel();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelBuying = new System.Windows.Forms.Button();
            this.btnFinishShop = new System.Windows.Forms.Button();
            this.txtPriceTotalSale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvShoppingCart = new System.Windows.Forms.DataGridView();
            this.dgvShopping_idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShopping_isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShopping_nameProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShopping_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShopping_Mountaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPartSeachProd = new System.Windows.Forms.Panel();
            this.pnlQuantProd = new System.Windows.Forms.Panel();
            this.txtPriceProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsbnProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelAddCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dgvSearchProd = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mtxtSearchBookSale = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchBookSale = new System.Windows.Forms.Button();
            this.pnlDgvSearchPro = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCalcDiscount.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).BeginInit();
            this.pnlPartSeachProd.SuspendLayout();
            this.pnlQuantProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProd)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.cbApplyDiscount);
            this.panel1.Controls.Add(this.pnlCalcDiscount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvShoppingCart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(477, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 600);
            this.panel1.TabIndex = 0;
            // 
            // cbApplyDiscount
            // 
            this.cbApplyDiscount.AutoSize = true;
            this.cbApplyDiscount.Location = new System.Drawing.Point(238, 298);
            this.cbApplyDiscount.Name = "cbApplyDiscount";
            this.cbApplyDiscount.Size = new System.Drawing.Size(95, 17);
            this.cbApplyDiscount.TabIndex = 4;
            this.cbApplyDiscount.Text = "Apply discount";
            this.cbApplyDiscount.UseVisualStyleBackColor = true;
            this.cbApplyDiscount.CheckedChanged += new System.EventHandler(this.cbApplyDiscount_CheckedChanged);
            this.cbApplyDiscount.Click += new System.EventHandler(this.cbApplyDiscount_Click);
            // 
            // pnlCalcDiscount
            // 
            this.pnlCalcDiscount.Controls.Add(this.label8);
            this.pnlCalcDiscount.Controls.Add(this.btnApplyDiscount);
            this.pnlCalcDiscount.Controls.Add(this.txtDiscountValue);
            this.pnlCalcDiscount.Location = new System.Drawing.Point(25, 321);
            this.pnlCalcDiscount.Name = "pnlCalcDiscount";
            this.pnlCalcDiscount.Size = new System.Drawing.Size(521, 100);
            this.pnlCalcDiscount.TabIndex = 3;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnApplyDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyDiscount.FlatAppearance.BorderSize = 0;
            this.btnApplyDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyDiscount.ForeColor = System.Drawing.Color.White;
            this.btnApplyDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyDiscount.Image")));
            this.btnApplyDiscount.Location = new System.Drawing.Point(198, 46);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(124, 43);
            this.btnApplyDiscount.TabIndex = 14;
            this.btnApplyDiscount.Text = "Apply";
            this.btnApplyDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyDiscount.UseVisualStyleBackColor = false;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscountValue.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtDiscountValue.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDiscountValue.Location = new System.Drawing.Point(200, 5);
            this.txtDiscountValue.MaxLength = 2;
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(121, 30);
            this.txtDiscountValue.TabIndex = 13;
            this.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscountValue.TextChanged += new System.EventHandler(this.txtDiscountValue_TextChanged);
            this.txtDiscountValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountValue_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelBuying);
            this.panel2.Controls.Add(this.btnFinishShop);
            this.panel2.Controls.Add(this.txtPriceTotalSale);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 161);
            this.panel2.TabIndex = 2;
            // 
            // btnCancelBuying
            // 
            this.btnCancelBuying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(10)))), ((int)(((byte)(17)))));
            this.btnCancelBuying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelBuying.FlatAppearance.BorderSize = 0;
            this.btnCancelBuying.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancelBuying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBuying.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBuying.ForeColor = System.Drawing.Color.White;
            this.btnCancelBuying.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelBuying.Image")));
            this.btnCancelBuying.Location = new System.Drawing.Point(332, 101);
            this.btnCancelBuying.Name = "btnCancelBuying";
            this.btnCancelBuying.Size = new System.Drawing.Size(124, 43);
            this.btnCancelBuying.TabIndex = 3;
            this.btnCancelBuying.Text = "Cancel";
            this.btnCancelBuying.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelBuying.UseVisualStyleBackColor = false;
            this.btnCancelBuying.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinishShop
            // 
            this.btnFinishShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnFinishShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinishShop.FlatAppearance.BorderSize = 0;
            this.btnFinishShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFinishShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishShop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishShop.ForeColor = System.Drawing.Color.White;
            this.btnFinishShop.Image = ((System.Drawing.Image)(resources.GetObject("btnFinishShop.Image")));
            this.btnFinishShop.Location = new System.Drawing.Point(169, 101);
            this.btnFinishShop.Name = "btnFinishShop";
            this.btnFinishShop.Size = new System.Drawing.Size(124, 43);
            this.btnFinishShop.TabIndex = 2;
            this.btnFinishShop.Text = "Finish";
            this.btnFinishShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinishShop.UseVisualStyleBackColor = false;
            this.btnFinishShop.Click += new System.EventHandler(this.btnFinishShop_Click);
            // 
            // txtPriceTotalSale
            // 
            this.txtPriceTotalSale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPriceTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceTotalSale.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceTotalSale.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPriceTotalSale.Location = new System.Drawing.Point(132, 44);
            this.txtPriceTotalSale.Name = "txtPriceTotalSale";
            this.txtPriceTotalSale.ReadOnly = true;
            this.txtPriceTotalSale.Size = new System.Drawing.Size(359, 30);
            this.txtPriceTotalSale.TabIndex = 1;
            this.txtPriceTotalSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total price:";
            // 
            // dgvShoppingCart
            // 
            this.dgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvShopping_idProd,
            this.dgvShopping_isbn,
            this.dgvShopping_nameProd,
            this.dgvShopping_amount,
            this.dgvShopping_Mountaint});
            this.dgvShoppingCart.Location = new System.Drawing.Point(25, 46);
            this.dgvShoppingCart.Name = "dgvShoppingCart";
            this.dgvShoppingCart.ReadOnly = true;
            this.dgvShoppingCart.RowHeadersVisible = false;
            this.dgvShoppingCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShoppingCart.Size = new System.Drawing.Size(521, 202);
            this.dgvShoppingCart.TabIndex = 1;
            // 
            // dgvShopping_idProd
            // 
            this.dgvShopping_idProd.HeaderText = "Id";
            this.dgvShopping_idProd.Name = "dgvShopping_idProd";
            this.dgvShopping_idProd.ReadOnly = true;
            // 
            // dgvShopping_isbn
            // 
            this.dgvShopping_isbn.HeaderText = "ISBN";
            this.dgvShopping_isbn.Name = "dgvShopping_isbn";
            this.dgvShopping_isbn.ReadOnly = true;
            // 
            // dgvShopping_nameProd
            // 
            this.dgvShopping_nameProd.HeaderText = "Product Name";
            this.dgvShopping_nameProd.Name = "dgvShopping_nameProd";
            this.dgvShopping_nameProd.ReadOnly = true;
            // 
            // dgvShopping_amount
            // 
            this.dgvShopping_amount.HeaderText = "Amount";
            this.dgvShopping_amount.Name = "dgvShopping_amount";
            this.dgvShopping_amount.ReadOnly = true;
            // 
            // dgvShopping_Mountaint
            // 
            this.dgvShopping_Mountaint.HeaderText = "Mountaint";
            this.dgvShopping_Mountaint.Name = "dgvShopping_Mountaint";
            this.dgvShopping_Mountaint.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping cart";
            // 
            // pnlPartSeachProd
            // 
            this.pnlPartSeachProd.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPartSeachProd.Controls.Add(this.pnlQuantProd);
            this.pnlPartSeachProd.Controls.Add(this.dgvSearchProd);
            this.pnlPartSeachProd.Controls.Add(this.panel4);
            this.pnlPartSeachProd.Controls.Add(this.pnlDgvSearchPro);
            this.pnlPartSeachProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPartSeachProd.Location = new System.Drawing.Point(0, 0);
            this.pnlPartSeachProd.Name = "pnlPartSeachProd";
            this.pnlPartSeachProd.Size = new System.Drawing.Size(471, 600);
            this.pnlPartSeachProd.TabIndex = 1;
            // 
            // pnlQuantProd
            // 
            this.pnlQuantProd.Controls.Add(this.txtPriceProd);
            this.pnlQuantProd.Controls.Add(this.label7);
            this.pnlQuantProd.Controls.Add(this.txtAmountProd);
            this.pnlQuantProd.Controls.Add(this.label6);
            this.pnlQuantProd.Controls.Add(this.txtNameProd);
            this.pnlQuantProd.Controls.Add(this.label5);
            this.pnlQuantProd.Controls.Add(this.txtIsbnProd);
            this.pnlQuantProd.Controls.Add(this.label4);
            this.pnlQuantProd.Controls.Add(this.txtIdProd);
            this.pnlQuantProd.Controls.Add(this.label3);
            this.pnlQuantProd.Controls.Add(this.btnCancelAddCart);
            this.pnlQuantProd.Controls.Add(this.btnAddToCart);
            this.pnlQuantProd.Location = new System.Drawing.Point(22, 326);
            this.pnlQuantProd.Name = "pnlQuantProd";
            this.pnlQuantProd.Size = new System.Drawing.Size(428, 262);
            this.pnlQuantProd.TabIndex = 2;
            // 
            // txtPriceProd
            // 
            this.txtPriceProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPriceProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceProd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtPriceProd.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPriceProd.Location = new System.Drawing.Point(294, 96);
            this.txtPriceProd.Name = "txtPriceProd";
            this.txtPriceProd.Size = new System.Drawing.Size(77, 23);
            this.txtPriceProd.TabIndex = 14;
            this.txtPriceProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceProd_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(221, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price R$:";
            // 
            // txtAmountProd
            // 
            this.txtAmountProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAmountProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountProd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtAmountProd.ForeColor = System.Drawing.Color.DarkRed;
            this.txtAmountProd.Location = new System.Drawing.Point(76, 96);
            this.txtAmountProd.Name = "txtAmountProd";
            this.txtAmountProd.Size = new System.Drawing.Size(121, 23);
            this.txtAmountProd.TabIndex = 12;
            this.txtAmountProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountProd.TextChanged += new System.EventHandler(this.txtAmountProd_TextChanged);
            this.txtAmountProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountProd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(3, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount:";
            // 
            // txtNameProd
            // 
            this.txtNameProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNameProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameProd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtNameProd.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNameProd.Location = new System.Drawing.Point(122, 60);
            this.txtNameProd.Name = "txtNameProd";
            this.txtNameProd.ReadOnly = true;
            this.txtNameProd.Size = new System.Drawing.Size(292, 23);
            this.txtNameProd.TabIndex = 10;
            this.txtNameProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(3, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Name:";
            // 
            // txtIsbnProd
            // 
            this.txtIsbnProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIsbnProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsbnProd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtIsbnProd.ForeColor = System.Drawing.Color.DarkRed;
            this.txtIsbnProd.Location = new System.Drawing.Point(156, 25);
            this.txtIsbnProd.Name = "txtIsbnProd";
            this.txtIsbnProd.ReadOnly = true;
            this.txtIsbnProd.Size = new System.Drawing.Size(258, 23);
            this.txtIsbnProd.TabIndex = 8;
            this.txtIsbnProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(109, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "ISBN:";
            // 
            // txtIdProd
            // 
            this.txtIdProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtIdProd.ForeColor = System.Drawing.Color.DarkRed;
            this.txtIdProd.Location = new System.Drawing.Point(35, 25);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.ReadOnly = true;
            this.txtIdProd.Size = new System.Drawing.Size(68, 23);
            this.txtIdProd.TabIndex = 6;
            this.txtIdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            // 
            // btnCancelAddCart
            // 
            this.btnCancelAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(10)))), ((int)(((byte)(17)))));
            this.btnCancelAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAddCart.FlatAppearance.BorderSize = 0;
            this.btnCancelAddCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancelAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddCart.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelAddCart.Image")));
            this.btnCancelAddCart.Location = new System.Drawing.Point(290, 153);
            this.btnCancelAddCart.Name = "btnCancelAddCart";
            this.btnCancelAddCart.Size = new System.Drawing.Size(124, 43);
            this.btnCancelAddCart.TabIndex = 4;
            this.btnCancelAddCart.Text = "Cancel";
            this.btnCancelAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelAddCart.UseVisualStyleBackColor = false;
            this.btnCancelAddCart.Click += new System.EventHandler(this.btnCancelAddCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.Location = new System.Drawing.Point(19, 153);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(223, 43);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add the shopping cart";
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dgvSearchProd
            // 
            this.dgvSearchProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProd.Location = new System.Drawing.Point(22, 104);
            this.dgvSearchProd.Name = "dgvSearchProd";
            this.dgvSearchProd.RowHeadersVisible = false;
            this.dgvSearchProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchProd.Size = new System.Drawing.Size(428, 142);
            this.dgvSearchProd.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mtxtSearchBookSale);
            this.panel4.Controls.Add(this.btnSearchBookSale);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 98);
            this.panel4.TabIndex = 0;
            // 
            // mtxtSearchBookSale
            // 
            this.mtxtSearchBookSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtSearchBookSale.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.mtxtSearchBookSale.Location = new System.Drawing.Point(22, 46);
            this.mtxtSearchBookSale.Mask = "ISBN 000-000000000-0";
            this.mtxtSearchBookSale.Name = "mtxtSearchBookSale";
            this.mtxtSearchBookSale.Size = new System.Drawing.Size(371, 27);
            this.mtxtSearchBookSale.TabIndex = 4;
            // 
            // btnSearchBookSale
            // 
            this.btnSearchBookSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnSearchBookSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBookSale.FlatAppearance.BorderSize = 0;
            this.btnSearchBookSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearchBookSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBookSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBookSale.ForeColor = System.Drawing.Color.White;
            this.btnSearchBookSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBookSale.Image")));
            this.btnSearchBookSale.Location = new System.Drawing.Point(399, 43);
            this.btnSearchBookSale.Name = "btnSearchBookSale";
            this.btnSearchBookSale.Size = new System.Drawing.Size(51, 33);
            this.btnSearchBookSale.TabIndex = 3;
            this.btnSearchBookSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchBookSale.UseVisualStyleBackColor = false;
            this.btnSearchBookSale.Click += new System.EventHandler(this.btnSearchBookSale_Click);
            // 
            // pnlDgvSearchPro
            // 
            this.pnlDgvSearchPro.Location = new System.Drawing.Point(22, 104);
            this.pnlDgvSearchPro.Name = "pnlDgvSearchPro";
            this.pnlDgvSearchPro.Size = new System.Drawing.Size(428, 216);
            this.pnlDgvSearchPro.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "%";
            // 
            // FmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pnlPartSeachProd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmSale";
            this.Text = "Sale";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCalcDiscount.ResumeLayout(false);
            this.pnlCalcDiscount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).EndInit();
            this.pnlPartSeachProd.ResumeLayout(false);
            this.pnlQuantProd.ResumeLayout(false);
            this.pnlQuantProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelBuying;
        private System.Windows.Forms.Button btnFinishShop;
        private System.Windows.Forms.TextBox txtPriceTotalSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShoppingCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_nameProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShopping_Mountaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPartSeachProd;
        private System.Windows.Forms.Panel pnlQuantProd;
        private System.Windows.Forms.TextBox txtPriceProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsbnProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelAddCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dgvSearchProd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearchBookSale;
        private System.Windows.Forms.Panel pnlDgvSearchPro;
        private System.Windows.Forms.MaskedTextBox mtxtSearchBookSale;
        private System.Windows.Forms.CheckBox cbApplyDiscount;
        private System.Windows.Forms.Panel pnlCalcDiscount;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.Label label8;
    }
}