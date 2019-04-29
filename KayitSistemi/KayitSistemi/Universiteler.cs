using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    public partial class Universiteler : Form
    {
        public static string UniName;
        public Universiteler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            if (uniNameTxt.Text != "")
            {
                try
                {
                    Universite uni = new Universite(uniNameTxt.Text);
                    Refresh();
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            
            
        }
        public void Refresh()
        {
            UniversitelerLB.Items.Clear();
            foreach (string a in Universite.GetUnis.Keys)
            {
                UniversitelerLB.Items.Add(a);
            }
            if (UniversitelerLB.Items.Count == 0)
            {
                panel2.Enabled = false;
            }
            else
            {
                panel2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UniName = UniversitelerLB.SelectedItem.ToString();
            if (UniName != "")
            {
                Fakulteler fak = new Fakulteler();
                fak.Show();
                this.Hide();
            }
            

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
