using System;

namespace lesweek03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Het afdrukken van tekst in de console
            Console.WriteLine("Simon");

            // Rekenmachine
            int a = 5;
            int b = 6;
            int resultaat1 = optellen(a, b);
            int resultaat2 = deling(a, b);
            int resultaat3 = verhogen(a);

            Console.WriteLine(optellen(a, b));
            Console.WriteLine(deling(a, b));
            Console.WriteLine(verhogen(a));
        }

        static int optellen(int a, int b)
        {
            return a + b;
        }

        static int deling(int a, int b)
        {
            return a/b;
        }

        static int verhogen(int a)
        {
            return a++;
        }
    }
}