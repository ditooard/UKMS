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
    public partial class daftarKeluhan : Form
    {
        model.keluhan keluhan = new model.keluhan();
        akun akun = new akun();
        string user;

        public daftarKeluhan(string user)
        {
            this.user = user;
            InitializeComponent();
            tampilData();
        }

        void tampilData()
        {
            dataGridView1.DataSource = keluhan.tampilSemuaKeluhanPasien(label2.Text);
            DataTable data = new DataTable();
            data = akun.tampilBerelasi(user);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    label2.Text = dt[4].ToString();
                }
            }
        }

        void cariData()
        {
            if (cariTxt.Text == "")
            {
                dataGridView1.DataSource = keluhan.tampilSemuaKeluhanPasien(label2.Text);
            }
            else
            {
                dataGridView1.DataSource = keluhan.tampilByNpm(cariTxt.Text);
            }
        }

        private void daftarKeluhan_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }
    }
}
