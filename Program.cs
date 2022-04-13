using System;
using System.Collections.Generic;
namespace ConsoleGuessBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = false;
            Dictionary<string, int> guests = new Dictionary<string, int> ();
            do
            {
                string names = Program.GetGuestName();
                string numberOfGuests = Program.GuestsPerParty();

                if(!int.TryParse(numberOfGuests, out int partyGuests))
                {
                    System.Console.WriteLine("\nInput error, numeric number expected, retrying...");
                    Console.Write("\nDo you wish to continue: y to continue.. ANY to exit.");
                    Console.WriteLine("");

                    string answer = Console.ReadLine();

                    if(answer.ToLower() == "y")
                    {
                        keepGoing = true;
                    }
                    else
                    {
                        keepGoing = false;
                    }
                }
                else
                {
                    guests.Add(names, partyGuests);
                    Console.Write("\nAre there anymore guests: y to continue.. ANY for no to exit..");
                    Console.WriteLine("");

                    string answer = Console.ReadLine();

                    if(answer.ToLower() == "y")
                    {
                        keepGoing = true;
                    }
                    else
                    {
                        keepGoing = false;
                    }

                }

            } while (keepGoing);
            
            int total = 0;
            foreach(KeyValuePair<string, int> guest in guests) //search for keyValuePair, displace key and value
            {
                System.Console.WriteLine($"\nWe have guest family {guest.Key}, and they have {guest.Value} members at the party..");
                total += guest.Value;
            }
            System.Console.WriteLine($"\nThere are {total} guests at the party.");
            Console.ReadKey();
        }

        public static string GetGuestName()
        {
            System.Console.Write("Please record your name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string GuestsPerParty()
        {      
            System.Console.Write("\nHow many guests are in your party: ");
            string guests = Console.ReadLine();
            return guests;
        }


            
    }
}
