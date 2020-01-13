using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Skriv 'q' for at afslutte programmet");
                Console.Write("Indtast et tal mellem 1 og 20 og se dets tabel:");
                string numberInput = Console.ReadLine();
                int.TryParse(numberInput, out int number);
                if(numberInput == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Hvor lang skal tabellen være? (minimum 10, max 20)");
                    string tableLengthInput = Console.ReadLine();
                    int.TryParse(tableLengthInput, out int tableLength);
                    if(number > 0 && number < 21 && tableLength >= 10 && tableLength <= 20)
                    {
                        for(int table = number; table <= number * tableLength; table += number)
                        {
                            Console.WriteLine(table);
                        }
                    }
                    else if(tableLengthInput == "q")
                    {
                        Environment.Exit(0);
                    }
                    else if(tableLength < 10 || tableLength > 20)
                    {
                        Console.WriteLine("Fejl! Tabellen skal minimum være 10 tal lang og max 20 tal lang");
                    }
                    else
                    {
                        Console.WriteLine("Fejl! Tallet er ikke mellem 1 og 20!");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
            } while(true);
        }
    }
}
