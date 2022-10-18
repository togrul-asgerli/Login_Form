using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page
{
    public class Account
    {
        public string username;
        public string password;

        public Account(string user,string pass)
        {
            username = user;
            password = pass;
        }
    }
}
