using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSchuxe
    {
        private DALchuxe c;

        public BUSchuxe(string maCX, string tenCX, string sdt, string gt, string email, string cccd, string dc) 
        {
            c = new DALchuxe(maCX, tenCX, sdt, gt, email, cccd, dc);
        }

        public bool addCX() { return c.addCX(); }

        public bool delCX() { return c.delCX(); }

        public bool editCX() { return c.editCX(); }

        public string autoID(string id) { return c.autoID(id); }

        public DataTable selectCX() { return c.selectCX(); }
    }
}
