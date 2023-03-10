using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UKMS.konfigurasi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UKMS.model
{
    internal class keluhan
    {
        layananDb dbServer;
        DataTable temp;
        string query;

        private String _npm;
        private String _tanggal;
        private String _diagnosa;
        private String _catatan;
        private String _jenis_obat;

        public keluhan()
        {
            dbServer = new layananDb();
            temp = new DataTable();

            _npm = "";
            _tanggal = "";
            _diagnosa = "";
            _catatan = "";
            _jenis_obat = "";
        }

        public String Npm 
        {
            set { _npm = value; } //mutator
        }

        public String Tanggal
        {
            set { _tanggal = value; } //
        }

        public String Diagnosa
        {
            set { _diagnosa = value; }
        }

        public String Catatan
        {
            set { _catatan = value; }
        }

        public String jenisObat
        {
            set { _jenis_obat = value; }
        }

        public bool cekNpm(string npm)
        {
            bool cek = false;
            query = "select*from akun where npm='" + npm + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void simpanData()
        {
            query = "insert into keluhan values('" + _npm + "','" + _tanggal + "','" + _jenis_obat + "','" + _diagnosa + "','" + _catatan + "')";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }
        public void hapusData(String npm)
        {
            query = "delete from keluhan where npm ='" + npm + "'";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }
        public void ubahDataKeluhan(String npm)
        {
            query = "update keluhan set npm = '" + _npm +
                    "', tanggal = '" + _tanggal +
                    "', jenis_obat = '" + _jenis_obat +
                    "', diagnosa = '" + _diagnosa +
                    "', catatan = '" + _catatan +
                    "' where npm = '" + npm + "'";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public DataTable tampilSemuaKeluhan()
        {
            query = "select*from keluhan";
            return dbServer.eksekusiQuery(query);
        }
        public DataTable tampilSemuaKeluhanPasien(string npm)
        {
            query = "select*from keluhan where npm = '"+npm+"'";
            return dbServer.eksekusiQuery(query);
        }

        public DataTable tampilByNpm(string npm)
        {
            DataTable data = new DataTable();
            query = "select*from keluhan where npm like '%" + npm + "%'";
            return dbServer.eksekusiQuery(query);
        }


    }
}