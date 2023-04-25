using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCTHD
    {
        private DTOCTHD ct;

        public DALCTHD(string mahoadon, string maxe, string tenxe, string machuxe,int dongia)
        {
            ct = new DTOCTHD(mahoadon, maxe, tenxe, machuxe, dongia);
        }

        public bool addCTHD()
        {
            string s = "INSERT INTO CTHD VALUES ('"+ct.get_MaHD+"', '"+ct.get_Maxe+"', '"+ct.get_Tenxe+"'," +
                " '"+ct.get_MaCX+"', "+ct.get_Dongia+")";
            return Connection.actionQuery(s);
        }

        public bool delCTHD()
        {
            string s = "DELETE FROM CTHD WHERE maxe = '"+ct.get_Maxe+"'";
            return Connection.actionQuery(s);
        }

        public bool delAllCTHD()
        {
            string s = "DELETE FROM CTHD WHERE mahoadon = '" + ct.get_MaHD + "'";
            return Connection.actionQuery(s);
        }

        public DataTable selectCTHD()
        {
            string s = "SELECT * FROM CTHD WHERE mahoadon = '"+ct.get_MaHD+"'";
            return Connection.selectQuery(s);
        }
    }
}
