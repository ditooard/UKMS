using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UKMS.model;
using UKMS.report;

namespace UKMS.view
{
    public partial class kontenPetugas : Form
    {
        akun akun = new akun(); 
        public kontenPetugas()
        {
            InitializeComponent();
        }

        private void kontenPetugas_Load(object sender, EventArgs e)
        {
            tampilData();
            usernameTxt.Focus();
            usernameTxt.Select();
            this.ActiveControl = usernameTxt;
            usernameTxt.Focus();
        }

        void clear()
        {
            usernameTxt.Clear();
            emailTxt.Clear();
            passwordTxt.Clear();
            npmTxt.Clear();
            namaTxt.Clear();
            jenkelCbox.Items.Clear();
            prodiCbox.Items.Clear();
            semesterCbox.Items.Clear();
            alamatTxt.Clear();
        }

        void tampilData()
        {
            dataGridView1.DataSource = akun.tampilSemuaPetugas();
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
        }

        void cariData()
        {
            if (cariTxt.Text == "")
            {
                dataGridView1.DataSource = akun.tampilSemuaPetugas();
            }
            else
            {
                dataGridView1.DataSource = akun.tampilByNamaPetugas(cariTxt.Text);
            }
        }

        

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "" || emailTxt.Text == "" || npmTxt.Text == "" || namaTxt.Text == "" || jenkelCbox.Text == "" || semesterCbox.Text == "" || prodiCbox.Text == "" ||alamatTxt.Text == "")
            {
                usernameTxt.Focus();
                MessageBox.Show("Mohon Inputkan Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!akun.cekUsername(usernameTxt.Text))
                {
                    usernameTxt.Focus();
                    if (MessageBox.Show("Apakah data sudah benar ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        akun.Username = usernameTxt.Text;
                        akun.Password = passwordTxt.Text;
                        akun.Email = emailTxt.Text;
                        akun.Npm = npmTxt.Text;
                        akun.Nama = namaTxt.Text;
                        akun.Jenkel = jenkelCbox.Text;
                        akun.Prodi = prodiCbox.Text;
                        akun.Semester = semesterCbox.Text;
                        akun.Alamat = alamatTxt.Text;
                        akun.simpanDataPetugas();
                        clear();
                        tampilData();

                        MessageBox.Show("Akun berhasil di Simpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Data sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cekBtn_Click(object sender, EventArgs e)
        {
            if (akun.cekUser(usernameTxt.Text) == true)
            {
                MessageBox.Show("Data Terdaftar");
            }
            else
            {
                MessageBox.Show("Data Tidak Terdaftar");
            }
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
                    tampilData();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Data gagal diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Focus();
                clear();
            }
            tampilData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                usernameTxt.Text = row.Cells[0].Value.ToString();
                emailTxt.Text = row.Cells[2].Value.ToString();
                passwordTxt.Text = row.Cells[1].Value.ToString();
                npmTxt.Text = row.Cells[4].Value.ToString();
                namaTxt.Text = row.Cells[5].Value.ToString();
                jenkelCbox.Text = row.Cells[6].Value.ToString();
                prodiCbox.Text = row.Cells[7].Value.ToString();
                semesterCbox.Text = row.Cells[8].Value.ToString();
                alamatTxt.Text = row.Cells[9].Value.ToString();
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (akun.cekUsername(usernameTxt.Text))
            {
                if (MessageBox.Show("Data akan dihapus ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    akun.Username = usernameTxt.Text;
                    akun.hapusData(usernameTxt.Text);
                    MessageBox.Show("Data berhasil dihapus", "IFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usernameTxt.Focus();
                    clear();
                    tampilData();
                }
            }
            else
            {
                MessageBox.Show("Data gagal dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Focus();
                clear();
            }
        }

        private void cetakBtn_Click(object sender, EventArgs e)
        {
            lapDataPetugas cetakProdi = new lapDataPetugas();
            cetakProdi.ShowDialog();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
