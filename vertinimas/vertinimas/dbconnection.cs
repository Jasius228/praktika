using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace vertinimas
{
    internal class dbconnection
    {
        public MySqlConnection cn;
        public void Connect()
        {
            cn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=destytojai");
        }
    }
}
