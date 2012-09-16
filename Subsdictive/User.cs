using System;
using System.Collections.Generic;
using System.Text;

namespace Subsdictive
{
    class User
    {
        string nick = "";
        string pass = "";
        bool admin = false;

        public string Nick
        {
            get
            {
                return nick;
            }
            set
            {
                nick = value;
            }
        }

        public string Password
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }

        public bool Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }

        public User()
        {
            admin = false;
        }
    }
}
