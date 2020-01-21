using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppStudents.Models
{

    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Email { get; set; }


    }
    public class StudentsData
    {
        private static readonly List<Students> Students = new List<Students>();
        static StudentsData()
        {
            Students.Add(new Students { Id = 1, Name = "Andrei", Faculty = "Sports", Email = "Andrei@whatever.com" });
            Students.Add(new Students { Id = 2, Name = "Mihai", Faculty = "Biology", Email = "mihai@whatever.com" });
            Students.Add(new Students { Id = 3, Name = "Vasile", Faculty = "Economy", Email = "vasile@whatever.com" });
            Students.Add(new Students { Id = 4, Name = "Alexandra", Faculty = "English", Email = "alexandra@whatever.com" });
            Students.Add(new Students { Id = 5, Name = "Ovidiu", Faculty = "Law school", Email = "ovidiu@whatever.com" });

        }
        public StudentsData()
        {
        }
        public List<Students> GetStudents()
        {
            return Students;
        }
        public Students GetStudents(int id)
        {
            return Students.Find(x => x.Id == id);
        }
    }
}