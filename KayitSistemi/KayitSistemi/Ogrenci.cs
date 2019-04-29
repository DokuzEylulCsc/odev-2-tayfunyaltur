using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    abstract class Ogrenci
    {
        protected static int OgrenciSayisi = 0;
        public static int ogrenciSayisi{get{return OgrenciSayisi;} set{OgrenciSayisi=value;} }
        protected string name, surname, department, program;
        public string GetName { get { return name; } }
        public string GetSurname { get{ return surname; } }
        public string Department { get{ return department; } set { department = value; } }
        public string Program { get{ return program; } set { program = value; } }
        public double Gno { get { return GNO; } set { GNO = value; } }
        protected double GNO;

        public Ogrenci(string name,string surname,string department ,string program) // yeni kayit edilen ogrenciler icin
        {
            this.name = name;
            this.surname = surname;
            this.department = department;
            this.program = program;
            OgrenciSayisi++;
        }
        public Ogrenci(string name, string surname, string department, string program,double GNO) // gecis yapan ogrenciler icin
        {
            this.name = name;
            this.surname = surname;
            this.department = department;
            this.program = program;
            this.GNO = GNO;
            OgrenciSayisi++;
        }
    }
}
