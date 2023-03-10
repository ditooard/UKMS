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
    public partial class daftarPasien : Form
    {
        akun akun = new akun();
        public daftarPasien()
        {
            InitializeComponent();
        }

        void tampilData()
        {
            dataGridView1.DataSource = akun.tampilSemuaPasien();
        }
        void cariData()
        {
            if (cariTxt.Text == "")
            {
                dataGridView1.DataSource = akun.tampilSemuaPasien();
            }
            else
            {
                dataGridView1.DataSource = akun.tampilByNamaPasien(cariTxt.Text);
            }
        }

        private void daftarPasien_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }
    }
}
