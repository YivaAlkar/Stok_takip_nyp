namespace stokSatis_Akay
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.kullaniciTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.pnlKayit = new System.Windows.Forms.Panel();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbYeniRol = new System.Windows.Forms.ComboBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniAd = new System.Windows.Forms.TextBox();
            this.btnKayitGit = new System.Windows.Forms.Button();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlKayit.SuspendLayout();
            this.pnlGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullaniciTxt
            // 
            this.kullaniciTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kullaniciTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciTxt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTxt.Location = new System.Drawing.Point(29, 111);
            this.kullaniciTxt.Name = "kullaniciTxt";
            this.kullaniciTxt.Size = new System.Drawing.Size(253, 40);
            this.kullaniciTxt.TabIndex = 3;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(29, 165);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(253, 47);
            this.sifreTxt.TabIndex = 4;
            this.sifreTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.girisBtn.FlatAppearance.BorderSize = 0;
            this.girisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.girisBtn.Location = new System.Drawing.Point(27, 234);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(255, 50);
            this.girisBtn.TabIndex = 5;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // pnlKayit
            // 
            this.pnlKayit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlKayit.BackColor = System.Drawing.Color.Transparent;
            this.pnlKayit.Controls.Add(this.btnVazgec);
            this.pnlKayit.Controls.Add(this.btnKaydet);
            this.pnlKayit.Controls.Add(this.cmbYeniRol);
            this.pnlKayit.Controls.Add(this.txtYeniSifre);
            this.pnlKayit.Controls.Add(this.txtYeniAd);
            this.pnlKayit.Location = new System.Drawing.Point(508, 126);
            this.pnlKayit.Name = "pnlKayit";
            this.pnlKayit.Size = new System.Drawing.Size(325, 360);
            this.pnlKayit.TabIndex = 6;
            this.pnlKayit.Visible = false;
            this.pnlKayit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKayit_Paint);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVazgec.FlatAppearance.BorderSize = 0;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVazgec.Location = new System.Drawing.Point(43, 282);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(255, 50);
            this.btnVazgec.TabIndex = 14;
            this.btnVazgec.Text = "Geri Dön";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(42, 222);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(255, 50);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbYeniRol
            // 
            this.cmbYeniRol.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYeniRol.FormattingEnabled = true;
            this.cmbYeniRol.Items.AddRange(new object[] {
            "Yönetici",
            "Satış Personeli",
            "Depo Görevlisi"});
            this.cmbYeniRol.Location = new System.Drawing.Point(43, 151);
            this.cmbYeniRol.Name = "cmbYeniRol";
            this.cmbYeniRol.Size = new System.Drawing.Size(254, 49);
            this.cmbYeniRol.TabIndex = 12;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(43, 85);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(254, 47);
            this.txtYeniSifre.TabIndex = 10;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            this.txtYeniSifre.TextChanged += new System.EventHandler(this.txtYeniSifre_TextChanged);
            // 
            // txtYeniAd
            // 
            this.txtYeniAd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniAd.Location = new System.Drawing.Point(43, 21);
            this.txtYeniAd.Name = "txtYeniAd";
            this.txtYeniAd.Size = new System.Drawing.Size(254, 47);
            this.txtYeniAd.TabIndex = 9;
            this.txtYeniAd.TextChanged += new System.EventHandler(this.txtYeniAd_TextChanged);
            // 
            // btnKayitGit
            // 
            this.btnKayitGit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKayitGit.FlatAppearance.BorderSize = 0;
            this.btnKayitGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitGit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKayitGit.Location = new System.Drawing.Point(29, 294);
            this.btnKayitGit.Name = "btnKayitGit";
            this.btnKayitGit.Size = new System.Drawing.Size(255, 50);
            this.btnKayitGit.TabIndex = 7;
            this.btnKayitGit.Text = "Kayıt Ol ";
            this.btnKayitGit.UseVisualStyleBackColor = false;
            this.btnKayitGit.Click += new System.EventHandler(this.btnKayitGit_Click);
            // 
            // pnlGiris
            // 
            this.pnlGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGiris.BackColor = System.Drawing.Color.Transparent;
            this.pnlGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlGiris.Controls.Add(this.label5);
            this.pnlGiris.Controls.Add(this.btnKayitGit);
            this.pnlGiris.Controls.Add(this.girisBtn);
            this.pnlGiris.Controls.Add(this.sifreTxt);
            this.pnlGiris.Controls.Add(this.kullaniciTxt);
            this.pnlGiris.Location = new System.Drawing.Point(12, 123);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(325, 363);
            this.pnlGiris.TabIndex = 8;
            this.pnlGiris.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 81);
            this.label5.TabIndex = 8;
            this.label5.Text = "Akay Yapı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.pnlKayit);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.giris_Load);
            this.pnlKayit.ResumeLayout(false);
            this.pnlKayit.PerformLayout();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox kullaniciTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Panel pnlKayit;
        private System.Windows.Forms.Button btnKayitGit;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbYeniRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtYeniAd;
    }
}

