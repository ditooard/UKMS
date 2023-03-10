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
    public partial class lupaPassword : Form
    {
        akun akun = new akun();
        public lupaPassword()
        {
            InitializeComponent();
        }

        private void btn_kirim_Click(object sender, EventArgs e)
        {
            if(txt_lupapw.Text == "")
            {
                MessageBox.Show("Mohon Inputkan e-mail anda !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (akun.cekEmail(txt_lupapw.Text))
                {
                    MessageBox.Show("Permohonan me-reset password sudah dikirimkan ke e-mail anda", "INFORMASI");
                    login login = new login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("E-mail Belum Terdaftar", "INFORMASI");
                }
            }
        }

        private void kembaliBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void lupaPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
