using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factulteit
            int getal = 10;
            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine(fac);
            
            
            // Fibonacci
            int g0 = 0;
            int g1 = 1;
            int next = 0;

            for(int i = 0; i < 15; i++) {
                if(i == 0) {
                    next = 0;
                } else if(i == 1) {
                    next = 1;
                } else {
                    next = g0 + g1;
                    g0 = g1;
                    g1 = next;
                }
                Console.WriteLine(next);
            }
        }
    }
}
