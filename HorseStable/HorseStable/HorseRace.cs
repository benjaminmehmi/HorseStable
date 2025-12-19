using System;
using System.Collections.Generic;
using System.Text;

namespace HorseStable
{
    internal class HorseRace
    {
        private List<Horse> ParticipatingHorses { get; set; }
        private bool RaceOver;

        public HorseRace()
        {
            ParticipatingHorses = new List<Horse>();
            RaceOver = false;
        }
        public void StartHorseRace()
        {
            string horseNames = string.Join(", ", ParticipatingHorses);
            Console.WriteLine($"\nStarted race! Participating horses are: {horseNames}\n");

            Horse winner = null;
            int hour = 1;

            while (winner == null)
            {
                foreach (var horse in ParticipatingHorses)
                {
                    if (horse.DistanceRan < 3000)
                    {
                        horse.Run(hour);
                    }
                    if (horse.DistanceRan >= 3000 && winner == null)
                    {
                        winner = horse;
                    }
                }
                hour++;
            }

            Console.WriteLine($"\n{winner} has won the race!");
            RaceOver = true;
        }

        public void EnterHorseRace(Horse horse)
        {
            ParticipatingHorses.Add(horse);
        }
    }
}
