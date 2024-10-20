using _12_2_destruktory_symulator.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_destruktory_symulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

            while (true)
            {
                DisplayMenu();


                int choice = GetUserInput();

                switch (choice)
                {
                    case 1:
                        AddCar(cars, carDictionary);
                       
                        break;

                    case 2:
                        DisplayCars(carDictionary);
                        
                        break;

                    case 3:
                        DisplayCars(carDictionary);
                        if (carDictionary.Count != 0)
                        {
                            DriveCar(carDictionary);
                        }
                       
                       
                        break;

                    case 4:
                        DisplayCars(carDictionary);
                        if (carDictionary.Count != 0)
                        {
                            SimulateDamage(carDictionary);
                        }
                        else
                        {
                            Console.WriteLine("\nNie ma żadnego samochodu w bazie.\n");
                        }
                        /*
                        Console.Write("Podaj numer samochodu do symulacji uszkodzenia: ");
                        int damagedCarNumber = int.Parse(Console.ReadLine());
                        if (carDictionary.TryGetValue(damagedCarNumber, out Car damagedCar))
                        {
                            damagedCar.SimulateRandomDamage();
                        }
                        else
                        {
                            Console.WriteLine("\nNieprawidłowy numer samochodu\n");
                        }*/
                        break;

                    case 5:
                        DisplayCars(carDictionary);
                        if (carDictionary.Count != 0)
                        {
                            ScrapCar(carDictionary);
                        }
                        else
                        {
                            Console.WriteLine("\nNie ma żadnego samochodu w bazie.\n");
                        }

                        /*
                        Console.Write("Podaj numer samochodu do zezłomowania");
                        int scrappedCarNumber = int.Parse(Console.ReadLine());
                        if (carDictionary.TryGetValue(scrappedCarNumber, out Car scrappedCar))
                        {
                            scrappedCar = null;
                            GC.Collect();
                            Console.WriteLine($"samochód {scrappedCarNumber} został zezłomowany"); //błędnie
                        }
                        else
                        {
                            Console.WriteLine("\nNieprawidłowy numer samochodu\n");
                        }*/
                        break;

                    case 6:
                        Console.WriteLine("Zamykanie symulatora");
                        return;
                }
                Console.WriteLine("\nNaciśnij dowolny klawisz");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu symulatora jazdy samochodem");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Wyświetl listę samochodów");
            Console.WriteLine("3. Jedź samochodem");
            Console.WriteLine("4. symuluj losowe uszkodzenia");
            Console.WriteLine("5. zezłomuj samochód");
            Console.WriteLine("6. Wyjście");

        }
        private static int GetUserInput(Dictionary<int, Car> carDictionary = null)
        {

            //ine wykorzystaliśmy przeciążenia tylko korzystaliśmy z parametru opcjonalnego
            //int carNumber = GetUserInput(Dictionary<int, Car> carDictionary = null);
            int input;
            while (true)
            {
                Console.WriteLine("\nPodaj wartość (int): ");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (carDictionary = null || carDictionary.ContainsKey(input))
                    {
                        return input;

                    }
                    else
                    {
                        Console.WriteLine("\nnumer samochodu nieistnieje w słowniku");
                    }


                }
                else
                {
                    Console.WriteLine("\nNieprawidłowy format. Spróbuj ponownie\n");
                }

            }
        }

        private static void AddCar(List<Car> cars, Dictionary<int, Car> carDictionary)
        {
            Console.Clear();
            Console.WriteLine("podaj markę");
            string brand = Console.ReadLine();
            Console.WriteLine("podaj model");
            string model = Console.ReadLine();
            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDictionary[cars.Count] = newCar;
            Console.WriteLine("samochód dodany pomyślnie");
        }
        private static void DisplayCars(Dictionary<int, Car> carDictionary)
        {
            if (carDictionary.Count == 0)
            {
                Console.WriteLine("\nBrak samochodów do wyświetlenia\n");
            }
            else
            {
                Console.WriteLine("\nLista samochodów: ");
                Console.WriteLine("Lista samochodów");
                foreach (var carEntry in carDictionary)
                {
                    int key = carEntry.Key;
                    Car car = carEntry.Value;
                    
                    Console.WriteLine($"Klucz: {key}, marka: {car.Brand}, model: {car.Model}");
                }
            }
        }
        private static void DriveCar(Dictionary<int, Car> carDictionary)
        {
            int carNumber = GetUserInput(carDictionary);
            Car carToDrive = carDictionary[carNumber];
            carToDrive.Drive();
            //return 0;
            /*
            Console.Write("Podaj numer samochodu do jazdy");
            int carNumber = int.Parse(Console.ReadLine());
            if (carDictionary.TryGetValue(carNumber, out Car selectedCar))
            {
                selectedCar.Drive();

            }
            else
            {
                Console.WriteLine("\nNieprawidłowy numer samochód\n");
            }*/
        }
        private static void SimulateDamage(Dictionary<int,Car> carDictionary)
        {
            int carNumber = GetUserInput(carDictionary);
            Car carToSimulateDamage = carDictionary[carNumber];
            carToSimulateDamage.SimulateRandomDamage();
            
        }

        private static void ScrapCar(List<Car> cars, Dictionary<int, Car> carDictionary)
        {
            int carNumber = GetUserInput(carDictionary);
            Console.WriteLine($"\nSamochód {carDictionary[carNumber].Brand} {carDictionary[carNumber].Model} został usunięty\n");
            cars.RemoveAt(carNumber);
            carDictionary.Remove(carNumber);
        }
    }
}
