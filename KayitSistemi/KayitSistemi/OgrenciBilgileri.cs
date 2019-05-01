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
    public partial class OgrenciBilgileri : Form
    {
        private object ogr;
        public OgrenciBilgileri(object ogr)
        {
            this.ogr = ogr;
            InitializeComponent();
        }

        private void OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            if(ogr is Ogrenci)
            {
                AdLbl.Text = ((Ogrenci)ogr).GetName;
                SoyadLbl.Text = ((Ogrenci)ogr).GetSurname;
                NumaraLbl.Text = ((Ogrenci)ogr).GetId;
                if (ogr is LisansOgrenci)
                {
                    label1.Text = "Lisans Ogrencisi";
                }
                else if (ogr is YuksekLisansOgrenci)
                {
                    label1.Text = "Yuksek Lisans Ogrencisi";
                }
                else
                {
                    label1.Text = "Doktora Ogrencisi";
                }
            }
            else if(ogr is OgrentimUyesi)
            {
                label1.Text = "Ogretim Uyesi";
                AdLbl.Text = ((OgrentimUyesi)ogr).GetName;
                SoyadLbl.Text = ((OgrentimUyesi)ogr).GetSurname;
                NumaraLbl.Text = ((OgrentimUyesi)ogr).GetID;

            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
