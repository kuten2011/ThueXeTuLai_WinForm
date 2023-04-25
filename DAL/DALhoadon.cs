using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALhoadon
    {
        private DTOhoadon h;

        public DALhoadon(string mahoadon, string manhanvien, string makhachhang,
            string nhanxe, string ngaythue, string ngaytra, string httt, int tongtien)
        {
            h = new DTOhoadon(mahoadon, manhanvien, makhachhang, nhanxe, ngaythue, ngaytra, httt, tongtien);
        }

        public bool addHD()
        {
            string s = "INSERT INTO hoadon VALUES ('"+h.get_MaHD+"', '"+h.get_MaNV+"', '"+h.get_MaKH+"'," +
                " '"+h.get_NX+"', '"+h.get_NT+"', '"+h.get_NTA+"', '"+h.get_HTTT+"', '"+h.get_TT+"')";
            return Connection.actionQuery(s);
        }

        public bool delHD()
        {
            string s = "DELETE FROM hoadon WHERE mahoadon = '"+h.get_MaHD+"'";
            return Connection.actionQuery(s);
        }

        public bool editHD()
        {
            string s = "UPDATE hoadon SET manhanvien = '" + h.get_MaNV + "', " +
                "makhachhang = '" + h.get_MaKH + "', nhanxe = '" + h.get_NX + "', ngaythue = '" + h.get_NT + "'," +
                "ngaytra = '" + h.get_NTA + "', hinhthucthanhtoan = '" + h.get_HTTT + "', tongtien ='" + h.get_TT + "' " +
                "WHERE mahoadon = '" + h.get_MaHD + "'";
            return Connection.actionQuery(s);
        }

        public string autoID(string ID)
        {
            string s = "select top 1 mahoadon from hoadon order by mahoadon desc";
            try
            {
                DataTable tb = Connection.selectQuery(s);
                if (tb.Rows.Count > 0)
                {
                    s = tb.Rows[0][0].ToString();
                    s = s.Substring(s.Length - 4, 4);
                    int stt = int.Parse(s) + 1;
                    if (stt < 10)
                        s = ID + "000" + stt.ToString();
                    else if (stt < 100)
                        s = ID + "00" + stt.ToString();
                    else if (stt < 1000)
                        s = ID + "0" + stt.ToString();
                    else
                        s = ID + stt.ToString();
                }
                else
                    s = ID + "0001";
                return s;
            }
            catch
            {
                return s;
            }
        }

        public DataTable selectNT()
        {
            string s = "SELECT DISTINCT ngaythue FROM hoadon";
            return Connection.selectQuery(s);
        }

        public DataTable selectNTA()
        {
            string s = "SELECT DISTINCT ngaytra FROM hoadon WHERE ngaytra >= '"+h.get_NT+"'";
            return Connection.selectQuery(s);
        }

        public DataTable selectLHD()
        {
            string s = "SELECT * FROM hoadon WHERE ngaythue = '"+h.get_NT+"' or ngaytra = '"+h.get_NTA+"'";
            return Connection.selectQuery(s);
        }

        public DataTable selectHD()
        {
            string s = "SELECT * FROM hoadon";
            return Connection.selectQuery(s);
        }
    }
}
