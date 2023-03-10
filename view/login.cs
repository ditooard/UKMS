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
    public partial class login : Form
    {
        akun akun = new akun();

        public login()
        {
            InitializeComponent();
        }

        public string user()
        {
            string nama;
            nama =  usernameTxt.Text;
            return nama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "" || levelTxt.Text == "")
            {
                MessageBox.Show("Mohon Inputkan Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(levelTxt.Text =="Petugas")
                {
                    if (akun.cekLogin(usernameTxt.Text, passwordTxt.Text, levelTxt.Text))
                    {
                        dashboardPetugas dashboardPetugas = new dashboardPetugas(usernameTxt.Text,passwordTxt.Text);
                        dashboardPetugas.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Akun Belum Terdaftar", "INFORMASI");
                    }
                }
                else if(levelTxt.Text == "Pasien")
                {
                    if (akun.cekLogin(usernameTxt.Text, passwordTxt.Text, levelTxt.Text))
                    {
                        dashboardPasien dashboardPasien = new dashboardPasien(usernameTxt.Text, passwordTxt.Text);
                        dashboardPasien.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Akun Belum Terdaftar", "INFORMASI");
                    }
                }
                else if(levelTxt.Text == "Admin")
                {
                    if (akun.cekLogin(usernameTxt.Text, passwordTxt.Text, levelTxt.Text))
                    {
                        dashboardAdmin dashboardAdmin = new dashboardAdmin();
                        dashboardAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Akun Belum Terdaftar", "INFORMASI");
                    }
                    
                }
                
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            levelTxt.Items.Add("Petugas");
            levelTxt.Items.Add("Pasien");
            levelTxt.Items.Add("Admin");
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lupaPassword lupaPassword = new lupaPassword();
            lupaPassword.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buatAkun buatAkun = new buatAkun();
            buatAkun.Show();
            usernameTxt.Focus();
            this.Hide();
        }
    }
}
