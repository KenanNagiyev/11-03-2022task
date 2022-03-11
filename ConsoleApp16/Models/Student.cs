using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16.Models
{
    class Student:Person
    {
        public Student()
        {
            
        }
        public int course;
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public Student(string name, string surname):this(name) 
        {
            this.surname = surname;
            Console.WriteLine( surname);
        }
        public Student(string name, string surname, int age):this(name,surname)
        {
            this.age = age;
            Console.WriteLine( age);
        }
    }
}
