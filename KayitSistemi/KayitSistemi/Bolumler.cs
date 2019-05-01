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
    public partial class Bolumler : Form
    {
        public static string bolumName;
        public static string bolumId;
        public Bolumler()
        {
            InitializeComponent();
        }

        private void Bolumler_Load(object sender, EventArgs e)
        {
            bolumId = "";
            bolumName = "";
            label1.Text = Universiteler.UniName + " Universitesi " + Fakulteler.fakName + " Fakultesi";
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fakulteler fak = new Fakulteler();
            fak.Show();
            this.Hide();
        }

        public void refresh()
        {
            BolumlerLb.Items.Clear();
            foreach (DProgram p in Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].GetPrograms.Values)
            {
                BolumlerLb.Items.Add(p.GetID + "--->" + p.GetName);
            }
            if (BolumlerLb.Items.Count == 0)
            {
                panel1.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            if (IdText.Text != "" && nameText.Text != "")
            {
                try
                {
                    Universite.GetUnis[Universiteler.UniName].GetDepartments[Fakulteler.fakID].AddProgram(IdText.Text, nameText.Text);
                    refresh();
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            
           
        }

        private void secButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (BolumlerLb.SelectedItem != null)
            {
                while (BolumlerLb.SelectedItem.ToString()[i] != '-' && BolumlerLb.SelectedItem.ToString() != "")
                {

                    bolumName += (BolumlerLb.SelectedItem.ToString()[i]);
                    i++;
                }
                bolumId = bolumName;
                bolumName = "";
                for (int s = i + 4; s < BolumlerLb.SelectedItem.ToString().Length; s++)
                {
                    bolumName += BolumlerLb.SelectedItem.ToString()[s];
                }


                DerslerVeOgrenciler dvo = new DerslerVeOgrenciler();
                dvo.Show();
                this.Hide();
            }
        }
    }
}
