namespace KayitSistemi
{
    partial class Universiteler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.UniversitelerLB = new System.Windows.Forms.ListBox();
            this.uniNameTxt = new System.Windows.Forms.TextBox();
            this.uniNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ekleButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UniversitelerLB
            // 
            this.UniversitelerLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.UniversitelerLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UniversitelerLB.FormattingEnabled = true;
            this.UniversitelerLB.ItemHeight = 20;
            this.UniversitelerLB.Location = new System.Drawing.Point(16, 14);
            this.UniversitelerLB.Name = "UniversitelerLB";
            this.UniversitelerLB.Size = new System.Drawing.Size(692, 384);
            this.UniversitelerLB.TabIndex = 0;
            // 
            // uniNameTxt
            // 
            this.uniNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uniNameTxt.Location = new System.Drawing.Point(207, 45);
            this.uniNameTxt.Name = "uniNameTxt";
            this.uniNameTxt.Size = new System.Drawing.Size(507, 31);
            this.uniNameTxt.TabIndex = 1;
            // 
            // uniNameLabel
            // 
            this.uniNameLabel.AutoSize = true;
            this.uniNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uniNameLabel.Location = new System.Drawing.Point(25, 48);
            this.uniNameLabel.Name = "uniNameLabel";
            this.uniNameLabel.Size = new System.Drawing.Size(166, 25);
            this.uniNameLabel.TabIndex = 2;
            this.uniNameLabel.Text = "Universite Adi:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ekleButton);
            this.panel1.Controls.Add(this.uniNameLabel);
            this.panel1.Controls.Add(this.uniNameTxt);
            this.panel1.Location = new System.Drawing.Point(7, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 123);
            this.panel1.TabIndex = 3;
            // 
            // ekleButton
            // 
            this.ekleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.Location = new System.Drawing.Point(720, 3);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(117, 115);
            this.ekleButton.TabIndex = 3;
            this.ekleButton.Text = "EKLE";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.UniversitelerLB);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 398);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(714, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 401);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fakulte Islemine Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(762, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(87, 36);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "CIKIS";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Universiteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(861, 583);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Universiteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UniversitelerLB;
        private System.Windows.Forms.TextBox uniNameTxt;
        private System.Windows.Forms.Label uniNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitBtn;
    }
}

