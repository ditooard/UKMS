namespace UKMS.view
{
    partial class kontenObat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kontenObat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cariobat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_namaobat = new System.Windows.Forms.TextBox();
            this.cekBtn = new System.Windows.Forms.Button();
            this.txt_kodeobat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obatCbox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.cetakBtn = new System.Windows.Forms.Button();
            this.ubahBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKode,
            this.cNama,
            this.cJenis});
            this.dataGridView1.Location = new System.Drawing.Point(85, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(593, 249);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cKode
            // 
            this.cKode.DataPropertyName = "kode_obat";
            this.cKode.HeaderText = "Kode Obat";
            this.cKode.MinimumWidth = 6;
            this.cKode.Name = "cKode";
            this.cKode.ReadOnly = true;
            this.cKode.Width = 125;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "nama_obat";
            this.cNama.HeaderText = "Nama Obat";
            this.cNama.MinimumWidth = 6;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 125;
            // 
            // cJenis
            // 
            this.cJenis.DataPropertyName = "jenis_obat";
            this.cJenis.HeaderText = "Jenis Obat";
            this.cJenis.MinimumWidth = 6;
            this.cJenis.Name = "cJenis";
            this.cJenis.ReadOnly = true;
            this.cJenis.Width = 125;
            // 
            // txt_cariobat
            // 
            this.txt_cariobat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cariobat.Location = new System.Drawing.Point(154, 227);
            this.txt_cariobat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cariobat.Name = "txt_cariobat";
            this.txt_cariobat.Size = new System.Drawing.Size(593, 26);
            this.txt_cariobat.TabIndex = 35;
            this.txt_cariobat.TextChanged += new System.EventHandler(this.txt_cariobat_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Jenis Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nama Obat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kode Obat";
            // 
            // txt_namaobat
            // 
            this.txt_namaobat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namaobat.Location = new System.Drawing.Point(163, 63);
            this.txt_namaobat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_namaobat.Multiline = true;
            this.txt_namaobat.Name = "txt_namaobat";
            this.txt_namaobat.Size = new System.Drawing.Size(556, 28);
            this.txt_namaobat.TabIndex = 25;
            // 
            // cekBtn
            // 
            this.cekBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekBtn.Location = new System.Drawing.Point(268, 25);
            this.cekBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cekBtn.Name = "cekBtn";
            this.cekBtn.Size = new System.Drawing.Size(77, 33);
            this.cekBtn.TabIndex = 24;
            this.cekBtn.Text = "Cek";
            this.cekBtn.UseVisualStyleBackColor = true;
            this.cekBtn.Click += new System.EventHandler(this.cekBtn_Click);
            // 
            // txt_kodeobat
            // 
            this.txt_kodeobat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kodeobat.Location = new System.Drawing.Point(163, 28);
            this.txt_kodeobat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kodeobat.Multiline = true;
            this.txt_kodeobat.Name = "txt_kodeobat";
            this.txt_kodeobat.Size = new System.Drawing.Size(83, 28);
            this.txt_kodeobat.TabIndex = 23;
            this.txt_kodeobat.TextChanged += new System.EventHandler(this.txt_kodeobat_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obatCbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_kodeobat);
            this.groupBox1.Controls.Add(this.cekBtn);
            this.groupBox1.Controls.Add(this.txt_namaobat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 135);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Obat";
            // 
            // obatCbox
            // 
            this.obatCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obatCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.obatCbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obatCbox.FormattingEnabled = true;
            this.obatCbox.Location = new System.Drawing.Point(163, 101);
            this.obatCbox.Name = "obatCbox";
            this.obatCbox.Size = new System.Drawing.Size(556, 28);
            this.obatCbox.TabIndex = 101;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpanBtn);
            this.groupBox2.Controls.Add(this.cetakBtn);
            this.groupBox2.Controls.Add(this.ubahBtn);
            this.groupBox2.Controls.Add(this.hapusBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 69);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proses";
            // 
            // simpanBtn
            // 
            this.simpanBtn.Location = new System.Drawing.Point(61, 19);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(135, 44);
            this.simpanBtn.TabIndex = 101;
            this.simpanBtn.Text = "SIMPAN";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // cetakBtn
            // 
            this.cetakBtn.Location = new System.Drawing.Point(584, 19);
            this.cetakBtn.Name = "cetakBtn";
            this.cetakBtn.Size = new System.Drawing.Size(135, 44);
            this.cetakBtn.TabIndex = 104;
            this.cetakBtn.Text = "CETAK";
            this.cetakBtn.UseVisualStyleBackColor = true;
            this.cetakBtn.Click += new System.EventHandler(this.cetakBtn_Click);
            // 
            // ubahBtn
            // 
            this.ubahBtn.Location = new System.Drawing.Point(232, 19);
            this.ubahBtn.Name = "ubahBtn";
            this.ubahBtn.Size = new System.Drawing.Size(135, 44);
            this.ubahBtn.TabIndex = 102;
            this.ubahBtn.Text = "UBAH";
            this.ubahBtn.UseVisualStyleBackColor = true;
            this.ubahBtn.Click += new System.EventHandler(this.ubahBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.Location = new System.Drawing.Point(404, 19);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(135, 44);
            this.hapusBtn.TabIndex = 103;
            this.hapusBtn.Text = "HAPUS";
            this.hapusBtn.UseVisualStyleBackColor = true;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(9, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 100;
            this.label4.Text = "   Cari Obat :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kontenObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cariobat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kontenObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "obat2";
            this.Load += new System.EventHandler(this.kontenObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_cariobat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_namaobat;
        private System.Windows.Forms.Button cekBtn;
        private System.Windows.Forms.TextBox txt_kodeobat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button cetakBtn;
        private System.Windows.Forms.Button ubahBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJenis;
        private System.Windows.Forms.ComboBox obatCbox;
    }
}