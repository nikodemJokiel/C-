namespace project_10_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Anna");
            d.Add(2, "Tomasz");
            d.Add(3, "Janina");

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Value}");
            }
            Console.WriteLine();


            //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG

            Dictionary<string, int> d1 = new Dictionary<string, int>();

            d1.Add("Anna", 1);
            d1.Add("Tomasz", 2);
            d1.Add("Janina", 3);

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Value}");
            }
            Console.WriteLine();

            //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG

            Dictionary<string, string> capitals = new Dictionary<string, string>();

            capitals.Add("Polska", "Warszawa");
            capitals.Add("Niemcy", "Berlin");
            capitals.Add("Francja", "Paryż");

            foreach (KeyValuePair<string, string>item in capitals)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG

            Dictionary<string, string> phones = new Dictionary<string, string>()
            {
                {"+48 123 456 789", "Anna" },
                {"+48 987 654 321", "Tomasz" },
                {"+48 123 456 787", "Karolina" }
            };

            

            foreach (KeyValuePair<string, string> item in phones)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG

            Dictionary<string, string> animals = new Dictionary<string, string>()
            {
                {"Pies", "hauhau" },
                {"kot", "miaumiau" },
                {"krowa", "muuu" },
                {"koń", "ihaa" }
            };



            foreach (KeyValuePair<string, string> animal in animals)
            {
                Console.WriteLine("Zwierzę: {0}, dźwięk: {1}", animal.Key, animal.Value);
            }
            Console.WriteLine();

            //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG

            Dictionary<string, string> colors = new Dictionary<string, string>()
            {
                {"biały", "#FFFFFF" },
                {"czarny", "#000000" },
                {"czerwony", "#FF0000" },
                {"zielony", "#00FF00" },
                {"niebieski", "#0000FF" }
            };



            foreach (KeyValuePair<string, string> color in colors)
            {
                Console.WriteLine("Kolor: {0}, Hex: {1}", color.Key, color.Value);
            }
            Console.WriteLine();
            */

            Dictionary<string, string> slownik = new Dictionary<string, string>();
            int l;

            bool isCorrect = false;
            do
            {
                try
                {
                    Console.Write("Ile par klucz-wartość chcesz wprowadzić: ");
                    l = int.Parse(Console.ReadLine());

                    string k, v;
                    for (int i = 0; i < l; i++)
                    {
                        Console.Write("Podaj klucz: ");
                        k = Console.ReadLine();
                        Console.Write("Podaj warość: ");
                        v = Console.ReadLine();

                        slownik.Add(k, v);
                    }
                    isCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                
            } while (!isCorrect);
           
            

            foreach (KeyValuePair<string, string> x in slownik)
            {
                Console.WriteLine("Klucz: {0}, Wartość: {1}", x.Key, x.Value);
            }
            Console.WriteLine();
        }
    }
}
