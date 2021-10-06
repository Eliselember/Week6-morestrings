using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime
            //programm küsib sisestada perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja
            //perekonnanimes kokku on

            int counter = 0;

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            foreach (char character in fullName)
            {
                if (character == 'a')
                {
                    counter++; //counter = counter + 1
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");
        }
    }
}
