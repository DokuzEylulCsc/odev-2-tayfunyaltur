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
        
        public string GetName { get { return name; } }
        public string GetSurname { get { return surname; } }
        public int Workload { get { return workload; }  set { workload = value; } }
        public string GetID { get { return id; } }

        public OgrentimUyesi(string name , string surname,string id)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
           
            
        }
     
    }
}
