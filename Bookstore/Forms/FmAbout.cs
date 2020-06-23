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
    public partial class FmAbout : Form
    {
        public FmAbout()
        {
            InitializeComponent();
        }

        

        private void pbLinkFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/FaAmarall/");
        }

        private void pbLinkFacebook_MouseHover(object sender, EventArgs e)
        {
            pbLinkFacebook.Width = 40;
            pbLinkFacebook.Height = 40;
        }

        private void pbLinkFacebook_MouseLeave(object sender, EventArgs e)
        {
            pbLinkFacebook.Width = 35;
            pbLinkFacebook.Height = 35;
        }

        private void pbLinkInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/faahamaral_/");
        }

        private void pbLinkInstagram_MouseHover(object sender, EventArgs e)
        {
            pbLinkInstagram.Width = 40;
            pbLinkInstagram.Height = 40;
        }

        private void pbLinkInstagram_MouseLeave(object sender, EventArgs e)
        {
            pbLinkInstagram.Width = 35;
            pbLinkInstagram.Height = 35;
        }

        private void pbLinkTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/blzfa");
        }

        private void pbLinkGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/faamaral");
        }

        private void pbLinkTwitter_MouseHover(object sender, EventArgs e)
        {
            pbLinkTwitter.Width = 40;
            pbLinkTwitter.Height = 40;
        }

        private void pbLinkTwitter_MouseLeave(object sender, EventArgs e)
        {
            pbLinkTwitter.Width = 35;
            pbLinkTwitter.Height = 35;
        }

        private void pbLinkGithub_MouseHover(object sender, EventArgs e)
        {
            pbLinkGithub.Width = 40;
            pbLinkGithub.Height = 40;
        }

        private void pbLinkGithub_MouseLeave(object sender, EventArgs e)
        {
            pbLinkGithub.Width = 35;
            pbLinkGithub.Height = 35;
        }
    }
}
