using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace project_parking_05_02.clasess
{
    public enum Color
    {
        black,
        white,
        silver,
        niger,
        red,
        blue,
        raist_green,

    }

    internal class Car
    {
        public string Brand {get; private set;}
        public string Model { get; private set;}
        public ushort Year { get; private set;}
        public Color Color { get; private set;}
        
        public void ShowInformation()
        {
            Console.WriteLine($"To jest {Brand} ({Year}), kolor: {Color}");
        }

        public void SetBrand(string brand)
        {
            Brand = brand;
        }
         public void SetModel(string model)
        {
           Model=model;
        }
         public void SetYear(ushort year)
        {
            Year = year;
        }
         public void Color(Color color)
        {
            Color = color;
        }
    }
}
