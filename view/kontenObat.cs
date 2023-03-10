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

namespace UKMS.view
{
    public partial class kontenObat : Form
    {
        obat obat = new obat();

        public kontenObat()
        {
            InitializeComponent();
        }

        private void kontenObat_Load(object sender, EventArgs e)
        {
            tampilData();
            txt_kodeobat.Text = obat.buatKode();
            txt_kodeobat.Focus();
            txt_kodeobat.Select();
            this.ActiveControl = txt_kodeobat;
            txt_kodeobat.Focus();
            
        }

        void clear()
        {
            obatCbox.Items.Clear();
            txt_kodeobat.Clear();
            txt_namaobat.Clear();  
        }
        void tampilData()
        {
            dataGridView1.DataSource = obat.tampilSemuaObat();
            obatCbox.Items.Add("Obat Alergi");
            obatCbox.Items.Add("Obat Asma");
            obatCbox.Items.Add("Obat Batuk");
            obatCbox.Items.Add("Obat Cedera");
            obatCbox.Items.Add("Obat Demam");
            obatCbox.Items.Add("Obat Diare");
            obatCbox.Items.Add("Obat Hipertensi");
            obatCbox.Items.Add("Obat Influenza");
            obatCbox.Items.Add("Obat Magh");
            obatCbox.Items.Add("Obat Menstruasi");
            obatCbox.Items.Add("Obat Migrain");
            obatCbox.Items.Add("Obat Nyeri Kepala");
            obatCbox.Items.Add("Obat Pilek");
            obatCbox.Items.Add("Obat Radang Gigi");
            obatCbox.Items.Add("Obat Radang Tenggorokan");
            obatCbox.Items.Add("Obat Sembelit");
            obatCbox.Items.Add("Obat Vertigo");
        }

        void cariData()
        {
            if (txt_cariobat.Text == "")
            {
                dataGridView1.DataSource = obat.tampilSemua();
            }
            else
            {
                dataGridView1.DataSource = obat.tampilByNama(txt_cariobat.Text);
            }
        }

        private void cekBtn_Click(object sender, EventArgs e)
        {
            if (obat.cekObat(txt_kodeobat.Text) == true)
            {
                MessageBox.Show("Obat Terdaftar");
            }
            else
            {
                MessageBox.Show("Obat Tidak Terdaftar");
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (txt_kodeobat.Text == "" || txt_namaobat.Text == "" || obatCbox.Text == "")
            {
                txt_kodeobat.Focus();
                MessageBox.Show("Mohon Inputkan Obat !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!obat.cekObat(txt_kodeobat.Text))
                {
                    txt_kodeobat.Focus();
                    if (MessageBox.Show("Apakah data sudah benar ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obat.kodeObat = txt_kodeobat.Text;
                        obat.namaObat = txt_namaobat.Text;
                        obat.jenisObat = obatCbox.Text;
                        obat.simpanObat();
                        clear();
                        tampilData();

                        MessageBox.Show("Obat berhasil di Simpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Obat sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_kodeobat.Text = row.Cells[0].Value.ToString();
                txt_namaobat.Text = row.Cells[1].Value.ToString();
                obatCbox.Text = row.Cells[2].Value.ToString();
              
            }
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            if (obat.cekObat(txt_kodeobat.Text))
            {
                if (MessageBox.Show("Obat akan diubah ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obat.namaObat = txt_namaobat.Text;
                    obat.kodeObat = txt_kodeobat.Text;
                    obat.jenisObat= obatCbox.Text;
                    obat.ubahDataObat(txt_kodeobat.Text);
                    MessageBox.Show("Obat berhasil diubah", "IFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_kodeobat.Focus();
                    tampilData();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Obat gagal diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_kodeobat.Focus();
                clear();
            }
            tampilData();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            if (obat.cekObat(txt_kodeobat.Text))
            {
                if (MessageBox.Show("Data akan dihapus ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obat.kodeObat = txt_kodeobat.Text;
                    obat.hapusData(txt_kodeobat.Text);
                    MessageBox.Show("Data berhasil dihapus", "IFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_kodeobat.Focus();
                    clear();
                    tampilData();
                }
            }
            else
            {
                MessageBox.Show("Data gagal dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_kodeobat.Focus();
                clear();
            }
        }

        private void cetakBtn_Click(object sender, EventArgs e)
        {
            lapObat cetakProdi = new lapObat();
            cetakProdi.ShowDialog();
        }

        private void txt_cariobat_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }

        private void txt_kodeobat_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
