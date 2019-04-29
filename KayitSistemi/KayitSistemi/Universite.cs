using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class Universite
    {
        private string name;
        private Dictionary<string, Universite> unis = new Dictionary<string, Universite>();
        public Dictionary<string, Universite> GetUnis { get { return unis; } }
        private Dictionary<string, Fakulte> departments = new Dictionary<string, Fakulte>();
        public Dictionary<string, Fakulte> GetDepartments { get { return departments; } }
        public string GetName
        {
            get { return name; }
        }

        public void AddDepartment(string id,string name)
        {
            departments.Add(id, new Fakulte(id, name));
        }
    }
}
