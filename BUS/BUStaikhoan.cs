using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUStaikhoan
    {
        DALtaikhoan t;

        public BUStaikhoan(string manv, string matkhau, string ten, string sdt, string gt, string mail, string dc, string chucvu)
        {
            t = new DALtaikhoan(manv, matkhau, ten, sdt, gt, mail, dc, chucvu);
        }

        public bool addTK() { return t.addTK(); }

        public bool delTK() { return t.delTK(); }

        public bool editTK() { return  t.editTK(); }

        public string autoID(string id) { return t.autoID(id); }   

        public DataTable selectCV() { return t.selectCV(); }

        public DataTable selectTK() { return t.selectTK(); }
    }
}
