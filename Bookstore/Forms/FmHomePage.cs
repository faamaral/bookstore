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
    public partial class FmHomePage : Form
    {
        public FmHomePage()
        {
            InitializeComponent();
        }

        private void timerHomepage_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FmHomePage_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDateHomePage.Text = date.ToLongDateString();
        }
    }
}
