using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 100;
            int b = 7;
            int c = a + b;
            int d = 3;
            int e = d * c;
            int f = 5;
            int g = 406;
            int h = 7367;
            int i = 69;
            int j = g + h;
            int k = j / i;
            int l = k * f;
            int m = 73;
            int n = 41;
            int o = 39;
            int p = m * n;
            int q = p - o;
            int r = 7;
            int s = 8;
            int t = 19;
            int u = r * s;
            int v = u - t;
            int w = e + l + q + v;
            Console.WriteLine("Het resultaat is: " + w);

            int resultaat1 = Som(100, 7);
            int resultaat2 = Product(3, resultaat1);
            int resultaat3 = Som(406, 7367);
            int resultaat4 = Quotient(resultaat3, 69);
            int resultaat5 = Product(resultaat4, 5);
            int resultaat6 = Product(73, 41);
            int resultaat7 = Verschil(resultaat6, 39);
            int resultaat8 = Product(7, 8);
            int resultaat9 = Verschil(resultaat8, 19);
            int totaal = resultaat2 + resultaat5 + resultaat7 + resultaat9;
            Console.WriteLine("Het resultaat is: " + totaal);

            int resultaatb1 = Som(100, 7);
            int resultaatb2 = Product(3, Som(100, 7));
            int resultaatb3 = Som(406, 7367);
            int resultaatb4 = Quotient(Som(406, 7367), 69);
            int resultaatb5 = Product(Quotient(Som(406, 7367), 69), 5);
            int resultaatb6 = Product(73, 41);
            int resultaatb7 = Verschil(Product(73, 41), 39);
            int resultaatb8 = Product(7, 8);
            int resultaatb9 = Verschil(Product(7, 8), 19);

            int totaal2 = 
            Product(3, Som(100, 7)) + 
            Product(Quotient(Som(406, 7367), 69), 5) 
            + Verschil(Product(73, 41), 39) + 
            Verschil(Product(7, 8), 19);
            Console.WriteLine("Het resultaat is: " + totaal2);

            int totaal3 = Som(Som(Som(Product(3, Som(100, 7)), Product(Quotient(Som(406, 7367), 69), 5)), Verschil(Product(73, 41), 39)), Verschil(Product(7, 8), 19));
            Console.WriteLine("Het resultaat is: " + totaal3);

            totaal3 = 10000;
            if(totaal3 == 3872)
            {
                Console.WriteLine("Het resultaat is perfect!");
            }
            else if(totaal3 > 3872)
            {
                Console.WriteLine("Het resultaat is te groot!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }


            for (int teller = 0; teller < 11; teller++)
            {
                Console.WriteLine("De teller is nu: " + teller);
            }

            Program program = new Program();
            program.Tafel(1);
            program.Tafel(2);
            program.Tafel(3);
            //Tafel(1);
            //Tafel(2);
            //Tafel(3);

            int getal3 = 4;
            do
            {
                Console.WriteLine("De waarde van het getal is: " + getal3);
                getal3++;
            } while (getal3 < 5);

            int getal4 = 4;
            while(getal4 < 5)
            {
                Console.WriteLine("De waarde van het getal is: " + getal4);
                getal4++;
            }
        }

        void Tafel(int getal)
        {
            Console.WriteLine("De tafel van: " + getal);
            for (int teller = 0; teller < 11; teller++)
            {
                int resultaat = teller * getal;
                Console.WriteLine(teller + " * " + getal + " = " + resultaat);
            }
        }

        static int Som(int getal1, int getal2){
            return getal1 + getal2;
        }
        static int Verschil(int getal1, int  getal2)
        {
            return getal1 - getal2;
        }
        static int Quotient(int getal1, int getal2)
        {
            return getal1 / getal2;
        }
        static int Product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
    }
}