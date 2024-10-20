﻿using System.Threading.Channels;

namespace project_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //przykłady typów predefiniowanych
            string message = "iMiĘ i NazWISkO";
            Console.WriteLine(message);

            string messageUpper = message.ToUpper();
            Console.WriteLine(messageUpper); //IMIĘ I NAZWISKO

            string newMessage = message[0].ToString().ToUpper() + message.Substring(1).ToLower();
            Console.WriteLine(newMessage); //Imię i nazwisko


            string number = "1234567890";
            Console.WriteLine(number);
            Console.WriteLine(number.Substring(3, 3)); //456
            Console.WriteLine(number.Substring(0, 5)); //12345

            //zakres zmiennej
            Console.WriteLine(int.MinValue); //-2147483648
            Console.WriteLine(int.MaxValue); //2147483647
            Console.WriteLine(char.MaxValue); //?

            string firstName = "Kamil";
            Console.WriteLine(firstName.Length); //5
            Console.WriteLine("Bąk".Length); //3

            Console.WriteLine(firstName[0]); //K

            string lastName = "Nowak";
            Console.WriteLine(firstName.Equals(lastName)); //False
            Console.WriteLine("Janusz".Equals("janusz")); //False
            Console.WriteLine("janusz".Equals("janusz")); //True

            Console.Clear();

            Console.Write("Podaj imię: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Imię: {name}");

            /*
            while (true)
            {
                Console.Write("Podaj nazwisko: ");
                string? lastName2 = Console.ReadLine();
                if(lastName2 != string.Empty)
                {
                    Console.WriteLine($"Nazwisko: {lastName2}");
                    break;
                }
            }
           */

            Console.Write("Podaj nazwisko: ");
            string? lastName2 = Console.ReadLine();

            while ( lastName2.Length == 0 ) 
            {
                Console.Write("Podaj nazwisko: ");
                lastName2 = Console.ReadLine();
            }

            Console.WriteLine($"Nazwisko: {lastName2}");

            //######################################################

            float a;
            do
            {
              Console.Write("Podaj długość boku: ");
              a = float.Parse(Console.ReadLine());
            } while (a <= 0);
            Console.WriteLine($"Bok kwadratu wynosi: {a}, pole: {a*a}cm^2");
            
            //####################################################

            //wzór herona (może być na kartkówce)



            Console.ReadKey();

        }
    }
}