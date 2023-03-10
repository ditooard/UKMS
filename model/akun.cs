
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
using System.Collections;

namespace UKMS.model
{
    internal class akun
    {
        layananDb dbServer;
        DataTable temp;
        string query;

        private String _username;
        private String _password;
        private String _email;
        private String _level;
        private String _npm;
        private String _nama;
        private String _jenkel;
        private String _prodi;
        private String _semester;
        private String _alamat;

        public akun()
        {
            dbServer = new layananDb();
            temp = new DataTable();

            _username = "";
            _password = "";
            _email = "";
            _level = "";
            _npm = "";
            _nama = "";
            _jenkel = "";
            _prodi = "";
            _semester = "";
            _alamat = "";
        }


        public String Username
        {
            set { _username = value; }
        }

        public String Password
        {
            set { _password = value; }
        }

        public String Email
        {
            set { _email = value; }
        }

        public String Level
        {
            set { _level = value; }
        }

        public String Npm
        {
            set { _npm = value; }
        }

        public String Nama
        {
            set { _nama = value; }
        }

        public String Jenkel
        {
            set { _jenkel = value; }
        }

        public String Prodi
        {
            set { _prodi = value; }
        }

        public String Semester
        {
            set { _semester = value; }
        }
        public String Alamat
        {
            set { _alamat = value; }
        }

        public bool cekUsername(string user)
        {
            bool cek = false;
            query = "select*from akun where username='" + user + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public string dUsername(string user)
        {
            string nama = "";
            query = "select*from akun where username='" + user + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow dr in temp.Rows)
                {
                    nama = dr[0].ToString();
                }
            }
            return nama;
        }

        public void simpanData()
        {
            query = "insert into akun values('" + _username + "','" +_password + "','"+ _email + "','"+ _level +"','" + _npm + "','" +_nama + "','" + _jenkel + "','" + _prodi + "','" + _semester + "','" + _alamat + "')";

            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public void simpanDataPetugas()
        {
            query = "insert into akun values('" + _username + "','" + _password + "','" + _email + "','" + "Petugas" + "','" + _npm + "','" + _nama + "','" + _jenkel + "','" + _prodi + "','" + _semester + "','" + _alamat + "')";

            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public void simpanDataPasien()
        {
            query = "insert into akun values('" + _username + "','" + _password + "','" + _email + "','" + "Pasien" + "','" + _npm + "','" + _nama + "','" + _jenkel + "','" + _prodi + "','" + _semester + "','" + _alamat + "')";

            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public bool cekLogin(string user, string password, string level)
        {
            bool cek = false;
            query = "select *from akun where " + "username ='" + user + "' and password='" + password + "'and level='" + level + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public bool cekEmail(string email)
        {
            bool cek = false;
            query = "select*from akun where email='" + email + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public DataTable tampilSemuaPetugas()
        {
            query = "select*from akun where level ='Petugas'";
            return dbServer.eksekusiQuery(query);
        }

        public DataTable tampilSemuaPasien()
        {
            query = "select*from akun where level ='Pasien'";
            return dbServer.eksekusiQuery(query);
        }

        public bool cekUser(string username)
        {
            bool cek = false;
            query = "select*from akun where username='" + username + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public string namaUser(string username, string pass)
        {
            string nama = "";
            query = "select username from akun where username='" + username + "' and password='"+pass+"'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach(DataRow dr in temp.Rows)
                {
                    nama = dr[0].ToString();
                }
            }
            return nama;
        }
        public string emailUser(string username, string pass)
        {
            string nama = "";
            query = "select username from akun where username='" + username + "' and password='" + pass + "'";
            temp = dbServer.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow dr in temp.Rows)
                {
                    nama = dr[0].ToString();
                }
            }
            return nama;
        }

        public void ubahDataPetugas(String username)
        {
            query = "update akun set npm = '" + _npm +
                    "', password = '" + _password +
                    "', email = '" + _email + 
                    "', nama = '" + _nama +
                    "', jenkel = '" + _jenkel +
                    "', level = 'Petugas',  prodi = '" + _prodi +
                    "', semester = '" + _semester +
                    "', alamat = '"+_alamat+
                    "' where username = '"+username+"'";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public void hapusData(String username)
        {
            query = "delete from akun where username ='" + username + "'";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public void ubahDataPasien(String username)
        {
            query = "update akun set npm = '" + _npm +
                    "', password = '" + _password +
                    "', email = '" + _email +
                    "', nama = '" + _nama +
                    "', jenkel = '" + _jenkel +
                    "', level = 'Pasien',  prodi = '" + _prodi +
                    "', semester = '" + _semester +
                    "', alamat = '" + _alamat +
                    "' where username = '" + username + "'";
            if (!(dbServer.eksekusiNonQuery(query) > 0))
            {
                throw new Exception("Proses Insert gagal");
            }
        }

        public DataTable tampilSemua()
        {
            query = "select*from akun";
            return dbServer.eksekusiQuery(query);
        }

        public DataTable tampilByNamaPetugas(string nama)
        {
            DataTable data = new DataTable();
            query = "select*from akun where level ='Petugas' and  nama like '%" + nama + "%'";
            return dbServer.eksekusiQuery(query);
        }

        public DataTable tampilByNamaPasien(string nama)
        {
            DataTable data = new DataTable();
            query = "select*from akun where level ='Pasien' and nama like '%" + nama + "%'";
            return dbServer.eksekusiQuery(query);
        }

        public DataTable tampilBerelasi(string user)
        {
            query = "SELECT*FROM akun WHERE username = '" + user + "'";

            return dbServer.eksekusiQuery(query);
        }
    }
}
