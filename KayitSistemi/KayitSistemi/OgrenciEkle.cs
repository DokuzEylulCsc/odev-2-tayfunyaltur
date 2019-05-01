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
    public partial class OgrenciEkle : Form
    {
        private DerslerVeOgrenciler dvo;
        public OgrenciEkle(DerslerVeOgrenciler dvo)
        {
            this.dvo = dvo;
            InitializeComponent();
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            lisansRb.Checked = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    if (lisansRb.Checked)
                    {
                        Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].AddLisans(textBox1.Text, textBox2.Text, textBox3.Text);
                    }
                    else if (yuksekrb.Checked)
                    {
                        Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].AddYuksek(textBox1.Text, textBox2.Text, textBox3.Text);
                    }
                    else
                    {
                        Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].AddDoktora(textBox1.Text, textBox2.Text, textBox3.Text);
                    }
                }
                dvo.refresh();
                this.Hide();
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
