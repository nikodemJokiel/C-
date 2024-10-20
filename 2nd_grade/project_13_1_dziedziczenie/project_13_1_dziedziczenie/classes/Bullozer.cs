using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejct_13_1_dziedziczenie.classes
{
    internal class Bullozer : Machine
    {
        public Bullozer(string name) : base(name)
        {

        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna równanie terenu");
        }

        public void Bulldoze()
        {
            Console.WriteLine($"{Name} równa teren");
        }
        public override void Work()
        {
            Bulldoze();
        }
    
    }
}
