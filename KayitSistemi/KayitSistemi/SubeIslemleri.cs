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
    public partial class SubeIslemleri : Form
    {
        public string ID;
        private Course c;
        public SubeIslemleri(string Id)
        {
            InitializeComponent();
            this.ID=Id;
            c = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetCourses[Id];
        }

        private void SubeIslemleri_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            button2.Enabled = false;
            refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                Dictionary<string, OgrentimUyesi> shocalar = c.getSubeler[listBox1.SelectedItem.ToString()].GetInstructors;
                Dictionary<string, Ogrenci> sasistanlar = c.getSubeler[listBox1.SelectedItem.ToString()].GetAssistants;
                Dictionary<string, Ogrenci> sogr = c.getSubeler[listBox1.SelectedItem.ToString()].GetStudents;
                foreach (OgrentimUyesi ou in shocalar.Values)
                {
                    listBox2.Items.Add(ou.GetID + "-" + ou.GetName + " " + ou.GetSurname);
                }
                foreach (Ogrenci ou in sasistanlar.Values)
                {
                    listBox3.Items.Add(ou.GetId + "-" + ou.GetName + " " + ou.GetSurname);
                }
                foreach (Ogrenci ou in sogr.Values)
                {
                    listBox4.Items.Add(ou.GetId + "-" + ou.GetName + " " + ou.GetSurname);
                }
            }
        }
        public void refresh()
        {
            
            Dictionary<string,Subeler> sbs = c.getSubeler;
            if(sbs.Count > 0) { 
            listBox1.Items.Clear();
            foreach(Subeler s in sbs.Values)
            {
                listBox1.Items.Add(s.GetId);
            }
                }
            if (listBox1.Items.Count > 0)
            {
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                button2.Enabled = false;
            }
           
                
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubeEkle se = new SubeEkle(this,ID);
            se.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.removeSube(c.getSubeler[listBox1.SelectedItem.ToString()]);
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                HAOEkleme hao = new HAOEkleme(1, listBox1.SelectedItem.ToString(), c.GetID, this);
                hao.Show();
            }
            else
            {
                MessageBox.Show("Lutfen sube seciniz");
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                HAOEkleme hao = new HAOEkleme(2, listBox1.SelectedItem.ToString(), c.GetID, this);
                hao.Show();
            }
            else
            {
                MessageBox.Show("Lutfen sube seciniz");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                HAOEkleme hao = new HAOEkleme(3, listBox1.SelectedItem.ToString(), c.GetID, this);
                hao.Show();
            }
            else
            {
                MessageBox.Show("Lutfen sube seciniz");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (listBox2.SelectedItem.ToString()[i] != '-')
                {
                    ID += listBox2.SelectedItem.ToString()[i];
                    i++;
                }
                if(listBox2.Items.Count > 1)
                {
                    OgrentimUyesi hoca = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors[ID];
                    c.getSubeler[ID].removeInstructor(hoca);
                    refresh();
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (listBox3.SelectedItem.ToString()[i] != '-')
                {
                    ID += listBox3.SelectedItem.ToString()[i];
                    i++;
                }
                
                Ogrenci asistan = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents[ID];
                c.getSubeler[ID].removeAssistan(asistan);
                refresh();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (listBox4.SelectedItem.ToString()[i] != '-')
                {
                    ID += listBox4.SelectedItem.ToString()[i];
                    i++;
                }

                Ogrenci ogr = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents[ID];
                c.getSubeler[ID].removeStudent(ogr);
                refresh();
            }
        }
    }
}
