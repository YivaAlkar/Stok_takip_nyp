namespace stokSatis_Akay.UI
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSatisiOnayla = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSepet
            // 
            this.dgvSepet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.UrunId,
            this.colAdet,
            this.colFiyat,
            this.colToplam});
            this.dgvSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSepet.Location = new System.Drawing.Point(280, 100);
            this.dgvSepet.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.RowHeadersWidth = 51;
            this.dgvSepet.RowTemplate.Height = 24;
            this.dgvSepet.Size = new System.Drawing.Size(602, 453);
            this.dgvSepet.TabIndex = 6;
            this.dgvSepet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepet_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // UrunId
            // 
            this.UrunId.HeaderText = "Ürün Adı";
            this.UrunId.MinimumWidth = 6;
            this.UrunId.Name = "UrunId";
            // 
            // colAdet
            // 
            this.colAdet.HeaderText = "Adet";
            this.colAdet.MinimumWidth = 6;
            this.colAdet.Name = "colAdet";
            // 
            // colFiyat
            // 
            this.colFiyat.HeaderText = "Fiyat";
            this.colFiyat.MinimumWidth = 6;
            this.colFiyat.Name = "colFiyat";
            // 
            // colToplam
            // 
            this.colToplam.HeaderText = "Toplam";
            this.colToplam.MinimumWidth = 6;
            this.colToplam.Name = "colToplam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 100);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(510, 59);
            this.label4.TabIndex = 0;
            this.label4.Text = "AKAY YAPI - Satış Paneli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(30, 264);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(200, 34);
            this.txtAdet.TabIndex = 1;
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(30, 64);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(200, 35);
            this.cmbMusteriler.TabIndex = 8;
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUrunler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(30, 164);
            this.cmbUrunler.Margin = new System.Windows.Forms.Padding(5);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(196, 35);
            this.cmbUrunler.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Müşteri";
            // 
            // btnSatisiOnayla
            // 
            this.btnSatisiOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSatisiOnayla.BackColor = System.Drawing.Color.Navy;
            this.btnSatisiOnayla.FlatAppearance.BorderSize = 0;
            this.btnSatisiOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisiOnayla.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisiOnayla.ForeColor = System.Drawing.Color.White;
            this.btnSatisiOnayla.Location = new System.Drawing.Point(429, 26);
            this.btnSatisiOnayla.Margin = new System.Windows.Forms.Padding(5);
            this.btnSatisiOnayla.Name = "btnSatisiOnayla";
            this.btnSatisiOnayla.Size = new System.Drawing.Size(168, 60);
            this.btnSatisiOnayla.TabIndex = 4;
            this.btnSatisiOnayla.Text = "Satış Onay ";
            this.btnSatisiOnayla.UseVisualStyleBackColor = false;
            this.btnSatisiOnayla.Click += new System.EventHandler(this.btnSatisiOnayla_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.Blue;
            this.btnSepeteEkle.FlatAppearance.BorderSize = 0;
            this.btnSepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.White;
            this.btnSepeteEkle.Location = new System.Drawing.Point(30, 334);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(200, 64);
            this.btnSepeteEkle.TabIndex = 3;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(8, 52);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(169, 27);
            this.lblToplamTutar.TabIndex = 5;
            this.lblToplamTutar.Text = "Toplam Tutar: ";
            this.lblToplamTutar.Click += new System.EventHandler(this.lblToplamTutar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürün";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtAdet);
            this.panel3.Controls.Add(this.cmbMusteriler);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbUrunler);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSepeteEkle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 453);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblToplamTutar);
            this.panel4.Controls.Add(this.btnSatisiOnayla);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(280, 453);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 100);
            this.panel4.TabIndex = 13;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalesForm";
            this.Text = "Satışlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSatisiOnayla;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}