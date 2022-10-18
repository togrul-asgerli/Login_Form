using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page
{
     public class Db_Class
    {
        private static Account[] ac = { new Account("togrul", "123456") };

        private static Account account_find(string username)
        {
            foreach (var account in ac)
            {
                if (account.username == username)
                {
                    return account;
                }

            }
            return null;
        }

        public static bool acc_exsist(string username)
        {
            foreach (var account in ac)
            {
                if (account.username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public static Account account_login(string username, string password)
        {
            Account account = account_find(username);
            if (!(account == null) && account.password == password)
            {
                return account;
            }
            return null;
        }
        public static Account account_register(string username,string password)
        {
            if(acc_exsist(username))
            {
                return null;
            }
            Account new_ac = new Account(username, password);
            ac = ac.Append(new_ac).ToArray();
            return new_ac;
        }
    }

}
