using System;
using System.Collections.Generic;
using System.Text;

namespace HorseStable
{
    public class Stable
    {
        private List<Horse> Horses { get; set; }
        public Stable()
        {
            Horses = new List<Horse>();
        }

        public void AddHorse(Horse horse)
        {
            Horses.Add(horse);
        }
    }
}
