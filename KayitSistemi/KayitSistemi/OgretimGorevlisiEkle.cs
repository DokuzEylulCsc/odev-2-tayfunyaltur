using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    public partial class OgretimGorevlisiEkle : Form
    {
        private DerslerVeOgrenciler dvo;
        public OgretimGorevlisiEkle(DerslerVeOgrenciler dvo)
        {
            this.dvo = dvo;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].AddIns(textBox2.Text, textBox3.Text, textBox1.Text);
                    dvo.refresh();
                    this.Hide();
                }
                catch(ArgumentException a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
