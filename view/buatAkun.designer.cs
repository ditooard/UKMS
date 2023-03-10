namespace UKMS.view
{
    partial class buatAkun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buatAkun));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.confirmTxt = new System.Windows.Forms.TextBox();
            this.lbl_confirmpw = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.kembaliBtn = new System.Windows.Forms.Button();
            this.buatAkunBtn = new System.Windows.Forms.Button();
            this.levelTxt = new System.Windows.Forms.ComboBox();
            this.lbl_npm = new System.Windows.Forms.Label();
            this.lbl_jk = new System.Windows.Forms.Label();
            this.lbl_semester = new System.Windows.Forms.Label();
            this.lbl_prodi = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.rdbtn_perempuan = new System.Windows.Forms.RadioButton();
            this.rdbtn_laki = new System.Windows.Forms.RadioButton();
            this.cmb_semester = new System.Windows.Forms.ComboBox();
            this.txt_npm = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.cmb_prodi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 598);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_level
            // 
            this.lbl_level.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.Location = new System.Drawing.Point(565, 259);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(167, 30);
            this.lbl_level.TabIndex = 16;
            this.lbl_level.Text = "Level Access";
            this.lbl_level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(565, 119);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(167, 30);
            this.lbl_username.TabIndex = 19;
            this.lbl_username.Text = "Username";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(745, 119);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(285, 28);
            this.usernameTxt.TabIndex = 18;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(745, 189);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(285, 28);
            this.passwordTxt.TabIndex = 21;
            // 
            // lbl_password
            // 
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(565, 189);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(167, 30);
            this.lbl_password.TabIndex = 20;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmTxt
            // 
            this.confirmTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTxt.Location = new System.Drawing.Point(745, 224);
            this.confirmTxt.Multiline = true;
            this.confirmTxt.Name = "confirmTxt";
            this.confirmTxt.PasswordChar = '*';
            this.confirmTxt.Size = new System.Drawing.Size(285, 28);
            this.confirmTxt.TabIndex = 23;
            // 
            // lbl_confirmpw
            // 
            this.lbl_confirmpw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmpw.Location = new System.Drawing.Point(565, 224);
            this.lbl_confirmpw.Name = "lbl_confirmpw";
            this.lbl_confirmpw.Size = new System.Drawing.Size(167, 30);
            this.lbl_confirmpw.TabIndex = 22;
            this.lbl_confirmpw.Text = "Confirm Password";
            this.lbl_confirmpw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_email.Location = new System.Drawing.Point(565, 154);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(167, 30);
            this.lbl_email.TabIndex = 25;
            this.lbl_email.Text = "E-mail";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailTxt
            // 
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(745, 154);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(285, 28);
            this.emailTxt.TabIndex = 24;
            // 
            // kembaliBtn
            // 
            this.kembaliBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembaliBtn.Location = new System.Drawing.Point(821, 525);
            this.kembaliBtn.Name = "kembaliBtn";
            this.kembaliBtn.Size = new System.Drawing.Size(121, 53);
            this.kembaliBtn.TabIndex = 26;
            this.kembaliBtn.Text = "Kembali";
            this.kembaliBtn.UseVisualStyleBackColor = true;
            this.kembaliBtn.Click += new System.EventHandler(this.kembaliBtn_Click);
            // 
            // buatAkunBtn
            // 
            this.buatAkunBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buatAkunBtn.Location = new System.Drawing.Point(659, 525);
            this.buatAkunBtn.Name = "buatAkunBtn";
            this.buatAkunBtn.Size = new System.Drawing.Size(121, 53);
            this.buatAkunBtn.TabIndex = 27;
            this.buatAkunBtn.Text = "Buat Akun";
            this.buatAkunBtn.UseVisualStyleBackColor = true;
            this.buatAkunBtn.Click += new System.EventHandler(this.buatAkunBtn_Click);
            // 
            // levelTxt
            // 
            this.levelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.levelTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelTxt.FormattingEnabled = true;
            this.levelTxt.Location = new System.Drawing.Point(745, 259);
            this.levelTxt.Name = "levelTxt";
            this.levelTxt.Size = new System.Drawing.Size(285, 28);
            this.levelTxt.TabIndex = 28;
            // 
            // lbl_npm
            // 
            this.lbl_npm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_npm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_npm.Location = new System.Drawing.Point(564, 294);
            this.lbl_npm.Name = "lbl_npm";
            this.lbl_npm.Size = new System.Drawing.Size(167, 30);
            this.lbl_npm.TabIndex = 72;
            this.lbl_npm.Text = "NPM";
            this.lbl_npm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_jk
            // 
            this.lbl_jk.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jk.Location = new System.Drawing.Point(564, 364);
            this.lbl_jk.Name = "lbl_jk";
            this.lbl_jk.Size = new System.Drawing.Size(167, 30);
            this.lbl_jk.TabIndex = 71;
            this.lbl_jk.Text = "Jenis Kelamin";
            this.lbl_jk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_semester
            // 
            this.lbl_semester.BackColor = System.Drawing.Color.Transparent;
            this.lbl_semester.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_semester.Location = new System.Drawing.Point(564, 434);
            this.lbl_semester.Name = "lbl_semester";
            this.lbl_semester.Size = new System.Drawing.Size(167, 30);
            this.lbl_semester.TabIndex = 70;
            this.lbl_semester.Text = "Semester";
            this.lbl_semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_prodi
            // 
            this.lbl_prodi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prodi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_prodi.Location = new System.Drawing.Point(564, 399);
            this.lbl_prodi.Name = "lbl_prodi";
            this.lbl_prodi.Size = new System.Drawing.Size(167, 30);
            this.lbl_prodi.TabIndex = 69;
            this.lbl_prodi.Text = "Prodi";
            this.lbl_prodi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_nama
            // 
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(564, 329);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(167, 30);
            this.lbl_nama.TabIndex = 68;
            this.lbl_nama.Text = "Nama";
            this.lbl_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alamat.Location = new System.Drawing.Point(564, 469);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(167, 30);
            this.lbl_alamat.TabIndex = 67;
            this.lbl_alamat.Text = "Alamat";
            this.lbl_alamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbtn_perempuan
            // 
            this.rdbtn_perempuan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_perempuan.Location = new System.Drawing.Point(890, 365);
            this.rdbtn_perempuan.Name = "rdbtn_perempuan";
            this.rdbtn_perempuan.Size = new System.Drawing.Size(140, 31);
            this.rdbtn_perempuan.TabIndex = 81;
            this.rdbtn_perempuan.TabStop = true;
            this.rdbtn_perempuan.Text = "Perempuan";
            this.rdbtn_perempuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtn_perempuan.UseVisualStyleBackColor = true;
            // 
            // rdbtn_laki
            // 
            this.rdbtn_laki.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_laki.Location = new System.Drawing.Point(745, 365);
            this.rdbtn_laki.Name = "rdbtn_laki";
            this.rdbtn_laki.Size = new System.Drawing.Size(117, 31);
            this.rdbtn_laki.TabIndex = 80;
            this.rdbtn_laki.TabStop = true;
            this.rdbtn_laki.Text = "Laki - Laki";
            this.rdbtn_laki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtn_laki.UseVisualStyleBackColor = true;
            // 
            // cmb_semester
            // 
            this.cmb_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_semester.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_semester.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_semester.FormattingEnabled = true;
            this.cmb_semester.Location = new System.Drawing.Point(745, 435);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.Size = new System.Drawing.Size(285, 28);
            this.cmb_semester.TabIndex = 79;
            // 
            // txt_npm
            // 
            this.txt_npm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_npm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_npm.HideSelection = false;
            this.txt_npm.Location = new System.Drawing.Point(745, 296);
            this.txt_npm.Multiline = true;
            this.txt_npm.Name = "txt_npm";
            this.txt_npm.Size = new System.Drawing.Size(285, 28);
            this.txt_npm.TabIndex = 75;
            // 
            // txt_alamat
            // 
            this.txt_alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alamat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.Location = new System.Drawing.Point(745, 467);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_alamat.Size = new System.Drawing.Size(285, 49);
            this.txt_alamat.TabIndex = 78;
            // 
            // txt_nama
            // 
            this.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nama.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(745, 331);
            this.txt_nama.Multiline = true;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(285, 28);
            this.txt_nama.TabIndex = 77;
            // 
            // cmb_prodi
            // 
            this.cmb_prodi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prodi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_prodi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prodi.FormattingEnabled = true;
            this.cmb_prodi.Location = new System.Drawing.Point(745, 403);
            this.cmb_prodi.Name = "cmb_prodi";
            this.cmb_prodi.Size = new System.Drawing.Size(285, 28);
            this.cmb_prodi.TabIndex = 76;
            // 
            // buatAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 598);
            this.Controls.Add(this.rdbtn_perempuan);
            this.Controls.Add(this.rdbtn_laki);
            this.Controls.Add(this.cmb_semester);
            this.Controls.Add(this.txt_npm);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.cmb_prodi);
            this.Controls.Add(this.lbl_npm);
            this.Controls.Add(this.lbl_jk);
            this.Controls.Add(this.lbl_semester);
            this.Controls.Add(this.lbl_prodi);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.levelTxt);
            this.Controls.Add(this.buatAkunBtn);
            this.Controls.Add(this.kembaliBtn);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.confirmTxt);
            this.Controls.Add(this.lbl_confirmpw);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "buatAkun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buatAkun";
            this.Load += new System.EventHandler(this.buatAkun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox confirmTxt;
        private System.Windows.Forms.Label lbl_confirmpw;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Button kembaliBtn;
        private System.Windows.Forms.Button buatAkunBtn;
        private System.Windows.Forms.ComboBox levelTxt;
        private System.Windows.Forms.Label lbl_npm;
        private System.Windows.Forms.Label lbl_jk;
        private System.Windows.Forms.Label lbl_semester;
        private System.Windows.Forms.Label lbl_prodi;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.RadioButton rdbtn_perempuan;
        private System.Windows.Forms.RadioButton rdbtn_laki;
        private System.Windows.Forms.ComboBox cmb_semester;
        private System.Windows.Forms.TextBox txt_npm;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.ComboBox cmb_prodi;
    }
}