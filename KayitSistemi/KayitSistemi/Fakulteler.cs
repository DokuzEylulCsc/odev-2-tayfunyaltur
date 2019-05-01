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
    public partial class Fakulteler : Form
    {
        public static string fakName;
        public static string fakID;
        public Fakulteler()
        {
            InitializeComponent();
        }

        private void Fakulteler_Load(object sender, EventArgs e)
        {
            refresh();
        }


        public void refresh()
        {
            label1.Text = Universiteler.UniName+" Universitesi ";
            FakultelerLb.Items.Clear();
            foreach (Fakulte fak in Universite.GetUnis[Universiteler.UniName].GetDepartments.Values)
            {
                FakultelerLb.Items.Add(fak.GetId + "---->" + fak.GetName);
            }
            if (FakultelerLb.Items.Count == 0)
            {
                panel1.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
            }
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            if (IdText.Text != "" && nameText.Text != "")
            {
                try
                {
                    Universite.GetUnis[Universiteler.UniName].AddDepartment(IdText.Text, nameText.Text);
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(a.Message);
                }
                finally
                {
                    refresh();
                }
            }
           
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Universiteler universiteler = new Universiteler();
            universiteler.Show();
            this.Hide();
        }

        private void secButton_Click(object sender, EventArgs e)
        {
            if (FakultelerLb.SelectedItem != null)
            {
                fakID = "";
                fakName = "";
                int i = 0;
                List<char> karakterler = new List<char>();
                while (FakultelerLb.SelectedItem.ToString()[i] != '-' && FakultelerLb.SelectedItem.ToString() != "")
                {

                    fakName += (FakultelerLb.SelectedItem.ToString()[i]);
                    i++;
                }
                fakID = fakName;
                fakName = "";
                for (int s = i + 5; s < FakultelerLb.SelectedItem.ToString().Length; s++)
                {
                    fakName += FakultelerLb.SelectedItem.ToString()[s];
                }
                Bolumler bol = new Bolumler();
                bol.Show();
                this.Hide();
            }
           

        }
    }
}
