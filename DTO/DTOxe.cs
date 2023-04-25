using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOxe
    {
        string maxe, hangxe, tenxe, machuxe, biensoxe, nhieulieu, hopso, ngoaihinh, tinhtrang;
        int giathue;

        public string get_MaXe { get { return maxe; }  set { maxe = value; } }

        public string get_HangXe { get { return hangxe; }  set { hangxe = value; } }

        public string get_TenXe { get { return tenxe; } set { tenxe = value; } }

        public string get_MaChuXe { get { return machuxe; } set { machuxe = value; } }

        public string get_BienSoXe { get { return biensoxe; } set { biensoxe = value; } }

        public string get_NhienLieu { get { return nhieulieu; } set { nhieulieu = value; } }

        public string get_HopSo { get { return hopso; } set { hopso = value; } }

        public string get_NgoaiHinh { get {  return ngoaihinh; } set { ngoaihinh = value; } }

        public string get_TinhTrang { get { return tinhtrang; } set { tinhtrang = value; } }

        public int get_GiaThue { get { return giathue; } set { giathue = value; } }

        public DTOxe(string maxe, string hangxe, string tenxe, string machuxe, 
            string biensoxe, string nhieulieu, string hopso, string ngoaihinh, string tinhtrang, int giathue)
        {
            this.maxe = maxe;
            this.hangxe = hangxe;
            this.tenxe = tenxe;
            this.machuxe = machuxe;
            this.biensoxe = biensoxe;
            this.nhieulieu = nhieulieu;
            this.hopso = hopso;
            this.ngoaihinh = ngoaihinh;
            this.tinhtrang = tinhtrang;
            this.giathue = giathue;
        }
    }
}
