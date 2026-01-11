namespace stokSatis_Akay.UI
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnAlanlariTemizle = new System.Windows.Forms.Button();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_alim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(187, 150);
            this.txtMusteriAra.Margin = new System.Windows.Forms.Padding(5);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(184, 34);
            this.txtMusteriAra.TabIndex = 1;
            this.txtMusteriAra.TextChanged += new System.EventHandler(this.txtMusteriAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(10, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Ara:";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMusteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(418, 40);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(193, 44);
            this.btnMusteriEkle.TabIndex = 3;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMusteriGuncelle.FlatAppearance.BorderSize = 0;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(418, 102);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(193, 44);
            this.btnMusteriGuncelle.TabIndex = 4;
            this.btnMusteriGuncelle.Text = "Müşteri Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.Crimson;
            this.btnMusteriSil.FlatAppearance.BorderSize = 0;
            this.btnMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriSil.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriSil.Location = new System.Drawing.Point(650, 40);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(193, 44);
            this.btnMusteriSil.TabIndex = 5;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnAlanlariTemizle
            // 
            this.btnAlanlariTemizle.BackColor = System.Drawing.Color.Orange;
            this.btnAlanlariTemizle.FlatAppearance.BorderSize = 0;
            this.btnAlanlariTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlanlariTemizle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlanlariTemizle.Location = new System.Drawing.Point(650, 102);
            this.btnAlanlariTemizle.Name = "btnAlanlariTemizle";
            this.btnAlanlariTemizle.Size = new System.Drawing.Size(193, 44);
            this.btnAlanlariTemizle.TabIndex = 7;
            this.btnAlanlariTemizle.Text = "Temizle";
            this.btnAlanlariTemizle.UseVisualStyleBackColor = false;
            this.btnAlanlariTemizle.Click += new System.EventHandler(this.btnAlanlariTemizle_Click);
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(187, 29);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(187, 34);
            this.txtMusteriAd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefon:";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AllowUserToOrderColumns = true;
            this.dgvMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMusteriler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri_id,
            this.adSoyad,
            this.telefon,
            this.toplam_alim});
            this.dgvMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriler.EnableHeadersVisualStyles = false;
            this.dgvMusteriler.Location = new System.Drawing.Point(0, 200);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RowHeadersWidth = 51;
            this.dgvMusteriler.RowTemplate.Height = 24;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(882, 353);
            this.dgvMusteriler.TabIndex = 13;
            this.dgvMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_CellContentClick_1);
            // 
            // musteri_id
            // 
            this.musteri_id.DataPropertyName = "musteri_id";
            this.musteri_id.HeaderText = "ID";
            this.musteri_id.MinimumWidth = 6;
            this.musteri_id.Name = "musteri_id";
            this.musteri_id.Visible = false;
            // 
            // adSoyad
            // 
            this.adSoyad.DataPropertyName = "adSoyad";
            this.adSoyad.HeaderText = "Ad Soyad";
            this.adSoyad.MinimumWidth = 6;
            this.adSoyad.Name = "adSoyad";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.MinimumWidth = 6;
            this.telefon.Name = "telefon";
            // 
            // toplam_alim
            // 
            this.toplam_alim.DataPropertyName = "toplam_alim";
            this.toplam_alim.HeaderText = "Toplam Alım";
            this.toplam_alim.MinimumWidth = 6;
            this.toplam_alim.Name = "toplam_alim";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 200);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMusteriId);
            this.panel2.Controls.Add(this.txtTelefon);
            this.panel2.Controls.Add(this.txtMusteriAra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAlanlariTemizle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnMusteriSil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnMusteriGuncelle);
            this.panel2.Controls.Add(this.txtMusteriAd);
            this.panel2.Controls.Add(this.btnMusteriEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 193);
            this.panel2.TabIndex = 15;
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(836, 3);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(132, 34);
            this.txtMusteriId.TabIndex = 14;
            this.txtMusteriId.Visible = false;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(187, 82);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(184, 34);
            this.txtTelefon.TabIndex = 13;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomerForm";
            this.Text = "Müşteriler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnAlanlariTemizle;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_alim;
        private System.Windows.Forms.Panel panel2;
    }
}