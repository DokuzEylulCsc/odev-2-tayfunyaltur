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
    public partial class SubeEkle : Form
    {
        SubeIslemleri si;
        Dictionary<string,OgrentimUyesi> hocalar;
        string ID;
        public SubeEkle(SubeIslemleri si,string ID)
        {
            this.ID = ID;
            this.si = si;
            hocalar = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors;
            InitializeComponent();
        }

        private void SubeEkle_Load(object sender, EventArgs e)
        {
            foreach (OgrentimUyesi ou in hocalar.Values)
            {
                listBox1.Items.Add(ou.GetID + "-" + ou.GetName + ou.GetSurname);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null&&textBox1.Text != "")
            {
                int i = 0;
                string ID1 = "";
                while (listBox1.SelectedItem.ToString()[i] != '-')
                {
                    ID1 += listBox1.SelectedItem.ToString()[i];
                    i++;
                }
                OgrentimUyesi ins = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors[ID1];
                try
                {
                    Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetCourses[si.ID].AddSube(new Subeler(textBox1.Text, ins));
                    this.Hide();
                    si.refresh();
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }
    }
}
