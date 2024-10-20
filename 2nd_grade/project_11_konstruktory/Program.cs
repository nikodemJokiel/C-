using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_11_konstruktory.classes;

namespace project_11_konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Person p0 = new Person();
            Person p1 = new Person(name: "Janusz");
            Person p2 = new Person(name: "Anna", surname: "Nowak");
            Person p3 = new Person(name: "Tomasz", surname: "Nowak", age:20);
            Person p4 = new Person(name: "Tomasz", surname: "Nowak", age:20, height:175.5f);
            
            /*
            persons.Add(p0);
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            persons.Add(p4);
            */
            persons.AddRange(collection: new[]
            {
                p0,p1, p2, p3, p4
            });


            Console.WriteLine("\n\nLiczba obiektów klasy Person (gówno): {0}",Person.Counter);
            Console.WriteLine("\n\nLiczba obiektów klasy Person: {0}",persons.Count());

            Console.ReadKey();
        }
    }
}
