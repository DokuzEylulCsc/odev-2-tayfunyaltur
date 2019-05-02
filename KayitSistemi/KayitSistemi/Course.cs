using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

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

        public void AddSube(Subeler sb) //derse sube ekler
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
        } //dersten sube cikartir
        public void SaveCourse()
        {
            FileStream fs = new FileStream(@"../Ders.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(this.GetName);
            foreach(Subeler s in subeler.Values)
            {
                sw.WriteLine("-Sube->" + s.GetId);
                foreach(OgrentimUyesi hoca in s.GetInstructors.Values)
                {
                    sw.WriteLine("--Ogretim Uyeleri-->" + hoca.GetName + " " + hoca.GetSurname);
                }
                foreach (Ogrenci asi in s.GetAssistants.Values)
                {
                    sw.WriteLine("--Asistanlar-->" + asi.GetName + " " + asi.GetSurname);
                }
                foreach (Ogrenci ogr in s.GetStudents.Values)
                {
                    sw.WriteLine("--Ogrenciler-->" + ogr.GetName + " " + ogr.GetSurname);
                }
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            
        } //dosyaya yazma islemlerini yapar 
    }
}
