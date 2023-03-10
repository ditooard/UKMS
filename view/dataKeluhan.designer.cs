namespace UKMS.view
{
    partial class dataKeluhan
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
            this.lbl_diagnosa = new System.Windows.Forms.Label();
            this.lbl_npm = new System.Windows.Forms.Label();
            this.txt_catatan = new System.Windows.Forms.TextBox();
            this.lbl_obat = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txt_tgl = new System.Windows.Forms.DateTimePicker();
            this.obat = new System.Windows.Forms.ComboBox();
            this.diagnosaCbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tgl = new System.Windows.Forms.Label();
            this.txt_npm = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_diagnosa
            // 
            this.lbl_diagnosa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_diagnosa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagnosa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_diagnosa.Location = new System.Drawing.Point(26, 155);
            this.lbl_diagnosa.Name = "lbl_diagnosa";
            this.lbl_diagnosa.Size = new System.Drawing.Size(175, 31);
            this.lbl_diagnosa.TabIndex = 89;
            this.lbl_diagnosa.Text = "Self Diagnosa";
            this.lbl_diagnosa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_npm
            // 
            this.lbl_npm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_npm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_npm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_npm.Location = new System.Drawing.Point(26, 38);
            this.lbl_npm.Name = "lbl_npm";
            this.lbl_npm.Size = new System.Drawing.Size(138, 31);
            this.lbl_npm.TabIndex = 88;
            this.lbl_npm.Text = "NPM";
            this.lbl_npm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_catatan
            // 
            this.txt_catatan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_catatan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_catatan.Location = new System.Drawing.Point(221, 279);
            this.txt_catatan.Multiline = true;
            this.txt_catatan.Name = "txt_catatan";
            this.txt_catatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_catatan.Size = new System.Drawing.Size(471, 139);
            this.txt_catatan.TabIndex = 87;
            // 
            // lbl_obat
            // 
            this.lbl_obat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obat.Location = new System.Drawing.Point(26, 273);
            this.lbl_obat.Name = "lbl_obat";
            this.lbl_obat.Size = new System.Drawing.Size(155, 31);
            this.lbl_obat.TabIndex = 85;
            this.lbl_obat.Text = "Catatan";
            this.lbl_obat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.txt_tgl);
            this.gb1.Controls.Add(this.obat);
            this.gb1.Controls.Add(this.diagnosaCbox);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.lbl_tgl);
            this.gb1.Controls.Add(this.txt_npm);
            this.gb1.Controls.Add(this.lbl_npm);
            this.gb1.Controls.Add(this.lbl_obat);
            this.gb1.Controls.Add(this.lbl_diagnosa);
            this.gb1.Controls.Add(this.txt_catatan);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(736, 424);
            this.gb1.TabIndex = 92;
            this.gb1.TabStop = false;
            this.gb1.Text = "Data Keluhan";
            // 
            // txt_tgl
            // 
            this.txt_tgl.Location = new System.Drawing.Point(221, 103);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.Size = new System.Drawing.Size(471, 22);
            this.txt_tgl.TabIndex = 98;
            // 
            // obat
            // 
            this.obat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.obat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obat.FormattingEnabled = true;
            this.obat.Location = new System.Drawing.Point(221, 217);
            this.obat.Name = "obat";
            this.obat.Size = new System.Drawing.Size(471, 28);
            this.obat.TabIndex = 97;
            // 
            // diagnosaCbox
            // 
            this.diagnosaCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diagnosaCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diagnosaCbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosaCbox.FormattingEnabled = true;
            this.diagnosaCbox.Location = new System.Drawing.Point(221, 158);
            this.diagnosaCbox.Name = "diagnosaCbox";
            this.diagnosaCbox.Size = new System.Drawing.Size(471, 28);
            this.diagnosaCbox.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(26, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 94;
            this.label1.Text = "Jenis Obat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_tgl
            // 
            this.lbl_tgl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tgl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tgl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tgl.Location = new System.Drawing.Point(26, 94);
            this.lbl_tgl.Name = "lbl_tgl";
            this.lbl_tgl.Size = new System.Drawing.Size(138, 31);
            this.lbl_tgl.TabIndex = 92;
            this.lbl_tgl.Text = "Tanggal";
            this.lbl_tgl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_npm
            // 
            this.txt_npm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_npm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_npm.Location = new System.Drawing.Point(221, 41);
            this.txt_npm.Multiline = true;
            this.txt_npm.Name = "txt_npm";
            this.txt_npm.Size = new System.Drawing.Size(471, 28);
            this.txt_npm.TabIndex = 91;
           // this.txt_npm.TextChanged += new System.EventHandler(this.txt_npm_TextChanged);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.Location = new System.Drawing.Point(262, 457);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(241, 44);
            this.btn_simpan.TabIndex = 101;
            this.btn_simpan.Text = "KIRIM KELUHAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 102;
            // 
            // dataKeluhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataKeluhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "petugas";
            this.Load += new System.EventHandler(this.dataKeluhan_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_diagnosa;
        private System.Windows.Forms.Label lbl_npm;
        private System.Windows.Forms.TextBox txt_catatan;
        private System.Windows.Forms.Label lbl_obat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txt_npm;
        private System.Windows.Forms.Label lbl_tgl;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox obat;
        private System.Windows.Forms.ComboBox diagnosaCbox;
        private System.Windows.Forms.DateTimePicker txt_tgl;
        private System.Windows.Forms.Label label2;
    }
}