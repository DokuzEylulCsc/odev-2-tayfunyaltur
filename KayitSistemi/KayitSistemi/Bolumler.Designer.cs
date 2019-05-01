namespace KayitSistemi
{
    partial class Bolumler
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
            this.button1 = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EkleButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fakId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secButton = new System.Windows.Forms.Button();
            this.BolumlerLb = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(660, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(87, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "CIKIS";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EkleButton);
            this.panel2.Controls.Add(this.nameText);
            this.panel2.Controls.Add(this.IdText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fakId);
            this.panel2.Location = new System.Drawing.Point(12, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 100);
            this.panel2.TabIndex = 9;
            // 
            // EkleButton
            // 
            this.EkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleButton.Location = new System.Drawing.Point(625, 4);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(104, 93);
            this.EkleButton.TabIndex = 2;
            this.EkleButton.Text = "EKLE";
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameText.Location = new System.Drawing.Point(172, 56);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(447, 31);
            this.nameText.TabIndex = 1;
            // 
            // IdText
            // 
            this.IdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IdText.Location = new System.Drawing.Point(172, 17);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(447, 31);
            this.IdText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bolum Ismi :";
            // 
            // fakId
            // 
            this.fakId.AutoSize = true;
            this.fakId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fakId.Location = new System.Drawing.Point(13, 20);
            this.fakId.Name = "fakId";
            this.fakId.Size = new System.Drawing.Size(120, 25);
            this.fakId.TabIndex = 0;
            this.fakId.Text = "Bolum ID :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.secButton);
            this.panel1.Controls.Add(this.BolumlerLb);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 225);
            this.panel1.TabIndex = 8;
            // 
            // secButton
            // 
            this.secButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secButton.Location = new System.Drawing.Point(593, 3);
            this.secButton.Name = "secButton";
            this.secButton.Size = new System.Drawing.Size(139, 204);
            this.secButton.TabIndex = 1;
            this.secButton.Text = "Ders ve Ogrenci islemlerine Git";
            this.secButton.UseVisualStyleBackColor = true;
            this.secButton.Click += new System.EventHandler(this.secButton_Click);
            // 
            // BolumlerLb
            // 
            this.BolumlerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BolumlerLb.FormattingEnabled = true;
            this.BolumlerLb.ItemHeight = 25;
            this.BolumlerLb.Location = new System.Drawing.Point(3, 3);
            this.BolumlerLb.Name = "BolumlerLb";
            this.BolumlerLb.Size = new System.Drawing.Size(584, 204);
            this.BolumlerLb.TabIndex = 0;
            // 
            // Bolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.Bolumler_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fakId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button secButton;
        private System.Windows.Forms.ListBox BolumlerLb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}