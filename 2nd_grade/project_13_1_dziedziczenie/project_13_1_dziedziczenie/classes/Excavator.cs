using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejct_13_1_dziedziczenie.classes
{
    internal class Excavator : Machine
    {
        public Excavator(string name) : base(name)
        {
        }

        //przesłonięcie metodyt wirtyalnej
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna kopanie");
        }

        //przeciążenie metody wirtyualnej
        public void Stop(string reason)
        {
            Console.WriteLine($"{Name} zostaała zatrzymana z powodu { reason} ");
        }

        //symulacja kopania
        public void Dig()
        {
            Console.WriteLine($"{Name} kopie");
        }

        //przesłonięcie metody Work
        public override void Work()
        {
            Dig();
        }
    }
}
