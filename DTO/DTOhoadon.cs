using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOhoadon
    {
        private string mahoadon, manhanvien, makhachhang, nhanxe, ngaythue, ngaytra, httt;
        private int tongtien;

        public string get_MaHD { get { return mahoadon; } set {  mahoadon = value; } }

        public string get_MaNV { get {  return manhanvien; } set {  manhanvien = value; } }

        public int get_TT { get { return tongtien; } set { tongtien = value; } }

        public string get_MaKH { get { return makhachhang; } set { makhachhang = value; } }

        public string get_NX { get { return nhanxe; } set { nhanxe = value; } }

        public string get_NT { get {  return ngaythue; } set {  ngaythue = value; } }

        public string get_NTA { get { return ngaytra; } set { ngaytra = value; } }

        public string get_HTTT { get { return  httt; } set { httt = value; } }

        public DTOhoadon(string mahoadon, string manhanvien, string makhachhang, 
            string nhanxe, string ngaythue, string ngaytra, string httt, int tongtien)
        {
            this.mahoadon = mahoadon;
            this.manhanvien = manhanvien;
            this.makhachhang = makhachhang;
            this.nhanxe = nhanxe;
            this.ngaythue = ngaythue;
            this.ngaytra = ngaytra;
            this.httt = httt;
            this.tongtien = tongtien;
        }
    }
}
