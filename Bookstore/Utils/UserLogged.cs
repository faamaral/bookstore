using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Utils
{
    public class UserLogged
    {
        private string user_logged;

        public void setUserLogged(string v)
        {
            this.user_logged = v;
        }

        public string getUserLogged()
        {
            return user_logged;
        }
    }
}
