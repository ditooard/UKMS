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
    public partial class dashboardPasien : Form
    {
        
       
        daftarObat obat = new daftarObat();
        string user;
        string pass;
        public dashboardPasien(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
            InitializeComponent();
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

        private void btnPasien_Click(object sender, EventArgs e)
        {
            pasien pasien = new pasien(label16.Text);
            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                pasien.TopLevel = false;
                konten1.Controls.Add(pasien);
                pasien.Show();
            }

            nav1.Visible = true;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void dashboardPasien_Load(object sender, EventArgs e)
        {
            
            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible=true;

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnPnc_Click(object sender, EventArgs e)
        {
            pasien pasien = new pasien(label16.Text);
            kontenPnc.Visible = false;
            kontenUkms.Visible = true;
            konten1.Visible = false;
            pasien.Visible = false;

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
            pasien pasien = new pasien(label16.Text);
            kontenPnc.Visible = true;
            kontenUkms.Visible = false;
            konten1.Visible = false;
            pasien.Visible = false;

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = true;
            nav4.Visible = false;
            nav5.Visible = false;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnKeluhan_Click(object sender, EventArgs e)
        {
            dataKeluhan dataKeluhan = new dataKeluhan(label16.Text);
            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                dataKeluhan.TopLevel = false;
                konten1.Controls.Add(dataKeluhan);
                dataKeluhan.Show();
            }

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = true;
            nav5.Visible = false;
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
            nav5.Visible = true;
            nav6.Visible = false;
            nav7.Visible = false;
        }

        private void btnRekam_Click(object sender, EventArgs e)
        {
            daftarKeluhan rekamMedis = new daftarKeluhan(label16.Text);

            kontenPnc.Visible = false;
            kontenUkms.Visible = false;
            konten1.Visible = true;

            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                rekamMedis.TopLevel = false;
                konten1.Controls.Add(rekamMedis);
                rekamMedis.Show();
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
