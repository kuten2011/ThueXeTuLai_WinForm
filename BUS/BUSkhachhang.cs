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
    public class BUSkhachhang
    {
        private DALkhachhang k;

        public BUSkhachhang(string maKH, string tenKH, string sdt, string gt, string email, string cccd, string dc)
        {
            k = new DALkhachhang(maKH, tenKH, sdt, gt, email, cccd, dc);
        }

        public bool addKH() { return k.addKH(); }

        public bool delKH() { return k.delKH(); }

        public bool editKH() { return k.editKH(); }

        public string autoID(string id) { return k.autoID(id); }

        public DataTable selectKH() { return k.selectKH(); }
    }
}
