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
    }
}
