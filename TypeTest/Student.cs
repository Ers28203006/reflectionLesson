using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student()
        {

        }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Фамилия: {0}", Surname);
            Console.WriteLine("Возраст: {0}", Age);
        }
    }
}
