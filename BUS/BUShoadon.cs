
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
    public class BUShoadon
    {
        private DALhoadon h;

        public BUShoadon(string mahoadon, string manhanvien, string makhachhang,
            string nhanxe, string ngaythue, string ngaytra, string httt, int tongtien)
        {
            h = new DALhoadon(mahoadon, manhanvien, makhachhang, nhanxe, ngaythue, ngaytra, httt, tongtien);
        }

        public bool addHD() { return h.addHD(); }

        public bool delHD() { return h.delHD(); }

        public bool editHD() { return h.editHD(); }

        public string autoID(string id) { return h.autoID(id); }

        public DataTable selectNT() { return h.selectNT(); }

        public DataTable selectNTA() { return h.selectNTA(); }

        public DataTable selectLHD() { return h.selectLHD(); }

        public DataTable select() { return h.selectHD(); }
    }
}
