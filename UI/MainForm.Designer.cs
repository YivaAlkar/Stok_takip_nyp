namespace stokSatis_Akay.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.satısBtn = new System.Windows.Forms.Button();
            this.musteriBtn = new System.Windows.Forms.Button();
            this.ürünBtn = new System.Windows.Forms.Button();
            this.raporBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblToplamMusteri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // satısBtn
            // 
            this.satısBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.satısBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.satısBtn.FlatAppearance.BorderSize = 0;
            this.satısBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satısBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satısBtn.ForeColor = System.Drawing.Color.White;
            this.satısBtn.Location = new System.Drawing.Point(63, 325);
            this.satısBtn.Margin = new System.Windows.Forms.Padding(5);
            this.satısBtn.Name = "satısBtn";
            this.satısBtn.Size = new System.Drawing.Size(220, 60);
            this.satısBtn.TabIndex = 3;
            this.satısBtn.Text = "Satış";
            this.satısBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.satısBtn.UseVisualStyleBackColor = false;
            this.satısBtn.Click += new System.EventHandler(this.satısBtn_Click);
            // 
            // musteriBtn
            // 
            this.musteriBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.musteriBtn.FlatAppearance.BorderSize = 0;
            this.musteriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriBtn.ForeColor = System.Drawing.Color.White;
            this.musteriBtn.Location = new System.Drawing.Point(63, 245);
            this.musteriBtn.Margin = new System.Windows.Forms.Padding(5);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(220, 60);
            this.musteriBtn.TabIndex = 2;
            this.musteriBtn.Text = "Müşteriler";
            this.musteriBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriBtn.UseVisualStyleBackColor = false;
            this.musteriBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // ürünBtn
            // 
            this.ürünBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ürünBtn.FlatAppearance.BorderSize = 0;
            this.ürünBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ürünBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünBtn.ForeColor = System.Drawing.Color.White;
            this.ürünBtn.Location = new System.Drawing.Point(63, 158);
            this.ürünBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ürünBtn.Name = "ürünBtn";
            this.ürünBtn.Size = new System.Drawing.Size(220, 60);
            this.ürünBtn.TabIndex = 1;
            this.ürünBtn.Text = "Ürünler";
            this.ürünBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ürünBtn.UseVisualStyleBackColor = false;
            this.ürünBtn.Click += new System.EventHandler(this.ürünBtn_Click);
            // 
            // raporBtn
            // 
            this.raporBtn.BackColor = System.Drawing.Color.Firebrick;
            this.raporBtn.FlatAppearance.BorderSize = 0;
            this.raporBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raporBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporBtn.ForeColor = System.Drawing.Color.White;
            this.raporBtn.Location = new System.Drawing.Point(63, 410);
            this.raporBtn.Margin = new System.Windows.Forms.Padding(5);
            this.raporBtn.Name = "raporBtn";
            this.raporBtn.Size = new System.Drawing.Size(220, 60);
            this.raporBtn.TabIndex = 0;
            this.raporBtn.Text = "Rapor";
            this.raporBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raporBtn.UseVisualStyleBackColor = false;
            this.raporBtn.Click += new System.EventHandler(this.raporBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.raporBtn);
            this.panel1.Controls.Add(this.satısBtn);
            this.panel1.Controls.Add(this.ürünBtn);
            this.panel1.Controls.Add(this.musteriBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 553);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKAY YAPI\r\nYÖNETİM SİSTEMİ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label45);
            this.panel2.Controls.Add(this.lblToplamUrun);
            this.panel2.Location = new System.Drawing.Point(126, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 138);
            this.panel2.TabIndex = 7;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI", 30.8F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(3, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(210, 140);
            this.label45.TabIndex = 3;
            this.label45.Text = "Toplam\r\nÜrün";
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblToplamUrun.ForeColor = System.Drawing.Color.White;
            this.lblToplamUrun.Location = new System.Drawing.Point(200, 31);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(67, 78);
            this.lblToplamUrun.TabIndex = 1;
            this.lblToplamUrun.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.lblToplamMusteri);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(126, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 138);
            this.panel3.TabIndex = 8;
            // 
            // lblToplamMusteri
            // 
            this.lblToplamMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamMusteri.AutoSize = true;
            this.lblToplamMusteri.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblToplamMusteri.ForeColor = System.Drawing.Color.White;
            this.lblToplamMusteri.Location = new System.Drawing.Point(200, 36);
            this.lblToplamMusteri.Name = "lblToplamMusteri";
            this.lblToplamMusteri.Size = new System.Drawing.Size(67, 78);
            this.lblToplamMusteri.TabIndex = 2;
            this.lblToplamMusteri.Text = "0";
            this.lblToplamMusteri.Click += new System.EventHandler(this.lblToplamMusteri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 140);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri \r\nSayısı";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.lblToplamSatis);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(126, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 138);
            this.panel4.TabIndex = 8;
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblToplamSatis.ForeColor = System.Drawing.Color.White;
            this.lblToplamSatis.Location = new System.Drawing.Point(200, 27);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(67, 78);
            this.lblToplamSatis.TabIndex = 3;
            this.lblToplamSatis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 140);
            this.label4.TabIndex = 0;
            this.label4.Text = "Satış \r\nSayısı";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTarih);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(368, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(514, 553);
            this.panel5.TabIndex = 7;
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(15, 517);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(79, 27);
            this.lblTarih.TabIndex = 9;
            this.lblTarih.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Ana Kısım";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button satısBtn;
        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Button ürünBtn;
        private System.Windows.Forms.Button raporBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Label lblToplamMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTarih;
    }
}