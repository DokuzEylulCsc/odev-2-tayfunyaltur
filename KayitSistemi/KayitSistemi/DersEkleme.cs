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
    public partial class DersEkleme : Form
    {
        private DerslerVeOgrenciler dvo;
        public DersEkleme(DerslerVeOgrenciler dvo)
        {
            this.dvo = dvo;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    int a = Convert.ToInt32(textBox4.Text);
                    Course c = new Course(textBox1.Text, textBox2.Text, textBox3.Text, a, Fakulteler.fakID);
                    Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].AddCourse(c);
                    dvo.refresh();
                    this.Hide();
                }
                catch (ArgumentException r)
                {
                    MessageBox.Show(r.Message);
                }
                catch
                {
                    MessageBox.Show("Lutfen is yukunu numerik degerlerden girin");
                }
            }
        }
    }
}
