using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    public abstract class Ogrenci
    {
  
        protected string id;// ogrenci no
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
        }
        
    }
}
