using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    class KtraUser
    {
        public static int Ktra(String user, String pass)
        {
            Model1 model = new Model1();
            var ls = model.Users.Where(e => e.username == user && e.password==pass);
            if (ls != null)
                return 1;
            else return 0;
        }
    }
}
