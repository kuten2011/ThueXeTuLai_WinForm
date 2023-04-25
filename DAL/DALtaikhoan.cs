using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALtaikhoan
    {
        DTOtaikhoan t;

        public DALtaikhoan(string manv, string matkhau, string ten, string sdt, string gt, string mail, string dc, string chucvu)
        {
            t = new DTOtaikhoan(manv, matkhau, ten, sdt, gt, mail, dc, chucvu);
        }

        public bool addTK()
        {
            string s = "INSERT INTO Taikhoan VALUES ('"+t.get_MaNV+"', '"+t.get_MK+"', N'"+t.get_Ten+"', '"+t.get_Sdt+"', " +
                "N'"+t.get_GT+"', '"+t.get_Mail+"', N'"+t.get_Dc+"', '"+t.get_Chucvu+"')";
            return Connection.actionQuery(s);
        }

        public bool delTK()
        {
            string s = "DELETE FROM Taikhoan WHERE mataikhoan = '"+t.get_MaNV+"'";
            return Connection.actionQuery(s);
        }

        public bool editTK()
        {
            string s = "UPDATE Taikhoan SET matkhau = '"+t.get_MK+ "' ,ten = N'"+t.get_Ten+ "' " +
                ",sodienthoai = '"+t.get_Sdt+"' ,gioitinh = N'"+t.get_GT+ "' ,email='"+t.get_Mail+ "' " +
                ",diachi= N'"+t.get_Dc+"' ,chucvu='"+t.get_Chucvu+"' WHERE mataikhoan = '" + t.get_MaNV + "'";
            return Connection.actionQuery(s);
        }

        public string autoID(string ID)
        {
            string s = "select top 1 mataikhoan from Taikhoan Where chucvu = '"+t.get_Chucvu+ "' order by mataikhoan desc";
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
            } catch
            {
                return s;
            }
        }

        public DataTable selectCV()
        {
            string s = "SELECT * FROM Taikhoan WHERE chucvu = '"+t.get_Chucvu+"'";
            return Connection.selectQuery(s);
        }

        public DataTable selectTK()
        {
            string s = "SELECT * FROM Taikhoan";
            return Connection.selectQuery(s);
        }
    }
}
