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
    public partial class daftarObat : Form
    {

        obat obat = new obat();
        public daftarObat()
        {
            InitializeComponent();
        }

        void tampilData()
        {
            dataGridView1.DataSource = obat.tampilSemuaObat();
        }

        void cariData()
        {
            if (cariTxt.Text == "")
            {
                dataGridView1.DataSource = obat.tampilSemuaObat();
            }
            else
            {
                dataGridView1.DataSource = obat.tampilByNama(cariTxt.Text);
            }
        }

        private void daftarObat_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }
    }
}
