using project_parking_05_02.clasess;
namespace project_parking_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.SetBrand("Ford");
            c1.SetModel("Ka");
            c1.SetYear(2000);
            c1.SetColor(Color.Blue);
            
            Parking p1 = new Parking{Name = "center", Cars = new Car[5]};
        }
    }
}
