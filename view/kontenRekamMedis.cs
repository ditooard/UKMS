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
using UKMS.report;

namespace UKMS
{
    public partial class kontenRekamMedis : Form
    {

        keluhan keluhan = new keluhan();

        public kontenRekamMedis()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = keluhan.tampilSemuaKeluhan();
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

        private void kontenRekamMedis_Load(object sender, EventArgs e)
        {
            tampilData();
            txt_npm.Select();
            this.ActiveControl = txt_npm;
            txt_npm.Focus();
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

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (txt_npm.Text == "" || diagnosaCbox.Text == "" || txt_catatan.Text == "")
            {
                txt_npm.Focus();
                MessageBox.Show("Mohon Inputkan Data Keluhan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_npm.Text = row.Cells[0].Value.ToString();
                txt_tgl.Text = row.Cells[1].Value.ToString();
                obat.Text = row.Cells[2].Value.ToString();
                diagnosaCbox.Text = row.Cells[3].Value.ToString();
                txt_catatan.Text = row.Cells[4].Value.ToString();
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (keluhan.cekNpm(txt_npm.Text))
            {
                if (MessageBox.Show("Data akan dihapus ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    keluhan.Npm = txt_npm.Text;
                    keluhan.hapusData(txt_npm.Text);
                    MessageBox.Show("Data berhasil dihapus", "IFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_npm.Focus();
                    clear();
                    tampilData();
                }
            }
            else
            {
                MessageBox.Show("Data gagal dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_npm.Focus();
                clear();
            }
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            if (keluhan.cekNpm(txt_npm.Text))
            {
                if (MessageBox.Show("Obat akan diubah ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    keluhan.Npm = txt_npm.Text;
                    keluhan.Tanggal = txt_tgl.Text;
                    keluhan.jenisObat = obat.Text;
                    keluhan.Diagnosa = diagnosaCbox.Text;
                    keluhan.Catatan = txt_catatan.Text;
                    keluhan.ubahDataKeluhan(txt_npm.Text);
                    MessageBox.Show("Obat berhasil diubah", "IFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_npm.Focus();
                    tampilData();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Obat gagal diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_npm.Focus();
                clear();
            }
            tampilData();
        }

        private void cetakBtn_Click(object sender, EventArgs e)
        {
            dataKeluhan cetakProdi = new dataKeluhan();
            cetakProdi.ShowDialog();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }
    }
}
