using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class YuksekLisansOgrenci:Ogrenci
    {
        public YuksekLisansOgrenci(string name, string surname, string department, string program) : base(name, surname, department, program)
        {
            YukseklisansOgrencileri.Add(this);
        }
        public YuksekLisansOgrenci(string name, string surname, string department, string program, int GNO) : base(name, surname, department, program, GNO)
        {
            YukseklisansOgrencileri.Add(this);
        }
        public static List<YuksekLisansOgrenci> YukseklisansOgrencileri = new List<YuksekLisansOgrenci>();
    }
}
