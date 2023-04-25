using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALxe
    {
        private DTOxe x;
        public DALxe(string maxe, string hangxe, string tenxe, string machuxe, string
            biensoxe, string nhieulieu, string hopso, string ngoaihinh, string tinhtrang, int giathue) 
        {
            x = new DTOxe(maxe, hangxe, tenxe, machuxe, biensoxe, nhieulieu, hopso, ngoaihinh, tinhtrang, giathue);
        }

        public bool addXe()
        {
            string s = "INSERT INTO car VALUES ('"+x.get_MaXe+"', '"+x.get_HangXe+"', '"+x.get_TenXe+"', '"+x.get_MaChuXe+"'," +
                " "+x.get_GiaThue+", '"+x.get_BienSoXe+"', N'"+x.get_NhienLieu+"', N'"+x.get_HopSo+"', N'"+x.get_NgoaiHinh+"'," +
                " N'"+x.get_TinhTrang+"')";
            return Connection.actionQuery(s);
        }

        public bool delXe()
        {
            string s = "DELETE FROM car WHERE maxe = '"+x.get_MaXe+"'";
            return Connection.actionQuery(s);
        }

        public bool editXe()
        {
            string s = "UPDATE car SET hangxe = '"+x.get_HangXe+"', tenxe = '"+x.get_TenXe+"', machuxe = '"+x.get_MaChuXe+"'," +
                "giathue = '"+x.get_GiaThue+"', biensoxe = '"+x.get_BienSoXe+"', nhienlieu = N'"+x.get_NhienLieu+"', " +
                "hopso = N'"+x.get_HopSo+"', ngoaihinh = N'"+x.get_NgoaiHinh+"', tinhtrang = N'"+x.get_TinhTrang+"' WHERE maxe = '" 
                + x.get_MaXe + "'";
            return Connection.actionQuery(s);
        }

        public string autoID(string ID)
        {
            string s = "select top 1 maxe from car order by maxe desc";
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

        public bool updateSTX()
        {
            string s = "UPDATE car SET tinhtrang = 'RENTING' WHERE maxe = '"+ x.get_MaXe + "'";
            return Connection.actionQuery(s);
        }

        public DataTable selectXe()
        {
            string s = "SELECT * FROM car";
            return Connection.selectQuery(s);
        }
    }
}
