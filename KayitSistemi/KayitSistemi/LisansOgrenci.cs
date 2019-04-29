using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class LisansOgrenci:Ogrenci
    {
        public LisansOgrenci(string name,string surname , string department , string program) : base(name, surname, department, program)
        {
            lisansOgrencileri.Add(this);
        }
        public LisansOgrenci(string name, string surname, string department, string program,int GNO) : base(name, surname, department, program,GNO)
        {
            lisansOgrencileri.Add(this);
        }
        public static List<LisansOgrenci> lisansOgrencileri = new List<LisansOgrenci>();
    }
}
