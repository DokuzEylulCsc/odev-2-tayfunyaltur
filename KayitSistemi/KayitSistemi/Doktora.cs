using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class DoktoraOgrenci:Ogrenci
    {
        public DoktoraOgrenci(string name, string surname, string department, string program) : base(name, surname, department, program)
        {
            DoktoraOgrencileri.Add(this);
        }
        public DoktoraOgrenci(string name, string surname, string department, string program, int GNO) : base(name, surname, department, program, GNO)
        {
            DoktoraOgrencileri.Add(this);
        }
        public static List<DoktoraOgrenci> DoktoraOgrencileri = new List<DoktoraOgrenci>();
    }
}
