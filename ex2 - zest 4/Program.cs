using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            person.Name = "John";
            person.Surname = "Kowalski";
            person.Age = 25;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Surname);
            Console.WriteLine(person.Age);

            Console.ReadKey();
        }
        class Human
        {
            private string name, surname;
            private int age;
            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public int Age { get => age; set => age = value; }
        }
    }
}
