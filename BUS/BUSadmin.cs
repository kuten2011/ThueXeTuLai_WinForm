using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSadmin
    {
        private DALadmin a;

        public BUSadmin(string user, string password)
        {
            a = new DALadmin(user, password);
        }

        public string checkInfo() { return a.checkInfo(); }
    }
}
