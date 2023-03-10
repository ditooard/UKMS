using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKMS.konfigurasi;
using System.Data;
using System.CodeDom.Compiler;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace UKMS.model
{
    internal class obat
    {
        layananDb dbServer;
        DataTable temp;
        string query;

        private String _kode_obat;
        private String _nama_obat;
        private String _jenis_obat;

        public obat()
        {
            dbServer = new layananDb();
            temp = new DataTable();
            _kode_obat = "";
            _nama_obat = "";
            _jenis_obat = "";
        }

        public String kodeObat
        {
            set { _kode_obat = value; }
        }

        public String namaObat
        {
            set { _nama_obat = value; }
        }

        public String jenisObat
        {
            set { _jenis_obat = value; }
        }

        public bool cekObat(string obat)
        {
            bool cek = false;
            query = "select*from obat where kode_obat='" + obat + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void simpanObat()
        {
            query = "insert into obat values('" + _kode_obat + "','" + _nama_obat + "','" + _jenis_obat + "')";

            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public DataTable tampilSemuaObat()
        {
            query = "select*from obat";
            return dbServer.eksekusiQuery(query);
        }

        public void ubahDataObat(String kode)
        {
            query = "update obat set kode_obat = '" + _kode_obat +
                    "', nama_obat = '" + _nama_obat +
                    "', jenis_obat = '" + _jenis_obat +
                    "' where kode_obat = '" + kode + "'";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public void hapusData(String kode)
        {
            query = "delete from obat where kode_obat ='" + kode + "'";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public DataTable tampilSemua()
        {
            query = "select*from obat";
            return dbServer.eksekusiQuery(query);
        }

        public DataTable tampilByNama(string nama)
        {
            DataTable data = new DataTable();
            query = "select*from obat where nama_obat like '%" + nama + "%'";
            return dbServer.eksekusiQuery(query);
        }

        public string buatKode()
        {
            string kode = "";
            int idx = 0;

            query = "SELECT IFNULL(MAX(kode_obat),0)+1 as kode FROM obat";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow dt in temp.Rows)
                {
                    idx = Convert.ToInt32(dt[0]);
                }
                if (idx > 0 && idx < 10)
                {
                    kode = "0" + idx.ToString();
                }
                else if (idx >= 10 && idx < 100)
                {
                    kode = idx.ToString();
                }
            }
            return kode;
        }
    }
}
