namespace KayitSistemi
{
    partial class OgrenciEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.lisansRb = new System.Windows.Forms.RadioButton();
            this.yuksekrb = new System.Windows.Forms.RadioButton();
            this.doktoraRb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrenci Ekleme Sayfasi";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 26);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 26);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 26);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ogrenci Soyadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ogrenci Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ogrenci  Id";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(223, 213);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(126, 95);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 213);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(126, 95);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Iptal";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // lisansRb
            // 
            this.lisansRb.AutoSize = true;
            this.lisansRb.Location = new System.Drawing.Point(12, 190);
            this.lisansRb.Name = "lisansRb";
            this.lisansRb.Size = new System.Drawing.Size(79, 24);
            this.lisansRb.TabIndex = 20;
            this.lisansRb.TabStop = true;
            this.lisansRb.Text = "Lisans";
            this.lisansRb.UseVisualStyleBackColor = true;
            // 
            // yuksekrb
            // 
            this.yuksekrb.AutoSize = true;
            this.yuksekrb.Location = new System.Drawing.Point(104, 190);
            this.yuksekrb.Name = "yuksekrb";
            this.yuksekrb.Size = new System.Drawing.Size(143, 24);
            this.yuksekrb.TabIndex = 20;
            this.yuksekrb.TabStop = true;
            this.yuksekrb.Text = "Yuksek Lisans";
            this.yuksekrb.UseVisualStyleBackColor = true;
            // 
            // doktoraRb
            // 
            this.doktoraRb.AutoSize = true;
            this.doktoraRb.Location = new System.Drawing.Point(253, 190);
            this.doktoraRb.Name = "doktoraRb";
            this.doktoraRb.Size = new System.Drawing.Size(91, 24);
            this.doktoraRb.TabIndex = 21;
            this.doktoraRb.TabStop = true;
            this.doktoraRb.Text = "Doktora";
            this.doktoraRb.UseVisualStyleBackColor = true;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(366, 320);
            this.Controls.Add(this.doktoraRb);
            this.Controls.Add(this.yuksekrb);
            this.Controls.Add(this.lisansRb);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OgrenciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton lisansRb;
        private System.Windows.Forms.RadioButton yuksekrb;
        private System.Windows.Forms.RadioButton doktoraRb;
    }
}