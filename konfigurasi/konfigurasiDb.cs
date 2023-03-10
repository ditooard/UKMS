using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UKMS.konfigurasi
{
    abstract class konfigurasiDb
    {
        //Untuk menangani instruksi INSERT, UPDATE, DELETE
        public abstract int eksekusiNonQuery(String query);

        //untuk menangani SELECT
        public abstract DataTable eksekusiQuery(String query);
    }
}