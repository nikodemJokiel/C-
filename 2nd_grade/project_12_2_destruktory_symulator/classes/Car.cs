using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_destruktory_symulator.classes
{
    /*Zadanie: Symulator jazdy samochodem
        1. Opis zadania:
        o Napisz program w języku C#, który umożliwi użytkownikowi symulowanie jazdy samochodem.
        o Program powinien obsługiwać następujące funkcje:
         Dodawanie nowego samochodu (marka i model).
         Wyświetlanie listy dostępnych samochodów.
         Symulowanie losowego uszkodzenia samochodu (np. przebita opona, awaria silnika, zepsute
        światło).
         Jazda wybranym samochodem (jeśli nieuszkodzony).
         Zezłomowanie samochodu (usunięcie obiektu).
        o Samochody powinny być przechowywane w kolekcji (np. liście).
        o Wykorzystaj klasy i właściwości do reprezentacji samochodów.
        o Destruktor (finalizer) powinien być wywoływany przy zezłomowaniu samochodu.
        o Komunikaty o uszkodzeniach oraz akcjach użytkownika powinny być wyświetlane w języku polskim.
        2. Przykładowe działanie programu w konsoli:*/
    internal class Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }   
        public bool IsDamaged {  get; set; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            IsDamaged = false;
        }

        ~Car() 
        {
            Console.WriteLine($"Samochód {Brand} {Model} jest zezłomowany");
        }

        public void Drive()
        {
            if ( IsDamaged )
            {
                Console.WriteLine($"Samochód {Brand} {Model} ma awarię");
            }
            else
            {
                Console.WriteLine($"Samochód {Brand} {Model} porusza się");
            }
        }

        public void SimulateRandomDamage()
        {
            Random random = new Random();
            int damageType = random.Next( 1, 4 ); //liczby od 1 do 3
            switch (damageType )
            {
                case 1:
                    Console.WriteLine($"Samochód {Brand} {Model} ma przebitą oponę");
                    break;

                case 2:
                    Console.WriteLine($"Silnik samochodu {Brand} {Model} jest uszkodzony");
                    break;

                case 3:
                    Console.WriteLine($"Samochód {Brand} {Model} ma uszkodzone światło");
                    break;
            }
        }
    }
}
