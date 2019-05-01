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
        private static Dictionary<string,Course> courses = new Dictionary<string, Course>();
        private static Dictionary<string, Ogrenci> students = new Dictionary<string, Ogrenci>();
        public string GetName { get { return name; } }
        public string GetID { get { return id; } }
        public string GetDepartmentId { get { return departmentId; } }
        public string GetLanguage { get{ return language; } }
        public int GetWorkload { get{ return workload; } }
        public OgrentimUyesi MainInstructor { get { return mainInstructor; } set { mainInstructor = value; } }
        public static Dictionary<string, Course> Courses { get { return courses; } }

        public Course(string id, string name , string language , int workload,string departmentId)
        {
            this.departmentId = departmentId;
            this.id = id;
            this.name = name;
            this.language = language;
            this.workload = workload;
        }

        public void AddStudent(Ogrenci stu)
        {
            students.Add(stu.GetId, stu);
        }
    }
}
