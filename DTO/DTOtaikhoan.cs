using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOtaikhoan
    {
        private string manv, matkhau, ten, sdt, gt, mail, dc, chucvu;

        public string get_MaNV {  get {  return manv; } set {  manv = value; } }

        public string get_MK { get { return matkhau; } set {  matkhau = value; } }

        public string get_Ten { get { return ten; } set {  ten = value; } }

        public string get_Sdt { get {  return sdt; } set {  sdt = value; } }

        public string get_GT { get { return gt; } set { gt = value; } }

        public string get_Mail { get {  return mail; } set { mail = value; } }

        public string get_Dc { get { return dc;  } set { dc = value; } }

        public string get_Chucvu { get {  return chucvu; } set {  chucvu = value; } }

        public DTOtaikhoan(string manv, string matkhau, string ten, string sdt, string gt, string mail, string dc, string chucvu) 
        {
            this.manv = manv;
            this.matkhau = matkhau;
            this.ten = ten;
            this.sdt = sdt;
            this.gt = gt;
            this.mail = mail;
            this.dc = dc;
            this.chucvu = chucvu;
        }
    }
}
