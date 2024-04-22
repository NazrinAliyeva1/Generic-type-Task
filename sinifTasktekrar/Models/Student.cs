using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sinifTasktekrar.Models
{
    public class Student
    {
        static int Count { get; set; } = 0;
        public int Id { get; set; } = 1;
        public string Name { get; set; }    
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Credits {  get; set; }
        public Group Group { get; set; }
        public Student(string name, string surname, int age, int credits, Group group)
        {
            Id = ++Count;
            Name = name;
            Surname = surname;
            Age = age;
            Credits = credits;
            Group = group;

        }

    }
}
