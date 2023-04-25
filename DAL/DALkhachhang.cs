using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALkhachhang
    {
        private DTOkhachhang k;

        public DALkhachhang(string maKH, string tenKH, string sdt, string gt, string email, string cccd, string dc) 
        {
            k = new DTOkhachhang(maKH, tenKH, sdt, gt, email, cccd, dc);
        }

        public bool addKH()
        {
            string s = "INSERT INTO khachhang VALUES ('"+k.get_MaKH+"', N'"+k.get_TenKH+"', '"+k.get_Sdt+"', N'"+k.get_gt+"', " +
                "'"+k.get_email+"', '"+k.get_cccd+"', N'" +k.get_dc+"')";
            return Connection.actionQuery(s);
        }

        public bool delKH()
        {
            string s = "DELETE FROM khachhang WHERE makhachhang = '"+k.get_MaKH+"'";
            return Connection.actionQuery(s);
        }

        public bool editKH()
        {
            string s = "UPDATE khachhang SET tenkhachhang = N'" + k.get_TenKH+ "', sodienthoai = '" + k.get_Sdt+ "', " +
                "gioitinh = N'" + k.get_gt+ "', email = '" + k.get_email+ "', cccd = '" + k.get_cccd+ "', diachi = N'" + 
                k.get_dc+ "' WHERE makhachhang = '"+k.get_MaKH+"'";
            return Connection.actionQuery(s);
        }

        public string autoID(string ID)
        {
            string s = "select top 1 makhachhang from khachhang order by makhachhang desc";
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

        public DataTable selectKH()
        {
            string s = "SELECT * FROM khachhang";
            return Connection.selectQuery(s);
        }
    }
}
