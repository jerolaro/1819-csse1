using System;
using System.Collections;

namespace wachtlijst
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Opdracht 3: Wachtlijst");

            Queue wachtrij = new Queue();
            wachtrij.Enqueue("Item 1");
            wachtrij.Enqueue("Item 2");
            wachtrij.Enqueue("Item 3");
            wachtrij.Enqueue("Item 4");

            object[] items;

            int length = wachtrij.Count;

            for(int i = 0; i < length; i++) {
                Console.WriteLine(wachtrij.Dequeue());
                items = wachtrij.ToArray();
                program.PrintItems(items);
            }         
            

        }

        void PrintItems(object[] array) {
            Console.WriteLine("\nDit staat momenteel in de wachtlijst:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
