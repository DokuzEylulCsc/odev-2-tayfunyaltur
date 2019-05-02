using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    public partial class DerslerVeOgrenciler : Form
    {
        public DerslerVeOgrenciler()
        {
            InitializeComponent();
        }

        private void DerslerVeOgrenciler_Load(object sender, EventArgs e)
        {
            label1.Text = Universiteler.UniName + " Universitesi " + Fakulteler.fakName + " Fakultesi " + Bolumler.bolumName + " Bolumu";
            refresh();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bolumler bol = new Bolumler();
            bol.Show();
        }

        public void refresh()
        {
            DerslerLb.Items.Clear();
            Ogrenciler.Items.Clear();
            OgretimG.Items.Clear();

            foreach (Course c in Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetCourses.Values)
            {
                DerslerLb.Items.Add(c.GetID + "--->" + c.GetName);
            }
            foreach (Ogrenci c in Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents.Values)
            {
                Ogrenciler.Items.Add(c.GetId + "--->" + c.GetName);
            }
            foreach (OgrentimUyesi c in Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors.Values)
            {
                OgretimG.Items.Add(c.GetID + "--->" + c.GetName);
            }
            if (OgretimG.Items.Count == 0)
            {
                SubeIslemleri.Enabled = false;
            }
            else
            {
                SubeIslemleri.Enabled = true;
            }
        }

        private void DersEkle_Click(object sender, EventArgs e)
        {
            DersEkleme de = new DersEkleme(this);
            de.Show();
            
        }

        private void DersCikar_Click(object sender, EventArgs e)
        {
            if (DerslerLb.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (DerslerLb.SelectedItem.ToString()[i] != '-')
                {
                    ID += DerslerLb.SelectedItem.ToString()[i];
                    i++;
                }
                Course c= Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetCourses[ID];
                Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].RemoveCourse(c);
                refresh();

            }
        }

        private void OgretimEkle_Click(object sender, EventArgs e)
        {
            OgretimGorevlisiEkle ogrEkle = new OgretimGorevlisiEkle(this);
            ogrEkle.Show();
        }

        private void OgretimCikar_Click(object sender, EventArgs e)
        {
            if (OgretimG.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (OgretimG.SelectedItem.ToString()[i] != '-')
                {
                    ID += OgretimG.SelectedItem.ToString()[i];
                    i++;
                }
                try
                {
                    OgrentimUyesi c = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors[ID];
                    Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].RemoveIns(c);
                    refresh();
                }
                catch(Exception a)
                {
                    MessageBox.Show(a.Message);
                }
                
            }
        }

        private void ogrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle oe = new OgrenciEkle(this);
            oe.Show();
        }

        private void ogrenciCikar_Click(object sender, EventArgs e)
        {
            if(Ogrenciler.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (Ogrenciler.SelectedItem.ToString()[i] != '-')
                {
                    ID += Ogrenciler.SelectedItem.ToString()[i];
                    i++;
                }
                try
                {
 
                    Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].RemoveStudent(ID);
                    refresh();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        private void OgrenciBilg_Click(object sender, EventArgs e)
        {
            if (Ogrenciler.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (Ogrenciler.SelectedItem.ToString()[i] != '-')
                {
                    ID += Ogrenciler.SelectedItem.ToString()[i];
                    i++;
                }
                OgrenciBilgileri ob = new OgrenciBilgileri(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents[ID]);
                ob.Show();
            }
           
        }

        private void OgretimBilg_Click(object sender, EventArgs e)
        {
            if (OgretimG.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (OgretimG.SelectedItem.ToString()[i] != '-')
                {
                    ID += OgretimG.SelectedItem.ToString()[i];
                    i++;
                }
                OgrenciBilgileri ob = new OgrenciBilgileri(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors[ID]);
                ob.Show();
            }
        }

        private void SubeIslemleri_Click(object sender, EventArgs e)
        {
            if (DerslerLb.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (DerslerLb.SelectedItem.ToString()[i] != '-')
                {
                    ID += DerslerLb.SelectedItem.ToString()[i];
                    i++;
                }
                SubeIslemleri si = new SubeIslemleri(ID);
                si.Show();
            }
        }

        private void DerslerLb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DerslerLb.SelectedItem != null)
            {
                int i = 0;
                string ID = "";
                while (DerslerLb.SelectedItem.ToString()[i] != '-')
                {
                    ID += DerslerLb.SelectedItem.ToString()[i];
                    i++;
                }
                Course c = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetCourses[ID];
                c.SaveCourse();
                MessageBox.Show("ders basari ile kaydedildi");

            }
            else
            {
                MessageBox.Show("Yazdirilmasini istediginiz dersi listbox icerisinden seciniz");
            }
        }
    }
}
