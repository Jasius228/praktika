using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace vertinimas
{
    internal class dbconnectionstud
    {
        public MySqlConnection cd;
        public void Connect()
        {
            cd = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=vartotojai");
        }
    }
}
