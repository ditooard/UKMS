namespace UKMS.view
{
    partial class lupaPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lupaPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_lupapw = new System.Windows.Forms.Label();
            this.txt_lupapw = new System.Windows.Forms.TextBox();
            this.btn_kirim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kembaliBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_lupapw
            // 
            this.lbl_lupapw.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lupapw.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lupapw.Location = new System.Drawing.Point(577, 333);
            this.lbl_lupapw.Name = "lbl_lupapw";
            this.lbl_lupapw.Size = new System.Drawing.Size(160, 33);
            this.lbl_lupapw.TabIndex = 7;
            this.lbl_lupapw.Text = "Masukkan E-mail";
            this.lbl_lupapw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_lupapw
            // 
            this.txt_lupapw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lupapw.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lupapw.Location = new System.Drawing.Point(753, 333);
            this.txt_lupapw.Multiline = true;
            this.txt_lupapw.Name = "txt_lupapw";
            this.txt_lupapw.Size = new System.Drawing.Size(279, 33);
            this.txt_lupapw.TabIndex = 8;
            // 
            // btn_kirim
            // 
            this.btn_kirim.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kirim.Location = new System.Drawing.Point(643, 418);
            this.btn_kirim.Name = "btn_kirim";
            this.btn_kirim.Size = new System.Drawing.Size(121, 53);
            this.btn_kirim.TabIndex = 9;
            this.btn_kirim.Text = "Kirim";
            this.btn_kirim.UseVisualStyleBackColor = true;
            this.btn_kirim.Click += new System.EventHandler(this.btn_kirim_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 85);
            this.label1.TabIndex = 10;
            this.label1.Text = "Permohonan untuk me-reset Password \r\nakan kami kirimkan menuju e-mail yang terdaf" +
    "tar pada akun.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kembaliBtn
            // 
            this.kembaliBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembaliBtn.Location = new System.Drawing.Point(795, 418);
            this.kembaliBtn.Name = "kembaliBtn";
            this.kembaliBtn.Size = new System.Drawing.Size(121, 53);
            this.kembaliBtn.TabIndex = 11;
            this.kembaliBtn.Text = "Kembali";
            this.kembaliBtn.UseVisualStyleBackColor = true;
            this.kembaliBtn.Click += new System.EventHandler(this.kembaliBtn_Click);
            // 
            // lupaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 599);
            this.Controls.Add(this.kembaliBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kirim);
            this.Controls.Add(this.txt_lupapw);
            this.Controls.Add(this.lbl_lupapw);
            this.Controls.Add(this.pictureBox1);
            this.Name = "lupaPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lupaPassword";
            this.Load += new System.EventHandler(this.lupaPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_lupapw;
        private System.Windows.Forms.TextBox txt_lupapw;
        private System.Windows.Forms.Button btn_kirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kembaliBtn;
    }
}