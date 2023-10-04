using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Utility
    {
        public static string GetConnection()
        {
            string cns = ConfigurationManager.ConnectionStrings["scn"].ConnectionString;
            return cns;
        }
    }
}
