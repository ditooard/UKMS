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
    public partial class dataKeluhan : Form
    {
        keluhan keluhan = new keluhan();
        akun akun = new akun();

        string user;

        public dataKeluhan(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        void isiData()
        {
            DataTable data = new DataTable();
            data = akun.tampilBerelasi(user);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    txt_npm.Text = dt[4].ToString();
                }
            }
        }

        void clear()
        {
            txt_npm.Clear();
            txt_tgl.Value = DateTime.Now;
            diagnosaCbox.Items.Clear();
            obat.Items.Clear();
            txt_catatan.Clear();
        }

        void tampilData()
        {
            isiData();
            diagnosaCbox.Items.Add("Alergi");
            diagnosaCbox.Items.Add("Asma");
            diagnosaCbox.Items.Add("Batuk");
            diagnosaCbox.Items.Add("Cedera");
            diagnosaCbox.Items.Add("Demam");
            diagnosaCbox.Items.Add("Diare");
            diagnosaCbox.Items.Add("Hipertensi");
            diagnosaCbox.Items.Add("Influenza");
            diagnosaCbox.Items.Add("Magh");
            diagnosaCbox.Items.Add("Menstruasi");
            diagnosaCbox.Items.Add("Migrain");
            diagnosaCbox.Items.Add("Nyeri Kepala");
            diagnosaCbox.Items.Add("Pilek");
            diagnosaCbox.Items.Add("Radang Gigi");
            diagnosaCbox.Items.Add("Radang Tenggorokan");
            diagnosaCbox.Items.Add("Sembelit");
            diagnosaCbox.Items.Add("Vertigo");

            obat.Items.Add("Obat Alergi");
            obat.Items.Add("Obat Asma");
            obat.Items.Add("Obat Batuk");
            obat.Items.Add("Obat Cedera");
            obat.Items.Add("Obat Demam");
            obat.Items.Add("Obat Diare");
            obat.Items.Add("Obat Hipertensi");
            obat.Items.Add("Obat Influenza");
            obat.Items.Add("Obat Magh");
            obat.Items.Add("Obat Menstruasi");
            obat.Items.Add("Obat Migrain");
            obat.Items.Add("Obat Nyeri Kepala");
            obat.Items.Add("Obat Pilek");
            obat.Items.Add("Obat Radang Gigi");
            obat.Items.Add("Obat Radang Tenggorokan");
            obat.Items.Add("Obat Sembelit");
            obat.Items.Add("Obat Vertigo");
        }

        private void dataKeluhan_Load(object sender, EventArgs e)
        {
            tampilData();
            txt_npm.Select();
            this.ActiveControl = txt_npm;
            txt_npm.Focus();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (keluhan.cekNpm(txt_npm.Text))
            {
                txt_npm.Focus();
                if (MessageBox.Show("Apakah data sudah benar ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    keluhan.Npm = txt_npm.Text;
                    keluhan.Tanggal = txt_tgl.Value.ToString("yyyy/MM/dd");
                    keluhan.Diagnosa = diagnosaCbox.Text;
                    keluhan.jenisObat = obat.Text;
                    keluhan.Catatan = txt_catatan.Text;
                    keluhan.simpanData();
                    clear();
                    tampilData();

                    MessageBox.Show("keluhan berhasil di Simpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("NPM TIDAK TERDAFTAR", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
