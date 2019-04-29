using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class Fakulte
    {
        private static Dictionary<string, Fakulte> departments = new Dictionary<string, Fakulte>();
        public static Dictionary<string, Fakulte> GetDepartments { get { return departments; } }
        private Dictionary<string, DProgram> programs = new Dictionary<string, DProgram>();
        public Dictionary<string,DProgram> GetPrograms { get { return programs; } }
        private string id;
        public string GetId { get { return id; } }
        private string name;
        public string GetName { get { return name; } }

        public Fakulte(string id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void AddProgram(string id,string name)
        {
            try
            {
                DProgram prog = new DProgram(id, name, this.id);
                programs.Add(prog.GetID, prog);
            }
            catch(ArgumentException a)
            {
                throw new ArgumentException("ayni idli iki adet program eklenemz");
            }
            
        }
        
    }
}
