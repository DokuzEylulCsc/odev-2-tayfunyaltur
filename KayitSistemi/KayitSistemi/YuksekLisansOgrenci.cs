using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class YuksekLisansOgrenci:Ogrenci
    {
        public YuksekLisansOgrenci(string name, string surname, string department, string program,string id) : base(name, surname, department, program,id)
        {

        }//Abstract class ogrencinin constructor methodunu kullanir
    }
}
