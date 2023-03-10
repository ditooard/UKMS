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

namespace UKMS.view
{
    public partial class buatAkun : Form
    {
        akun akun = new akun();

      
        public buatAkun()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            usernameTxt.Clear();
            passwordTxt.Clear();
            confirmTxt.Clear();
            levelTxt.Items.Clear();
            emailTxt.Clear();
        }

        private void buatAkun_Load(object sender, EventArgs e)
        {
            usernameTxt.Select();
            this.ActiveControl = usernameTxt;
            usernameTxt.Focus();
            cmb_prodi.Items.Add("Teknik Elektronika");
            cmb_prodi.Items.Add("Teknik Informatika");
            cmb_prodi.Items.Add("Teknik Mesin");
            cmb_prodi.Items.Add("Teknik Listrik");
            cmb_prodi.Items.Add("Teknik Pengendalian Pencemaran Lingkungan");
            cmb_prodi.Items.Add("Teknik Pengembangan Produk Agroindustri");
            cmb_prodi.Items.Add("Rekayasa Keamanan Siber");

            cmb_semester.Items.Add("1");
            cmb_semester.Items.Add("2");
            cmb_semester.Items.Add("3");
            cmb_semester.Items.Add("4");
            cmb_semester.Items.Add("5");
            cmb_semester.Items.Add("6");
            cmb_semester.Items.Add("7");
            cmb_semester.Items.Add("8");

            levelTxt.Items.Add("Petugas");
            levelTxt.Items.Add("Pasien");
        }

        private void kembaliBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void buatAkunBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "" || confirmTxt.Text == "" || emailTxt.Text == "" || levelTxt.Text == ""||txt_npm.Text==""||txt_nama.Text==""||rdbtn_laki.Text=="" || rdbtn_perempuan.Text == ""||cmb_semester.Text==""||cmb_prodi.Text==""||txt_alamat.Text=="")
            {
                usernameTxt.Focus();
                MessageBox.Show("Mohon Inputkan Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!akun.cekUsername(usernameTxt.Text))
                {
                    usernameTxt.Focus();

                    if (passwordTxt.Text == confirmTxt.Text)
                    {
                        if (MessageBox.Show("Apakah data sudah benar ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                                akun.Username = usernameTxt.Text;
                                akun.Password = passwordTxt.Text;
                                akun.Email = emailTxt.Text;
                                akun.Level = levelTxt.Text;
                                akun.Npm = txt_npm.Text;
                                akun.Nama = txt_nama.Text;
                                if (rdbtn_laki.Checked = true)
                                {
                                    akun.Jenkel = rdbtn_laki.Text;
                                }
                                else if (rdbtn_perempuan.Checked = true)
                                {
                                    akun.Jenkel = rdbtn_perempuan.Text;
                                }
                                else
                                {

                                }
                                akun.Prodi = cmb_prodi.Text;
                                akun.Semester = cmb_semester.Text;
                                akun.Alamat = txt_alamat.Text;
                                akun.simpanData();

                                MessageBox.Show("Akun berhasil dibuat", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                login login = new login();
                                login.Show();
                                this.Hide();
                                bersihkan();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password tidak sesuai !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                }
                else
                {
                    MessageBox.Show("Data sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bersihkan();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
