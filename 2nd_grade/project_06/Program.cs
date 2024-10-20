using System;

namespace project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("podaj 2 liczby: ");
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine($"iloraz liczb {x}/{y} = {x / y}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Błąd: liczba powinna być z zakresu od {int.MinValue} do " +
                    $"{int.MaxValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: podaj prawidłowe dane");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Błąd: dzielenie przez 0");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            */
            bool isCorrect = false;
            do
            {
                Console.WriteLine("podaj 2 liczby: ");
                try
                {
                    Console.Write("Podaj x: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Podaj y: ");
                    int y = int.Parse(Console.ReadLine());
                    if (y != 0) 
                    {
                        Console.Write("\nWynik dzielenia liczb ");
                    }
                    ColorMessage($"{x} / {y} = {x / y}", ConsoleColor.Green);
                    isCorrect = true;
                   
                }
                catch (OverflowException)
                {
                    ColorMessage($"Błąd: liczba powinna być z zakresu od {int.MinValue} do {int.MaxValue}", ConsoleColor.Red);
                }
                catch (FormatException)
                {
                    ColorMessage("Błąd: Błędny format danych", ConsoleColor.Red);
                }
                catch (DivideByZeroException)
                {
                    ColorMessage("Błąd: dzielenie przez 0", ConsoleColor.Red);
                }

                catch (Exception ex)
                {
                    ColorMessage($"Błąd: {ex.Message}", ConsoleColor.Red);
                }
                finally
                {
                    Console.WriteLine("\n\nDziękujemy za korzystanie z programu\n\n");
                }
            }while (!isCorrect);

            Console.ReadKey();

        }
        static void ColorMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
            
        }
    }
    
}