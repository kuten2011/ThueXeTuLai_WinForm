using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALchuxe
    {
        private DTOchuxe c;

        public DALchuxe(string maCX, string tenCX, string sdt, string gt, string email, string cccd, string dc)
        {
            c = new DTOchuxe(maCX, tenCX, sdt, gt, email, cccd, dc);
        }

        public bool addCX()
        {
            string s = "INSERT INTO chuxe VALUES ('" + c.get_MCX + "', N'" + c.get_TCX + "', '" + c.get_SDT + "'," +
                " N'" + c.get_GT + "', '" + c.get_EM + "', '" + c.get_CCCD + "', N'" + c.get_DC + "')";
            return Connection.actionQuery(s);
        }

        public bool delCX()
        {
            string s = "DELETE FROM chuxe WHERE machuxe = '" + c.get_MCX + "'";
            return Connection.actionQuery(s);
        }

        public bool editCX()
        {
            string s = "UPDATE chuxe SET tenchuxe = N'" + c.get_TCX + "', sodienthoai = '" + c.get_SDT + "', " +
                "gioitinh = N'" + c.get_GT + "', email = '" + c.get_EM + "', cccd = '" + c.get_CCCD + "', " +
                "diachi = N'" + c.get_DC + "' WHERE machuxe = '" + c.get_MCX + "'";
            return Connection.actionQuery(s);
        }

        public string autoID(string ID)
        {
            string s = "select top 1 machuxe from chuxe order by machuxe desc";
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

        public DataTable selectCX()
        {
            string s = "SELECT * FROM chuxe";
            return Connection.selectQuery(s);
        }
    }
}
