using System;
using ConsoleApp16.Models;
namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("Kenan", "Nagiyev", 20);
            Console.WriteLine("------------------------");
            Teacher t = new Teacher("Akif" , "Hesenov",26);
        }
    }
}
