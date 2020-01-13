using System;

namespace Opgave1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Skriv 'q' for at afslutte programmet");
                Console.Write("Skriv talrækkens startstal: ");
                string startNumberInput = Console.ReadLine().ToLower();
                int.TryParse(startNumberInput, out int startNumber);
                if(startNumberInput == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Skriv talrækkens slutstal: ");
                    string endNumberInput = Console.ReadLine().ToLower();
                    int.TryParse(endNumberInput, out int endNumber);
                    if(endNumberInput == "q")
                    {
                        Environment.Exit(0);
                    }
                    else if(startNumber > endNumber)
                    {
                        Console.WriteLine("Fejl! Startstallet må ikke være større end slutstallet");
                    }
                    else
                    {
                        for(int i = startNumber; i <= endNumber; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            } while(true);
        }
    }
}
