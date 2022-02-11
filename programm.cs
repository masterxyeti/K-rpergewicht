using System;

namespace Koerpergewicht

{
    class Program
    {
        static void Main(string[] args)
        {
            int groeße, koerpergewicht;

            Console.WriteLine("GEWICHTSBERECHNUNG(BROCA-Methode)\n");
            Console.Write("Geben Sie bitte ihre Körpergröße(in cm) ein: ");
            groeße = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            koerpergewicht = groeße - 100;
            Console.WriteLine("Ihr Normalgewicht beträgt {0}Kg bei einer Körpergröße von {1} cm", koerpergewicht,groeße);

            Console.ReadKey();
        }
    }
}
