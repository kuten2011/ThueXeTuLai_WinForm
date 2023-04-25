using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOadmin
    {
        private string user, password;

        public string get_User { get { return user; } set { user = value; } }

        public string get_Password { get { return password; } set { password = value; } }

        public DTOadmin(string user, string password) 
        {
            this.user = user;   
            this.password = password;
        }
    }
}
