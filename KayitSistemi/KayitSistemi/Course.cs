using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{
    class Course
    {
        private string id;
        private string name;
        private string language;
        private int workload;
        private string departmentId;
        private OgrentimUyesi mainInstructor;
        private Dictionary<string, Subeler> subeler = new Dictionary<string, Subeler>();
        public string GetName { get { return name; } }
        public string GetID { get { return id; } }
        public string GetDepartmentId { get { return departmentId; } }
        public string GetLanguage { get{ return language; } }
        public int GetWorkload { get{ return workload; } }
        public Dictionary<string,Subeler> getSubeler { get { return subeler; } }
        public OgrentimUyesi MainInstructor { get { return mainInstructor; } set { mainInstructor = value; } }

        public Course(string id, string name , string language , int workload,string departmentId)
        {
            this.departmentId = departmentId;
            this.id = id;
            this.name = name;
            this.language = language;
            this.workload = workload;
        }

        public void AddSube(Subeler sb)
        {
            try
            {
                subeler.Add(sb.GetId, sb);
            }
            catch(ArgumentException a)
            {
                throw new ArgumentException("Bu IDye sahip baska bir sube mevcut.");
            }
        }
        public void removeSube(Subeler sb)
        {
            subeler.Remove(sb.GetId);
        }
    }
}
