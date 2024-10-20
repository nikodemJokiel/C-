using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_parking_05_02.clasess;

namespace project_parking_05_02.clasess
{

    internal class Parking
    {
        public string Name { get; set; }
        public Car[] Cars { get; set; }
        public void AddCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null)
                {
                    Cars[i] = new Car();
                    Console.WriteLine($"zaparkowano samochód na miejscu {i + 1}");
                    return;
                }
            }
            Console.WriteLine("Brak wolnych misejsc parkingowych");
        }
        public void RemoveCar(Car car, int i)
        {
            if (Cars[i] == null || i > Cars.Length || i <= 0)
            {
                Console.WriteLine($"na miejscu nr {place} nie ma samochodu");
            }
            else
            {

                Cars[i] = null;
            }
        }

        public void ShowCars(Car car)
        {
            Console.WriteLine($"Parking {Name} ma {Cars.Length} miejsc parkingowych");
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] != null)
                {
                    
                    Console.Write($"Miejsce {i}: ");
                    Cars[i].ShowInformation();
                }
                else
                {
                    Console.WriteLine($"Miejsce {i} jest puste");
                }

            }
        }



    }
}

