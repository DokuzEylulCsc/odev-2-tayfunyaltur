using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    abstract class Ogrenci
    {
        protected static int OgrenciSayisi = 0;
        public static int ogrenciSayisi{get{return OgrenciSayisi;} set{OgrenciSayisi=value;} }
        public static Dictionary<string, Ogrenci> Ogrenciler = new Dictionary<string, Ogrenci>();
        protected string id;
        protected string name, surname, department, program;
        public string GetName { get { return name; } }
        public string GetSurname { get{ return surname; } }
        public string Department { get{ return department; } set { department = value; } }
        public string Program { get{ return program; } set { program = value; } }
        public string GetId { get { return id; }  }

        public Ogrenci(string name,string surname,string department ,string program,string id) // yeni kayit edilen ogrenciler icin
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.department = department;
            this.program = program;
            try
            {
                Ogrenciler.Add(this.id, this);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("ayni idli iki ogrenci kaydedilemez");
                throw new ArgumentException();
            }
            OgrenciSayisi++;
        }
        
    }
}
