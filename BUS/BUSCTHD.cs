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
    public class BUSCTHD
    {
        private DALCTHD ct;

        public BUSCTHD(string mahoadon, string maxe, string tenxe, string machuxe, int dongia)
        {
            ct = new DALCTHD(mahoadon, maxe, tenxe, machuxe, dongia);
        }

        public bool addCTHD() { return ct.addCTHD(); }

        public bool delCTHD() { return ct.delCTHD(); }

        public bool delAllCTHD() { return ct.delAllCTHD(); }

        public DataTable selectCTHD() { return ct.selectCTHD(); }
    }
}
