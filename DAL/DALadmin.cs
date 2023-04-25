using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class DALadmin
    {
        private DTOadmin a;

        public DALadmin(string user, string password) 
        {
            a = new DTOadmin(user, password);
        }

        public string checkInfo()
        {
            string s = "SELECT * FROM Taikhoan WHERE mataikhoan = '" + a.get_User+"' ";
            try
            {
                DataTable dt = Connection.selectQuery(s);
                if (dt.Rows[0][1].ToString().Equals(a.get_Password))
                {
                    return dt.Rows[0][7].ToString();

                }
                else
                {
                    return s;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return s;
            }
        }
     }
}
