using System.Net.NetworkInformation;

namespace project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double a;
            Console.Write("podaj a: ");
            a = double.Parse(Console.ReadLine());
            */
            /*
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(a);
            }
            */
            Console.WriteLine("Wybierz co chcesz zrobić.\n1 - obliczanie pola trójkąta \n2 - obliczanie pola prostokąta \n3 - wyjście");
            Console.Write("Wybór: ");
            int choice = int.Parse( Console.ReadLine() );
            
            switch (choice)
            {
                case 1:
                    
                    bool IsCorrect = false;

                    do
                    {
                        Console.Write("podaj a: ");
                        double a;

                        while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                        {
                            Console.Write("podaj prawidłowo bok a: ");
                        }

                        Console.Write("podaj b: ");
                        double b;

                        while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                        {
                            Console.Write("podaj prawidłowo bok b: ");
                        }

                        Console.Write("podaj c: ");
                        double c;

                        while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                        {
                            Console.Write("podaj prawidłowo bok c: ");
                        }

                        if (IsTriangle(a, b, c))
                        {
                            IsCorrect = true;
                            double area = CalculateTriangleArea(a, b, c);
                            Console.OutputEncoding = System.Text.Encoding.Unicode;
                            Console.WriteLine("Pole trójkąta o bokach {0}, {1}, {2} wynosi: {3:F5}[j\u00b2]", a, b, c, area);
                            Console.OutputEncoding = System.Text.Encoding.Default;
                        }
                        else
                        {
                            Console.WriteLine("Z podanych boków nie można stworzyć trójkąta");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }
                    while (!IsCorrect);
                    break;
                
                case 2 :
                    double a;
                    double b;
                    Console.WriteLine("podaj a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("podaj b: ");
                    b = double.Parse(Console.ReadLine());
                    double area = a * b;
                    Console.WriteLine($"Pole prostokąta: {area}");
                    break; 
                
                
                case 3 :
                    break;
            }
            
            


            Console.ReadLine();
        }

        
        static bool IsTriangle ( double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }

        static double CalculateTriangleArea( double a, double b, double c)
        {
            double p = (a + b + c)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
    }
}