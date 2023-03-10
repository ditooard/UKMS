using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKMS.view
{
    public partial class dashboardPetugas : Form
    {
        model.akun akun = new model.akun();
        string user;
        string pass;
        string level;
        

        kontenObat obat = new kontenObat();
        daftarPasien daftarPasien = new daftarPasien();
        keluhanPetugas keluhan = new keluhanPetugas();


        public dashboardPetugas(string user, string pass)
        {
            InitializeComponent();
            this.level = level;
            this.user = user;
            this.pass = pass;
            label16.Text = user;
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = true;

            if (MessageBox.Show("Apakah anda akan Log Out?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();

            }
        }

        private void dashboardPetugas_Load(object sender, EventArgs e)
        {
            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            petugas petugas = new petugas(label16.Text);
            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                petugas.TopLevel = false;
                konten1.Controls.Add(petugas);
                petugas.Show();
            }      

            nav1.Visible = true;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnPnc_Click(object sender, EventArgs e)
        {
            petugas petugas = new petugas(label16.Text);

            kontenPnc.Visible = true;
            kontenUkms.Visible = false;
            petugas.Visible = false;
            konten1.Visible = false;

            nav1.Visible = false;
            nav2.Visible = true;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnUkms_Click(object sender, EventArgs e)
        {
            petugas petugas = new petugas(label16.Text);
            kontenPnc.Visible = false;
            kontenUkms.Visible = true;
            petugas.Visible = false;
            konten1.Visible = false;


            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = true;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {

            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                daftarPasien.TopLevel = false;
                konten1.Controls.Add(daftarPasien);
                daftarPasien.Show();
            }

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = true;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnKeluhan_Click(object sender, EventArgs e)
        {
            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                keluhan.TopLevel = false;
                konten1.Controls.Add(keluhan);
                keluhan.Show();
            }

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = true;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {

                obat.TopLevel = false;
                konten1.Controls.Add(obat);
                obat.Show();
            }

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = true;
            nav7.Visible = false;
        }

    }
}
