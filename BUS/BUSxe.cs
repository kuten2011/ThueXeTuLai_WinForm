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
    public class BUSxe
    {
        private DALxe x;

        public BUSxe(string maxe, string hangxe, string tenxe, string machuxe, string
            biensoxe, string nhieulieu, string hopso, string ngoaihinh, string tinhtrang, int giathue)
        {
            x = new DALxe(maxe, hangxe, tenxe, machuxe, biensoxe, nhieulieu, hopso, ngoaihinh, tinhtrang, giathue);
        }

        public bool addXe() { return x.addXe(); }

        public bool delXe() { return x.delXe(); }

        public bool editXe() { return x.editXe(); }

        public bool updateSTX() { return x.updateSTX(); }

        public string autoID(string id) { return x.autoID(id); }

        public DataTable selectXe() { return x.selectXe(); }
    }
}
