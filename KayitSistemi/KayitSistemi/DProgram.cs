using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayitSistemi
{
    class DProgram
    {
        private string name;
        private string id;
        private string departmentId;
        private Dictionary<string,Ogrenci> students=new Dictionary<string, Ogrenci>();
        private Dictionary<string,OgrentimUyesi> instructors=new Dictionary<string, OgrentimUyesi>();
        private static Dictionary<string, DProgram> programs = new Dictionary<string, DProgram>();
        private Dictionary<string, Course> courses = new Dictionary<string, Course>();
        public Dictionary<string,Course>  GetCourses { get { return courses; } }
        public string GetDepartment { get{ return departmentId; } }
        public string GetName
        {
            get { return name; }
        }
        public string GetID
        {
            get { return id; }
        }
        public Dictionary<string,Ogrenci> GetSutdents
        {
            get { return students; }
        }
        public Dictionary<string,OgrentimUyesi> GetInstructors
        {
            get
            {
                return instructors;
            }
        }
        public DProgram(string id,string name,string departmentId)
        {
            this.id = id;
            this.name = name;
            this.departmentId = departmentId;
            try
            {
                programs.Add(id, this);
            }
            catch
            {

            }
        }
        public void AddCourse(Course c)
        {
            try
            {
                courses.Add(c.GetID, c);  //Bolume ders ekler ve DPorgram nesnesinin icersiindeki sozluge eklenicek dersin idsi ve dersi ekler.
            }
            catch(ArgumentException e) // eger ayni keye sahip iki nesne eklenmek isterse
            {
                MessageBox.Show("Ayni kurstan iki tane ekleyemezsiniz");
            }
            
        }
        public void RemoveCourse(Course c)
        {
            courses.Remove(c.GetID); // silinmek istenen dersin idsine erisip siler
        }
        public void AddCourse(string key)
        {
            try
            {
                courses.Add(Course.Courses[key].GetID, Course.Courses[key]);// eger dersin idsi ile ekleme yapilmak istenirse
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("Ayni dersi iki kere ekleyemezsiniz");
            }
            
        }
        public void RemoveCourse(string key)
        {
            courses.Remove(key);
        }
        public void AddCourse(string key,string name,string lang,int workload)
        {
            Course c = new Course(key, name, lang, workload,this.id);
            try
            {
                courses.Add(c.GetID, c);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("bu ders kodu daha once eklenmis");

            }
        } 
        public void AddCourse(string key, string name, string lang, int workload,string oName )
        {

            Course c = new Course(key, name, lang, workload,this.id);
            try
            {
                courses.Add(c.GetID, c);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("bu ders kodu daha once eklenmis");

            }
        }
        public void AddIns(string name ,string surname,string id)
        {
            try
            {
                instructors.Add(id, new OgrentimUyesi(name, surname, id));
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("Bu ogretim uyesi zaten ekli ya da ayni idye sahip baska bir ogretim uyesi var");
            }
            
        }
        public void AddIns(OgrentimUyesi ins)
        {
            instructors.Add(ins.GetID, ins);
        }
        public void AddLisans(string id,string name,string surname)
        {
            students.Add(id, new LisansOgrenci(name, surname, departmentId,this.name,id));
        }
        public void AddYuksek(string id,string name,string surname)
        {
            students.Add(id, new YuksekLisansOgrenci(name, surname, departmentId, this.name,id));
        }
        public void AddDoktora(string id, string name, string surname)
        {
            students.Add(id, new DoktoraOgrenci(name, surname, departmentId, this.name, id));
        }
    }
}
