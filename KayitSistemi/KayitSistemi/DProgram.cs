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
        private List<Ogrenci> students;
        private List<OgrentimUyesi> instructors;
        private OgrentimUyesi headOfDepartment;
        private static Dictionary<string, DProgram> programs = new Dictionary<string, DProgram>();
        private Dictionary<string, Course> courses = new Dictionary<string, Course>();
        public Dictionary<string,Course>  GetCourses { get { return courses; } }
        public string GetName
        {
            get { return name; }
        }
        public string GetID
        {
            get { return id; }
        }
        public List<Ogrenci> GetSutdents
        {
            get { return students; }
        }
        public List<OgrentimUyesi> GetInstructors
        {
            get
            {
                return instructors;
            }
        }
        public OgrentimUyesi HeadOfDepartment
        {
            get { return headOfDepartment; }
            set { headOfDepartment = value; }
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
        public void AddCourse(string key,string name,string lang,int workload,OgrentimUyesi ins)
        {
            Course c = new Course(key, name, lang, workload, ins);
            try
            {
                courses.Add(c.GetID, c);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ayni dersi iki kere ekleyemezsiniz");

            }
        } // ogretmen mevcut ise 
        public void AddCourse(string key, string name, string lang, int workload,string oName , string oSurnme)
        {
            OgrentimUyesi ins = new OgrentimUyesi(oName, oSurnme);
            Course c = new Course(key, name, lang, workload, ins);
            try
            {
                courses.Add(c.GetID, c);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ayni dersi iki kere ekleyemezsiniz");

            }
        }  // ogretmen de yeni eklenicek ise
    }
}
