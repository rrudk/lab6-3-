using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab04.fMain;


namespace lab04
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string University { get; set; }
        public string Specialty { get; set; }
        public int Year { get; set; }
        public int Rating1 { get; set; }
        public int Rating2 { get; set; }
        public int Rating3 { get; set; }
        public bool Scholarship { get; set; }

        public Student(string name, string surname, int age, string university, string specialty, int year, int rating1, int rating2, int rating3, bool scolarship)
        {
            Name = name;
            Surname = surname;
            Age = age;
            University = university;
            Specialty = specialty;
            Year = year;
            Rating1 = rating1;
            Rating2 = rating2;
            Rating3 = rating3;
            Scholarship = scolarship;
        }

        public double CalculateAverageGrade()
        {
            double sum = Rating1 + Rating2 + Rating3;
            return sum / 3;
        }

    }
}
