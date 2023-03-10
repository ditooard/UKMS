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
    public partial class keluhanPetugas : Form
    {
        model.keluhan keluhan = new model.keluhan();

        public keluhanPetugas()
        {
            InitializeComponent();
        }

        void tampilData()
        {
            dataGridView1.DataSource = keluhan.tampilSemuaKeluhan();
        }

        void cariData()
        {
            if (cariTxt.Text == "")
            {
                dataGridView1.DataSource = keluhan.tampilSemuaKeluhan();
            }
            else
            {
                dataGridView1.DataSource = keluhan.tampilByNpm(cariTxt.Text);
            }
        }

        private void keluhanPetugas_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }
    }
}
