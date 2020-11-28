using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class UserRegisteration
    {
        private string p_name, p_id, p_email, p_password, p_repassword;

        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }

        public string P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }

        public string P_email
        {
            get { return p_email; }
            set { p_email = value; }
        }


        public string P_password
        {
            get { return p_password; }
            set { p_password = value; }
        }

        public string P_repassword
        {
            get { return p_repassword; }
            set { p_repassword = value; }
        }

    }
}
