using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL2_10_TICKETING
{
    class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("server=127.0.0.1;port=5432;Database=db_tiket_XII_RPL_2_10;" + "User Id=postgres;password=admin;");
    }
}
