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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> deneme = new Dictionary<string, string>();
            try
            {
                //deneme.Add("ali", "veli");
                deneme.Add("ali", "velai");
                deneme.Remove("mehmet");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            
        }
    }
}
