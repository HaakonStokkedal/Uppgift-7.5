using System.Collections.Generic;
using System.ComponentModel;

namespace Uppgift_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I detta program så ska du få skriva in dina senaste månadslöner så kommer det räkna ut din median- och medellön");
            Console.WriteLine("Skriv in dina löner här med enter efter varje och skriv 0 när du är klar.");
            List<int> löner = new List<int>();
            int lön = 1;
            while(lön != 0)
            {
                lön = int.Parse(Console.ReadLine());
                if (lön != 0)
                {
                    löner.Add(lön);
                }
            }
            Console.WriteLine($"Medellönen är {Medellön(löner)}");
            Console.WriteLine($"Medianlönen är {Medianlön(löner)}");

            Console.ReadKey();
        }

        static double Medellön(List <int> löner)
        {
            int summa = 0;
            double medellön = 0;
            foreach (int lön in löner)
            {
                summa += lön;
            }
            medellön = summa/löner.Count;

            return medellön;
        }

        static int Medianlön(List<int> löner)
        {
            int medianIndex = 0;
            löner.Sort();
            medianIndex = löner.Count/2;

            return löner[medianIndex];
        }
    }
}