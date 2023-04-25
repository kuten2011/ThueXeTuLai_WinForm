
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOchuxe
    {
        private string maCX, tenCX, sdt, gt, email, cccd, dc;

        public string get_MCX { get { return maCX; } set { maCX = value; } }

        public string get_TCX { get { return tenCX; } set { tenCX = value; } }

        public string get_SDT { get { return sdt; } set { sdt = value; } }

        public string get_GT { get { return gt; } set { gt = value; } }

        public string get_EM { get { return email; } set { email = value; } }

        public string get_CCCD { get { return cccd; } set { cccd = value; } }

        public string get_DC { get { return dc; } set { dc = value; } }

        public DTOchuxe(string maCX, string tenCX, string sdt, string gt, string email, string cccd, string dc)
        {
            this.maCX = maCX;
            this.tenCX = tenCX;
            this.sdt = sdt;
            this.gt = gt;
            this.email = email;
            this.cccd = cccd;
            this.dc = dc;
        }
    }
}
