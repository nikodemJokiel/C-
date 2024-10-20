using System;

namespace project_9_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> ints = new List<int>();

            ints.Add(1);
            ints.Add(10);
            ints.Add(5);

            Console.WriteLine($"Długość listy: {ints.Count}");
            ints.Add(5);
            ints.Add(1);
            Console.WriteLine($"Długość listy: {ints.Count}");

            foreach (int i in ints)
            {
                Console.WriteLine($"{i} ");
            }

            ints.Remove(1);
            foreach (int i in ints)
            {
                Console.WriteLine($"{i} ");
            }
            */

            
            
            Random random = new Random();

            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1,101));
            }

            List<int> list2 = new List<int>();

            Console.WriteLine("Lista 10 wylosowanych liczb: ");
            foreach (int i in list)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    list2.Add(i);
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista liczb podzielnych przez 3 lub 5: ");
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}