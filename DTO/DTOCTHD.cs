using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class DTOCTHD
    {
        private string mahoadon, maxe, tenxe, machuxe;
        int dongia;

        public string get_MaHD { get { return mahoadon; } set {  mahoadon = value; } }

        public string get_Maxe { get { return maxe; } set { maxe = value; } }

        public string get_Tenxe { get {  return tenxe; } set {  tenxe = value; } }

        public string get_MaCX { get { return machuxe; } set { machuxe = value; } }

        public int get_Dongia { get {  return dongia; } set {  dongia = value; } }

        public DTOCTHD(string mahoadon, string maxe, string tenxe, string machuxe,int dongia) 
        {
            this.mahoadon = mahoadon;
            this.maxe = maxe;
            this.tenxe = tenxe;
            this.machuxe = machuxe;
            this.dongia = dongia;
        }
    }
}
