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
    public partial class HAOEkleme : Form
    {
        
        int a;
        Subeler sb;
        SubeIslemleri si;
        public HAOEkleme(int a , string sbID,string courseID,SubeIslemleri si)
        {
            this.a = a;
            sb = Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetCourses[courseID].getSubeler[sbID];
            this.si = si;
            InitializeComponent();
            
        }

        private void HAOEkleme_Load(object sender, EventArgs e)
        {
            switch (a)
            {
                case 1:                   
                        foreach (OgrentimUyesi ou in Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors.Values)
                        {
                            listBox1.Items.Add(ou.GetID + "-" + ou.GetName + " " + ou.GetSurname);
                        }                   
                    break;
                case 2:
                    foreach (Ogrenci ou in Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents.Values)
                    {
                        if(ou is YuksekLisansOgrenci || ou is DoktoraOgrenci)
                        listBox1.Items.Add(ou.GetId + "-" + ou.GetName + " " + ou.GetSurname);
                    }
                    break;
                case 3:
                    panel1.Visible = true;
                    foreach (Ogrenci ou in Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents.Values)
                    {
                        listBox1.SelectionMode = SelectionMode.MultiExtended;
                            listBox1.Items.Add(ou.GetId + "-" + ou.GetName + " " + ou.GetSurname);
                    }
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 1:
                    if (checkBox1.Checked)
                    {
                        try
                        {
                            sb.addInstructor(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors[textBox1.Text]);
                            this.Hide();
                            si.refresh();
                            si.selectFirstIndex();
                            
                        }
                        catch
                        {
                            MessageBox.Show("Bu kisi bulunamamis olabilir ya da daha onceden eklenmis olabilir");
                        }
                        
                    }
                    else
                    {
                        if (listBox1.SelectedItem != null)
                        {
                            int i = 0;
                            string ID = "";
                            while (listBox1.SelectedItem.ToString()[i] != '-')
                            {
                                ID += listBox1.SelectedItem.ToString()[i];
                                i++;
                            }
                            try
                            {
                                sb.addInstructor(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetInstructors[ID]);
                                this.Hide();
                                si.refresh();
                                si.selectFirstIndex();
                            }
                            catch(ArgumentException a)
                            {
                                MessageBox.Show(a.Message);
                            }
                            
                        }
                    }
                    break;
                case 2:
                    if (checkBox1.Checked)
                    {
                        try
                        {
                            sb.addAssistant(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents[textBox1.Text]);
                            this.Hide();
                            si.refresh();
                            si.selectFirstIndex();
                        }
                        catch
                        {
                            MessageBox.Show("Bu kisi bulunamamis olabilir ya da daha onceden eklenmis olabilir");
                        }
                    }
                    else
                    {
                        if (listBox1.SelectedItem != null)
                        {
                            int i = 0;
                            string ID = "";
                            while (listBox1.SelectedItem.ToString()[i] != '-')
                            {
                                ID += listBox1.SelectedItem.ToString()[i];
                                i++;
                            }
                            try
                            {
                                sb.addAssistant(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents[ID]);
                                this.Hide();
                                si.refresh();
                                si.selectFirstIndex();
                            }
                            catch (ArgumentException a)
                            {
                                MessageBox.Show(a.Message);
                            }

                        }
                    }
                    break;
                case 3:
                    if (checkBox1.Checked)
                    {

                        try
                        {
                            sb.addStudent(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents[textBox1.Text]);
                            this.Hide();
                            si.refresh();
                            si.selectFirstIndex();
                        }
                        catch
                        {
                            MessageBox.Show("Bu kisi bulunamamis olabilir ya da daha onceden eklenmis olabilir");
                        }
                    }
                    else
                    {
                        int i = 0;
                        string ID = "";
                        if (listBox1.SelectedItem != null)
                        {
                            
                            foreach(object o in listBox1.SelectedItems) {
                                i = 0;
                                ID = "";
                                while (o.ToString()[i] != '-')
                                {
                                    ID += o.ToString()[i];
                                    i++;
                                }
                                try
                                {
                                     sb.addStudent(Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms[Bolumler.bolumId].GetSutdents[ID]);
                                    
                                }
                                catch (ArgumentException a)
                                {
                                    MessageBox.Show(a.Message);
                                }
                            }
                            this.Hide();
                            si.refresh();
                            si.selectFirstIndex();

                        }
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
