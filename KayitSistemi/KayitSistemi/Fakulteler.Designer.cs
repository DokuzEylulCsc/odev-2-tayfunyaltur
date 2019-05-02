namespace KayitSistemi
{
    partial class Fakulteler
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
            this.secButton = new System.Windows.Forms.Button();
            this.FakultelerLb = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EkleButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fakId = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.secButton);
            this.panel1.Controls.Add(this.FakultelerLb);
            this.panel1.Location = new System.Drawing.Point(13, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 422);
            this.panel1.TabIndex = 0;
            // 
            // secButton
            // 
            this.secButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secButton.Location = new System.Drawing.Point(726, 3);
            this.secButton.Name = "secButton";
            this.secButton.Size = new System.Drawing.Size(107, 426);
            this.secButton.TabIndex = 1;
            this.secButton.Text = "Bolum Islemine Git";
            this.secButton.UseVisualStyleBackColor = true;
            this.secButton.Click += new System.EventHandler(this.secButton_Click);
            // 
            // FakultelerLb
            // 
            this.FakultelerLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.FakultelerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FakultelerLb.FormattingEnabled = true;
            this.FakultelerLb.ItemHeight = 25;
            this.FakultelerLb.Location = new System.Drawing.Point(3, 25);
            this.FakultelerLb.Name = "FakultelerLb";
            this.FakultelerLb.Size = new System.Drawing.Size(717, 404);
            this.FakultelerLb.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EkleButton);
            this.panel2.Controls.Add(this.nameText);
            this.panel2.Controls.Add(this.IdText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fakId);
            this.panel2.Location = new System.Drawing.Point(13, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 100);
            this.panel2.TabIndex = 1;
            // 
            // EkleButton
            // 
            this.EkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleButton.Location = new System.Drawing.Point(732, 4);
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
            this.nameText.Size = new System.Drawing.Size(548, 31);
            this.nameText.TabIndex = 1;
            // 
            // IdText
            // 
            this.IdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IdText.Location = new System.Drawing.Point(172, 17);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(548, 31);
            this.IdText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fakulte Ismi :";
            // 
            // fakId
            // 
            this.fakId.AutoSize = true;
            this.fakId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fakId.Location = new System.Drawing.Point(13, 20);
            this.fakId.Name = "fakId";
            this.fakId.Size = new System.Drawing.Size(133, 25);
            this.fakId.TabIndex = 0;
            this.fakId.Text = "Fakulte ID :";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(762, 7);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(87, 34);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "CIKIS";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(16, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Fakulteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(861, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fakulteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fakulteler";
            this.Load += new System.EventHandler(this.Fakulteler_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button secButton;
        private System.Windows.Forms.ListBox FakultelerLb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.Label fakId;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}