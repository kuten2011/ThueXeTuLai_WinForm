using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOkhachhang
    {
        private string MaKH, TenKH, sdt, gt, email, cccd, dc;

        public string get_MaKH {  get { return MaKH; } set {  MaKH = value; } }

        public string get_TenKH { get { return TenKH; } set {  TenKH = value; } }

        public string get_Sdt { get {  return sdt; } set {  sdt = value; } }

        public string get_gt { get {  return gt; } set { gt = value; } }

        public string get_email { get {  return email; } set { email = value; } }

        public string get_cccd { get {  return cccd; } set {  cccd = value; } }

        public string get_dc { get {  return dc; } set { dc = value; } }

        public DTOkhachhang(string maKH, string tenKH, string sdt, string gt, string email, string cccd, string dc)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.sdt = sdt;
            this.gt = gt;
            this.email = email;
            this.cccd = cccd;
            this.dc = dc;
        }
    }
}
