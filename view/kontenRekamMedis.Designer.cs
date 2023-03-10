namespace UKMS
{
    partial class kontenRekamMedis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kontenRekamMedis));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.obat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diagnosaCbox = new System.Windows.Forms.ComboBox();
            this.lbl_tgl = new System.Windows.Forms.Label();
            this.txt_catatan = new System.Windows.Forms.TextBox();
            this.txt_npm = new System.Windows.Forms.TextBox();
            this.lbl_npm = new System.Windows.Forms.Label();
            this.lbl_obat = new System.Windows.Forms.Label();
            this.lbl_diagnosa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.cetakBtn = new System.Windows.Forms.Button();
            this.ubahBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiagnosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCatatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tgl = new System.Windows.Forms.DateTimePicker();
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.txt_tgl);
            this.gb1.Controls.Add(this.obat);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.diagnosaCbox);
            this.gb1.Controls.Add(this.lbl_tgl);
            this.gb1.Controls.Add(this.txt_catatan);
            this.gb1.Controls.Add(this.txt_npm);
            this.gb1.Controls.Add(this.lbl_npm);
            this.gb1.Controls.Add(this.lbl_obat);
            this.gb1.Controls.Add(this.lbl_diagnosa);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(736, 216);
            this.gb1.TabIndex = 93;
            this.gb1.TabStop = false;
            this.gb1.Text = "Data Keluhan";
            // 
            // obat
            // 
            this.obat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.obat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obat.FormattingEnabled = true;
            this.obat.Location = new System.Drawing.Point(158, 125);
            this.obat.Name = "obat";
            this.obat.Size = new System.Drawing.Size(556, 28);
            this.obat.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(7, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 96;
            this.label2.Text = "Jenis Obat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diagnosaCbox
            // 
            this.diagnosaCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diagnosaCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diagnosaCbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosaCbox.FormattingEnabled = true;
            this.diagnosaCbox.Location = new System.Drawing.Point(158, 91);
            this.diagnosaCbox.Name = "diagnosaCbox";
            this.diagnosaCbox.Size = new System.Drawing.Size(556, 28);
            this.diagnosaCbox.TabIndex = 95;
            // 
            // lbl_tgl
            // 
            this.lbl_tgl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tgl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tgl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tgl.Location = new System.Drawing.Point(7, 53);
            this.lbl_tgl.Name = "lbl_tgl";
            this.lbl_tgl.Size = new System.Drawing.Size(138, 31);
            this.lbl_tgl.TabIndex = 92;
            this.lbl_tgl.Text = "Tanggal";
            this.lbl_tgl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_catatan
            // 
            this.txt_catatan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_catatan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_catatan.Location = new System.Drawing.Point(158, 159);
            this.txt_catatan.Multiline = true;
            this.txt_catatan.Name = "txt_catatan";
            this.txt_catatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_catatan.Size = new System.Drawing.Size(556, 50);
            this.txt_catatan.TabIndex = 87;
            // 
            // txt_npm
            // 
            this.txt_npm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_npm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_npm.Location = new System.Drawing.Point(158, 21);
            this.txt_npm.Multiline = true;
            this.txt_npm.Name = "txt_npm";
            this.txt_npm.Size = new System.Drawing.Size(556, 28);
            this.txt_npm.TabIndex = 91;
            // 
            // lbl_npm
            // 
            this.lbl_npm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_npm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_npm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_npm.Location = new System.Drawing.Point(7, 18);
            this.lbl_npm.Name = "lbl_npm";
            this.lbl_npm.Size = new System.Drawing.Size(138, 31);
            this.lbl_npm.TabIndex = 88;
            this.lbl_npm.Text = "NPM";
            this.lbl_npm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_obat
            // 
            this.lbl_obat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obat.Location = new System.Drawing.Point(11, 159);
            this.lbl_obat.Name = "lbl_obat";
            this.lbl_obat.Size = new System.Drawing.Size(155, 31);
            this.lbl_obat.TabIndex = 85;
            this.lbl_obat.Text = "Catatan";
            this.lbl_obat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_diagnosa
            // 
            this.lbl_diagnosa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_diagnosa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagnosa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_diagnosa.Location = new System.Drawing.Point(7, 84);
            this.lbl_diagnosa.Name = "lbl_diagnosa";
            this.lbl_diagnosa.Size = new System.Drawing.Size(155, 41);
            this.lbl_diagnosa.TabIndex = 89;
            this.lbl_diagnosa.Text = "Self Diagnosa";
            this.lbl_diagnosa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 102;
            this.label1.Text = "   Cari Keluhan :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cariTxt
            // 
            this.cariTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cariTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTxt.HideSelection = false;
            this.cariTxt.Location = new System.Drawing.Point(180, 309);
            this.cariTxt.Multiline = true;
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(568, 28);
            this.cariTxt.TabIndex = 103;
            this.cariTxt.TextChanged += new System.EventHandler(this.cariTxt_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpanBtn);
            this.groupBox2.Controls.Add(this.cetakBtn);
            this.groupBox2.Controls.Add(this.ubahBtn);
            this.groupBox2.Controls.Add(this.hapusBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 69);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proses";
            // 
            // simpanBtn
            // 
            this.simpanBtn.Location = new System.Drawing.Point(31, 19);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(135, 44);
            this.simpanBtn.TabIndex = 101;
            this.simpanBtn.Text = "SIMPAN";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // cetakBtn
            // 
            this.cetakBtn.Location = new System.Drawing.Point(579, 19);
            this.cetakBtn.Name = "cetakBtn";
            this.cetakBtn.Size = new System.Drawing.Size(135, 44);
            this.cetakBtn.TabIndex = 104;
            this.cetakBtn.Text = "CETAK";
            this.cetakBtn.UseVisualStyleBackColor = true;
            this.cetakBtn.Click += new System.EventHandler(this.cetakBtn_Click);
            // 
            // ubahBtn
            // 
            this.ubahBtn.Location = new System.Drawing.Point(225, 19);
            this.ubahBtn.Name = "ubahBtn";
            this.ubahBtn.Size = new System.Drawing.Size(135, 44);
            this.ubahBtn.TabIndex = 102;
            this.ubahBtn.Text = "UBAH";
            this.ubahBtn.UseVisualStyleBackColor = true;
            this.ubahBtn.Click += new System.EventHandler(this.ubahBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.Location = new System.Drawing.Point(403, 19);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(135, 44);
            this.hapusBtn.TabIndex = 103;
            this.hapusBtn.Text = "HAPUS";
            this.hapusBtn.UseVisualStyleBackColor = true;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNpm,
            this.cTanggal,
            this.cDiagnosa,
            this.cKode,
            this.cCatatan});
            this.dataGridView1.Location = new System.Drawing.Point(15, 344);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(736, 171);
            this.dataGridView1.TabIndex = 106;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cNpm
            // 
            this.cNpm.DataPropertyName = "npm";
            this.cNpm.HeaderText = "NPM";
            this.cNpm.MinimumWidth = 6;
            this.cNpm.Name = "cNpm";
            this.cNpm.ReadOnly = true;
            this.cNpm.Width = 125;
            // 
            // cTanggal
            // 
            this.cTanggal.DataPropertyName = "tanggal";
            this.cTanggal.HeaderText = "Tanggal";
            this.cTanggal.MinimumWidth = 6;
            this.cTanggal.Name = "cTanggal";
            this.cTanggal.ReadOnly = true;
            this.cTanggal.Width = 125;
            // 
            // cDiagnosa
            // 
            this.cDiagnosa.DataPropertyName = "diagnosa";
            this.cDiagnosa.HeaderText = "Diagnosa";
            this.cDiagnosa.MinimumWidth = 6;
            this.cDiagnosa.Name = "cDiagnosa";
            this.cDiagnosa.ReadOnly = true;
            this.cDiagnosa.Width = 125;
            // 
            // cKode
            // 
            this.cKode.DataPropertyName = "jenis_obat";
            this.cKode.HeaderText = "Jenis Obat";
            this.cKode.MinimumWidth = 6;
            this.cKode.Name = "cKode";
            this.cKode.ReadOnly = true;
            this.cKode.Width = 125;
            // 
            // cCatatan
            // 
            this.cCatatan.DataPropertyName = "catatan";
            this.cCatatan.HeaderText = "Catatan";
            this.cCatatan.MinimumWidth = 6;
            this.cCatatan.Name = "cCatatan";
            this.cCatatan.ReadOnly = true;
            this.cCatatan.Width = 125;
            // 
            // txt_tgl
            // 
            this.txt_tgl.Location = new System.Drawing.Point(158, 59);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.Size = new System.Drawing.Size(556, 22);
            this.txt_tgl.TabIndex = 98;
            // 
            // kontenRekamMedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cariTxt);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kontenRekamMedis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kontenRekamMedis";
            this.Load += new System.EventHandler(this.kontenRekamMedis_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lbl_tgl;
        private System.Windows.Forms.TextBox txt_npm;
        private System.Windows.Forms.Label lbl_npm;
        private System.Windows.Forms.Label lbl_obat;
        private System.Windows.Forms.Label lbl_diagnosa;
        private System.Windows.Forms.TextBox txt_catatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button cetakBtn;
        private System.Windows.Forms.Button ubahBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox obat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox diagnosaCbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNpm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiagnosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCatatan;
        private System.Windows.Forms.DateTimePicker txt_tgl;
    }
}