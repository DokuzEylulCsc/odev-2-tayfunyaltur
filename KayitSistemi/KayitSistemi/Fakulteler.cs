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
            label1.Text = Universiteler.UniName+" Universitesi";
            FakultelerLb.Items.Clear();
            foreach (Fakulte fak in Universite.GetUnis[Universiteler.UniName].GetDepartments.Values)
            {
                FakultelerLb.Items.Add(fak.GetId + " ----> " + fak.GetName);
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
    }
}
