
namespace project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program prosi użytkownika o podanie indeksu tablicy 
                i wyświetla liczbę znajdującą się pod tym indeksem. Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek 
                ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException 
                i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątków
                Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
                Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 

             */
            bool stop = false;
            do
            {
                
                int[] array = new int[5];
                bool isCorrect = false;
                do
                {
                    Console.WriteLine("Wprowadź 5 liczb całkowitych: ");
                    try
                    {
                        for (int i = 0; i < array.Length; i++)
                        
                        {
                            Console.Write("Podaj liczbę: ");
                            array[i] = int.Parse(Console.ReadLine());
                            if (array[i] < 0)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                        }
                        isCorrect = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą.");

                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"Nieprawidłowe dane. Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}>");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"{ ex.Message} Podaj liczbę większą od 0");
                    }
                    finally
                    {
                        Console.WriteLine("Naciśnij q żeby wyjść lub dowolny klawisz by kotynuować");
                        if (Console.ReadKey(true).Key == ConsoleKey.Q)
                        {
                            System.Environment.Exit(0);

                        }
                    }
                    
                }
                while (!isCorrect);

                bool isCorrect2 = false;
                do
                {
                    try
                    {
                        Console.Write("Podaj index: ");
                        int index = int.Parse(Console.ReadLine());
                        if (index > 4 || index < 0)
                        {
                            throw new ArgumentOutOfRangeException();
                        }

                        Console.WriteLine($"{array[index]}");
                        isCorrect = true;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"{ ex.Message} zły index, musi być 0 <= index <= 4");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("podaj odpowiednie dane");
                    }
                    finally
                    {
                        Console.WriteLine("Naciśnij q żeby wyjść lub dowolny klawisz by kotynuować");
                        if (Console.ReadKey(true).Key == ConsoleKey.Q)
                        {
                            System.Environment.Exit(0);

                        }
                    }

                } while (!isCorrect2);
                
            } while (!stop) ;
            
            



            /*
            foreach(int i in array)
            {
                Console.WriteLine($"{i}");
            }
            */
            //Console.ReadKey();
        }
       
    }
}
