using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KayitSistemi
{

    class Subeler
    {    
        private string SubeID;
        private Dictionary<string, OgrentimUyesi> Hocalar = new Dictionary<string, OgrentimUyesi>();
        private Dictionary<string, Ogrenci> Asistanlar = new Dictionary<string, Ogrenci>();
        private Dictionary<string, Ogrenci> Ogrenciler = new Dictionary<string, Ogrenci>();
        public string GetId { get { return SubeID; } }
        public Dictionary<string,OgrentimUyesi> GetInstructors { get { return Hocalar; } }
        public Dictionary<string,Ogrenci> GetAssistants { get { return Asistanlar; } }
        public Dictionary<string,Ogrenci> GetStudents { get { return Ogrenciler; } }
        public Subeler(String SubeID,OgrentimUyesi Hoca)
        {
            this.SubeID = SubeID;
            Hocalar.Add(Hoca.GetID,Hoca);
        }
        public void addAssistant(Ogrenci assistant) // assistan ekler
        {
            try
            {
                Asistanlar.Add(assistant.GetId,assistant);
            }
            catch(ArgumentException a)
            {
                throw new ArgumentException("Bu kisi zaten bu dersin Asistani");
            }
        }
        public void addStudent(Ogrenci ogr) //ogrenci ekler
        {
            try
            {
                Ogrenciler.Add(ogr.GetId, ogr);
            }
            catch (ArgumentException a)
            {
                throw new ArgumentException("Bu kisi zaten bu dersin Ogrencisi");
            }
        }
        public void addInstructor(OgrentimUyesi ogr) //hoca ekler 
        {
            try
            {
                Hocalar.Add(ogr.GetID, ogr);
            }
            catch (ArgumentException a)
            {
                throw new ArgumentException("Bu kisi zaten bu dersin Hocasi");
            }
        }
        public void removeAssistan(Ogrenci ogr) // asistan siler 
        {
            Asistanlar.Remove(ogr.GetId);
        }
        public void removeInstructor(OgrentimUyesi hoca) // hoca siler
        {
            if (Hocalar.Count > 1)
            {
                Hocalar.Remove(hoca.GetID);
            }
            else
            {
                throw new Exception("Bir subenin butun hocalari silinemez");
            }
        }
        public void removeStudent(Ogrenci ogr) // ogrenci siler
        {
            Ogrenciler.Remove(ogr.GetId);
        }
    }
}
