namespace KayitSistemi
{
    partial class DerslerVeOgrenciler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubeIslemleri = new System.Windows.Forms.Button();
            this.DersCikar = new System.Windows.Forms.Button();
            this.DersEkle = new System.Windows.Forms.Button();
            this.DerslerLb = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OgretimBilg = new System.Windows.Forms.Button();
            this.OgretimG = new System.Windows.Forms.ListBox();
            this.OgretimCikar = new System.Windows.Forms.Button();
            this.OgretimEkle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OgrenciBilg = new System.Windows.Forms.Button();
            this.Ogrenciler = new System.Windows.Forms.ListBox();
            this.ogrenciEkle = new System.Windows.Forms.Button();
            this.ogrenciCikar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubeIslemleri);
            this.panel1.Controls.Add(this.DersCikar);
            this.panel1.Controls.Add(this.DersEkle);
            this.panel1.Controls.Add(this.DerslerLb);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 523);
            this.panel1.TabIndex = 0;
            // 
            // SubeIslemleri
            // 
            this.SubeIslemleri.Location = new System.Drawing.Point(4, 480);
            this.SubeIslemleri.Name = "SubeIslemleri";
            this.SubeIslemleri.Size = new System.Drawing.Size(230, 37);
            this.SubeIslemleri.TabIndex = 1;
            this.SubeIslemleri.Text = "Sube Islemleri";
            this.SubeIslemleri.UseVisualStyleBackColor = true;
            this.SubeIslemleri.Click += new System.EventHandler(this.SubeIslemleri_Click);
            // 
            // DersCikar
            // 
            this.DersCikar.Location = new System.Drawing.Point(128, 414);
            this.DersCikar.Name = "DersCikar";
            this.DersCikar.Size = new System.Drawing.Size(106, 63);
            this.DersCikar.TabIndex = 1;
            this.DersCikar.Text = "Ders Cikar";
            this.DersCikar.UseVisualStyleBackColor = true;
            this.DersCikar.Click += new System.EventHandler(this.DersCikar_Click);
            // 
            // DersEkle
            // 
            this.DersEkle.Location = new System.Drawing.Point(4, 414);
            this.DersEkle.Name = "DersEkle";
            this.DersEkle.Size = new System.Drawing.Size(118, 63);
            this.DersEkle.TabIndex = 1;
            this.DersEkle.Text = "Ders Ekle";
            this.DersEkle.UseVisualStyleBackColor = true;
            this.DersEkle.Click += new System.EventHandler(this.DersEkle_Click);
            // 
            // DerslerLb
            // 
            this.DerslerLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.DerslerLb.FormattingEnabled = true;
            this.DerslerLb.ItemHeight = 20;
            this.DerslerLb.Location = new System.Drawing.Point(4, 4);
            this.DerslerLb.Name = "DerslerLb";
            this.DerslerLb.Size = new System.Drawing.Size(230, 404);
            this.DerslerLb.TabIndex = 0;
            this.DerslerLb.SelectedIndexChanged += new System.EventHandler(this.DerslerLb_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OgretimBilg);
            this.panel2.Controls.Add(this.OgretimG);
            this.panel2.Controls.Add(this.OgretimCikar);
            this.panel2.Controls.Add(this.OgretimEkle);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(312, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 520);
            this.panel2.TabIndex = 1;
            // 
            // OgretimBilg
            // 
            this.OgretimBilg.Location = new System.Drawing.Point(3, 483);
            this.OgretimBilg.Name = "OgretimBilg";
            this.OgretimBilg.Size = new System.Drawing.Size(230, 34);
            this.OgretimBilg.TabIndex = 1;
            this.OgretimBilg.Text = "Ogr.Gor. Bilgileri";
            this.OgretimBilg.UseVisualStyleBackColor = true;
            this.OgretimBilg.Click += new System.EventHandler(this.OgretimBilg_Click);
            // 
            // OgretimG
            // 
            this.OgretimG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.OgretimG.FormattingEnabled = true;
            this.OgretimG.ItemHeight = 20;
            this.OgretimG.Location = new System.Drawing.Point(3, 3);
            this.OgretimG.Name = "OgretimG";
            this.OgretimG.Size = new System.Drawing.Size(230, 404);
            this.OgretimG.TabIndex = 0;
            // 
            // OgretimCikar
            // 
            this.OgretimCikar.Location = new System.Drawing.Point(129, 411);
            this.OgretimCikar.Name = "OgretimCikar";
            this.OgretimCikar.Size = new System.Drawing.Size(104, 66);
            this.OgretimCikar.TabIndex = 1;
            this.OgretimCikar.Text = "Ogr.Gor. Cikar";
            this.OgretimCikar.UseVisualStyleBackColor = true;
            this.OgretimCikar.Click += new System.EventHandler(this.OgretimCikar_Click);
            // 
            // OgretimEkle
            // 
            this.OgretimEkle.Location = new System.Drawing.Point(3, 411);
            this.OgretimEkle.Name = "OgretimEkle";
            this.OgretimEkle.Size = new System.Drawing.Size(108, 66);
            this.OgretimEkle.TabIndex = 1;
            this.OgretimEkle.Text = "Ogr.Gor. Ekle";
            this.OgretimEkle.UseVisualStyleBackColor = true;
            this.OgretimEkle.Click += new System.EventHandler(this.OgretimEkle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OgrenciBilg);
            this.panel3.Controls.Add(this.Ogrenciler);
            this.panel3.Controls.Add(this.ogrenciEkle);
            this.panel3.Controls.Add(this.ogrenciCikar);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(597, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 520);
            this.panel3.TabIndex = 1;
            // 
            // OgrenciBilg
            // 
            this.OgrenciBilg.Location = new System.Drawing.Point(3, 480);
            this.OgrenciBilg.Name = "OgrenciBilg";
            this.OgrenciBilg.Size = new System.Drawing.Size(230, 37);
            this.OgrenciBilg.TabIndex = 1;
            this.OgrenciBilg.Text = "Ogrenci Bilgileri";
            this.OgrenciBilg.UseVisualStyleBackColor = true;
            this.OgrenciBilg.Click += new System.EventHandler(this.OgrenciBilg_Click);
            // 
            // Ogrenciler
            // 
            this.Ogrenciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.Ogrenciler.FormattingEnabled = true;
            this.Ogrenciler.ItemHeight = 20;
            this.Ogrenciler.Location = new System.Drawing.Point(3, 3);
            this.Ogrenciler.Name = "Ogrenciler";
            this.Ogrenciler.Size = new System.Drawing.Size(230, 404);
            this.Ogrenciler.TabIndex = 0;
            // 
            // ogrenciEkle
            // 
            this.ogrenciEkle.Location = new System.Drawing.Point(3, 413);
            this.ogrenciEkle.Name = "ogrenciEkle";
            this.ogrenciEkle.Size = new System.Drawing.Size(108, 64);
            this.ogrenciEkle.TabIndex = 1;
            this.ogrenciEkle.Text = "Ogrenci Ekle";
            this.ogrenciEkle.UseVisualStyleBackColor = true;
            this.ogrenciEkle.Click += new System.EventHandler(this.ogrenciEkle_Click);
            // 
            // ogrenciCikar
            // 
            this.ogrenciCikar.Location = new System.Drawing.Point(125, 413);
            this.ogrenciCikar.Name = "ogrenciCikar";
            this.ogrenciCikar.Size = new System.Drawing.Size(108, 64);
            this.ogrenciCikar.TabIndex = 1;
            this.ogrenciCikar.Text = "Ogrenci Cikar";
            this.ogrenciCikar.UseVisualStyleBackColor = true;
            this.ogrenciCikar.Click += new System.EventHandler(this.ogrenciCikar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(762, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(87, 36);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "CIKIS";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(650, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Dersi Yaz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DerslerVeOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(861, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DerslerVeOgrenciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DerslerVeOgrenciler";
            this.Load += new System.EventHandler(this.DerslerVeOgrenciler_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SubeIslemleri;
        private System.Windows.Forms.Button DersCikar;
        private System.Windows.Forms.Button DersEkle;
        private System.Windows.Forms.ListBox DerslerLb;
        private System.Windows.Forms.Button OgretimBilg;
        private System.Windows.Forms.ListBox OgretimG;
        private System.Windows.Forms.Button OgretimCikar;
        private System.Windows.Forms.Button OgretimEkle;
        private System.Windows.Forms.Button OgrenciBilg;
        private System.Windows.Forms.ListBox Ogrenciler;
        private System.Windows.Forms.Button ogrenciEkle;
        private System.Windows.Forms.Button ogrenciCikar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}