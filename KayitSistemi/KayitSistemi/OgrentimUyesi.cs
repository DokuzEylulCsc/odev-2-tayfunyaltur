using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    class OgrentimUyesi
    {
        private string name, surname;
        private int workload=0;
        private static Dictionary<string,OgrentimUyesi> OgrentimUyeleri = new Dictionary<string, OgrentimUyesi>();
        public string GetName { get { return name; } }
        public string GetSurname { get { return surname; } }
        public int Workload { get { return workload; }  set { workload = value; } }
        public OgrentimUyesi(string name , string surname)
        {
            this.name = name;
            this.surname = surname;
            try
            {
                OgrentimUyeleri.Add(name + surname, this);
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("Ani isimde iki okutman ogretim uyesi olamaz, Lutfen isimin sonuna bir noktalama isareti ekleyin (orn. : -*.,)");
            }
            
        }
     
    }
}
