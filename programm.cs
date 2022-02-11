using System;

namespace Koerpergewicht

{
    class Program
    {
        static void Main(string[] args)
        {
            int groeße, koerpergewicht;

            Console.WriteLine("GEWICHTSBERECHNUNG(BROCA-Methode)\n");
            Console.WriteLine("Geben Sie bitte ihre Körpergröße ein: ");
            groeße = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            koerpergewicht = groeße - 100;
            Console.WriteLine("Ihr Normalgewicht beträgt {0}", koerpergewicht);

            Console.ReadKey();
        }
    }
}
