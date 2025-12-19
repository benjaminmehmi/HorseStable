using System;
using System.Collections.Generic;
using System.Text;

namespace HorseStable
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            bool gameRunning = true;

            Stable stable = new Stable();
            HorseRace horseRace = new HorseRace();
            Horse horse1 = new Horse("Thunder", 30);
            Horse horse2 = new Horse("Lightning", 35);

            stable.AddHorse(horse1);
            stable.AddHorse(horse2);
            horseRace.EnterHorseRace(horse2);

            while (gameRunning == true)
            {
                bool horseMenuRunning = true;

                Horse selectedHorse = null;

                Console.WriteLine("""
                                  You walk in to the horse stable, which horse do you choose?
                                  1. Thunder
                                  2. Lightning
                                  """);

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    selectedHorse = horse1;
                }
                else if (choice == "2")
                {
                    selectedHorse = horse2;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    continue;
                }

                Console.Clear();

                while (horseMenuRunning == true)
                {
                    Console.WriteLine($"""
                                       You selected {selectedHorse}. What do you want to do?
                                       1. Feed
                                       2. Groom
                                       3. Enter horse race
                                       4. Start horse race
                                       5. Back to horse selection
                                       """);
                    string horseChoice = Console.ReadLine();
                    switch (horseChoice)
                    {
                        case "1":
                            selectedHorse.Feed();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            selectedHorse.Groom();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            horseRace.EnterHorseRace(selectedHorse);
                            Console.WriteLine($"\nYou entered {selectedHorse} into the race!");
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break; 
                        case "4":
                            horseRace.StartHorseRace();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "5":
                            horseMenuRunning = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.\n");
                            break;
                    }
                }
            }
        }
    }
}
