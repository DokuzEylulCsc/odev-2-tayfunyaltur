using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    class OgrentimUyesi
    {
        private string name, surname,id;
        private int workload=0;
        private static Dictionary<string,OgrentimUyesi> OgrentimUyeleri = new Dictionary<string, OgrentimUyesi>();
        public string GetName { get { return name; } }
        public string GetSurname { get { return surname; } }
        public int Workload { get { return workload; }  set { workload = value; } }
        public string GetID { get { return id; } }
        public static Dictionary<string,OgrentimUyesi> GetInstructors
        {
            get
            {
                return OgrentimUyeleri;
            }
        }
        public OgrentimUyesi(string name , string surname,string id)
        {
            this.name = name;
            this.surname = surname;
            try
            {
                OgrentimUyeleri.Add(id, this);
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("Ani idye sahip iki okutman ogretim uyesi olamaz, Lutfen yeni bir id giriniz.");
            }
            
        }
     
    }
}
