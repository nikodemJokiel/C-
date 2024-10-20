using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_11_konstruktory.classes
{
    internal class Person
    {
        //statyczne pole, które przechowuje liczbę obiektów klasy Person
        public static int Counter = 0;

        //właściwości
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }

        //konstruktor stayczny jest wywoływany automatycznie aby zainicjować klasę przed utworzeniem pierwszej instancji.
        //(jest wywoływany tylko raz przed pierwszym użyciem typu)
        //(nie może mieć parametrów ani modyfikatorów dostępu)
        //Służy do inicjowania pól statycznych lub wykonywania innych operacji statycznych(wykonywania dowolnego kodu związanego z klasą,
        //a nie z jej obiektami np. ustawienie wartości domyślnych dla pól statycznych)

        static Person()
        {
            Console.WriteLine("Konstruktor styczny klasy Person\n\n");
            //counter++;
        }

        
        //konstruktor domyślny jest bezparametrowy. Jeśli klasa nie ma konstruktora parametrycznego, to konstruktor domyślny jest wyoływany przy tworzrniu obiektu
        //inicjujemy wszystkie pola do ich wartości domyślnych. Jeśli zdefiniujemy konstruktor parametryczny to nie otrzymamy automatycznie konstruktora domyślnego. 
        //Musimy go samodzielnie zadeklarować
        public Person()
        {
            Console.WriteLine("Konstruktor domyślny klasy Person");
            Name = "nieznane";
            Surname = "nieznane";
            Counter++;

        }

        //kostruktor parametryczny ma conajmniej 1 parametr. Służy do inicjowania pól objektu zgodnie z wartościami podanymi przy tworzeniu obiektu.
        //Możemy mieć wiele konstruktorów parametrycznych o ile różnią się liczbą lub typem parametrów

        //konstruktor parameteryczny z 1 parametrem
        public Person(string name)
        {
            Console.WriteLine("Konstruktor parametryczny klasy Person z 1 parametrem");
            Name = name;
            Counter++;
        }

        //konstruktor parametryczny z 2 parametrami
        public Person(string name, string surname)
        {
            Console.WriteLine("Konstruktor parametryczny klasy Person z 2 parametrem");
            Name = name;
            Surname = surname;
            Counter++;
        }

        //konstruktor parametryczny z 3 parametrami
        public Person(string name, string surname, int age) : this(name, surname)
        {
            Console.WriteLine("Konstruktor parametryczny klasy Person z 3 parametrem");
            Age = age;

            Counter++;
        }

        //konstruktor parametryczny z 4 parametrami
        public Person(string name, string surname, int age, float height) : this(name, surname, age)
        {
            Console.WriteLine("Konstruktor parametryczny klasy Person z 4 parametrem");
            Height = height;

            Counter++;
        }

    }
}
