using System;
using System.Collections.Generic;
using System.Text;

namespace HorseStable
{
    public class Horse
    {
        public string Name { get; private set; }
        public int Speed { get; private set; }
        public int DistanceRan { get; private set; }

        public Horse(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        public void Groom()
        {
            Console.WriteLine($"{Name} is being groomed.");
        }

        public void Run(int hours)
        {
            DistanceRan += Speed * hours;
            Console.WriteLine($"{Name} ran {Speed * hours} miles in {hours} hours.");
        }
    }
}


