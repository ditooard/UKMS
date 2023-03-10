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
    public partial class dashboardAdmin : Form
    {

        kontenPasien pasienAdmin = new kontenPasien();
        kontenPetugas petugasAdmin = new kontenPetugas();
        kontenObat obat = new kontenObat();
        kontenRekamMedis rekamMedis = new kontenRekamMedis();

        public dashboardAdmin()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
            pasienAdmin.Visible = false;
            petugasAdmin.Visible = false;
            obat.Visible = false;
            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = true;

            if (MessageBox.Show("Apakah anda akan Log Out?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();

            }
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                
                petugasAdmin.TopLevel = false;
                konten1.Controls.Add(petugasAdmin);
                petugasAdmin.Show();
            }

            nav1.Visible= true;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {
                
                pasienAdmin.TopLevel = false;
                konten1.Controls.Add(pasienAdmin);
                pasienAdmin.Show();
            }

            nav1.Visible = false;
            nav2.Visible = true;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
        }

        private void btnObat_Click(object sender, EventArgs e)
        {


            konten1.Controls.Clear();
            if (konten1.Controls.Count == 0)
            {

                obat.TopLevel = false;
                konten1.Controls.Add(obat);
                obat.Show();
            }

            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = true;
            nav4.Visible = false;
            nav5.Visible = false;
        }

        private void btnRekam_Click(object sender, EventArgs e)
        {
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
            nav4.Visible = true;
            nav5.Visible = false;
        }

        private void dashboardAdmin_Load(object sender, EventArgs e)
        {
            nav1.Visible = false;
            nav2.Visible = false;
            nav3.Visible = false;
            nav4.Visible = false;
            nav5.Visible = false;
        }
    }
}
