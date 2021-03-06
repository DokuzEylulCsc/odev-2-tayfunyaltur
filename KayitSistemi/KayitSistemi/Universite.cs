﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class Universite
    {
        private string name;// universitenin ismi
        private static Dictionary<string, Universite> unis = new Dictionary<string, Universite>(); // butun universiteleri tutucak Static sozluk
        public static Dictionary<string, Universite> GetUnis { get { return unis; } } // kapsulleme
        private Dictionary<string, Fakulte> departments = new Dictionary<string, Fakulte>();
        public Dictionary<string, Fakulte> GetDepartments { get { return departments; } }
        public string GetName
        {
            get { return name; }
        }
        public Universite(string name)
        {
            try
            {
                this.name = name;
                unis.Add(name, this);
            }catch(ArgumentException a)
            {
                throw new ArgumentException("ayni isimde iki farkli universie bulunamaz");
            }
        }
        public void AddDepartment(string id,string name) // departman ekleme eger ekliyese messagebox da gosterilecek mesaji hata mesaji olarak doner
        {
            try
            {
                departments.Add(id, new Fakulte(id, name));
            }catch(ArgumentException a)
            {
                throw new ArgumentException("Ayni idye sahip iki adet fakulte olusturulamaz"); 
            }
            
        }
    }
}
