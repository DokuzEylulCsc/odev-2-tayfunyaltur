namespace KayitSistemi
{
    partial class OgrenciBilgileri
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AdLbl = new System.Windows.Forms.Label();
            this.SoyadLbl = new System.Windows.Forms.Label();
            this.NumaraLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "NUMARASI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(115, 213);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(126, 95);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "KAPAT";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AdLbl
            // 
            this.AdLbl.AutoSize = true;
            this.AdLbl.Location = new System.Drawing.Point(148, 57);
            this.AdLbl.Name = "AdLbl";
            this.AdLbl.Size = new System.Drawing.Size(40, 20);
            this.AdLbl.TabIndex = 0;
            this.AdLbl.Text = "ADI";
            // 
            // SoyadLbl
            // 
            this.SoyadLbl.AutoSize = true;
            this.SoyadLbl.Location = new System.Drawing.Point(148, 109);
            this.SoyadLbl.Name = "SoyadLbl";
            this.SoyadLbl.Size = new System.Drawing.Size(77, 20);
            this.SoyadLbl.TabIndex = 0;
            this.SoyadLbl.Text = "SOYADI";
            // 
            // NumaraLbl
            // 
            this.NumaraLbl.AutoSize = true;
            this.NumaraLbl.Location = new System.Drawing.Point(148, 165);
            this.NumaraLbl.Name = "NumaraLbl";
            this.NumaraLbl.Size = new System.Drawing.Size(103, 20);
            this.NumaraLbl.TabIndex = 0;
            this.NumaraLbl.Text = "NUMARASI";
            // 
            // OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(366, 320);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NumaraLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SoyadLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OgrenciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciBilgileri";
            this.Load += new System.EventHandler(this.OgrenciBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AdLbl;
        private System.Windows.Forms.Label SoyadLbl;
        private System.Windows.Forms.Label NumaraLbl;
    }
}