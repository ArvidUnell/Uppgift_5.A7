using System;
namespace Uppgift_5_A7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] länder = { "1. Indien", "2. Kina", "3. USA", "4. Indonesien", "5. Pakistan" };

            foreach (string land in länder)
            {
                Console.WriteLine(land);
            }

            Console.WriteLine("\nVilka länder vill du ska visas igen? Skriv deras nummer separerade med mellanslag.");

            string[] namnArr;

            while (true)
            {
                try
                {
                    string[] nrStr = Console.ReadLine().Split(' ');
                    namnArr = new string[nrStr.Length];

                    for (int i = 0; i < nrStr.Length; i++)
                    {
                        namnArr[i] = länder[byte.Parse(nrStr[i])];
                    }

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Det är inte ett giltigt svar. Försök igen.");
                }
            }

            foreach (string land in namnArr)
            {
                Console.WriteLine(land);
            }

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}