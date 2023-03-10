using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using UKMS.model;

namespace UKMS.view
{
    public partial class petugas : Form
    {
        string user;
        akun akun = new akun();
        public petugas(string user)
        {
            this.user = user;
            InitializeComponent();
        }


        void isiData()
        {
            DataTable data = new DataTable();
            data = akun.tampilBerelasi(usernameTxt.Text);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    passwordTxt.Text = dt[1].ToString();
                    emailTxt.Text = dt[2].ToString();
                    npmTxt.Text = dt[4].ToString();
                    namaTxt.Text = dt[5].ToString();
                    jenkelCbox.Text = dt[6].ToString();
                    prodiCbox.Text = dt[7].ToString();
                    semesterCbox.Text = dt[8].ToString();
                    alamatTxt.Text = dt[9].ToString();
                }
            }
        }

        private void petugas_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = user;
            prodiCbox.Items.Add("Teknik Elektronika");
            prodiCbox.Items.Add("Teknik Informatika");
            prodiCbox.Items.Add("Teknik Mesin");
            prodiCbox.Items.Add("Teknik Listrik");
            prodiCbox.Items.Add("Teknik Pengendalian Pencemaran Lingkungan");
            prodiCbox.Items.Add("Teknik Pengembangan Produk Agroindustri");
            prodiCbox.Items.Add("Rekayasa Keamanan Siber");
            semesterCbox.Items.Add("1");
            semesterCbox.Items.Add("2");
            semesterCbox.Items.Add("3");
            semesterCbox.Items.Add("4");
            semesterCbox.Items.Add("5");
            semesterCbox.Items.Add("6");
            semesterCbox.Items.Add("7");
            semesterCbox.Items.Add("8");
            jenkelCbox.Items.Add("Laki - Laki");
            jenkelCbox.Items.Add("Perempuan");
            isiData();
        }

        

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            if (akun.cekUsername(usernameTxt.Text))
            {
                if (MessageBox.Show("Data akan diubah ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    akun.Password = passwordTxt.Text;
                    akun.Email = emailTxt.Text;
                    akun.Npm = npmTxt.Text;
                    akun.Nama = namaTxt.Text;
                    akun.Jenkel = jenkelCbox.Text;
                    akun.Prodi = prodiCbox.Text;
                    akun.Semester = semesterCbox.Text;
                    akun.Alamat = alamatTxt.Text;
                    akun.ubahDataPetugas(usernameTxt.Text);
                    MessageBox.Show("Data berhasil diubah", "IFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usernameTxt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Data gagal diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Focus();
            }
        }
    }
}
