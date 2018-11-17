using System;
using System.Collections.Generic;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 3: Menu\n\n");

            Dictionary<string, double> menu = new Dictionary<string, double>();

            // Add items.
            menu.Add("plat water", 1.00);
            menu.Add("cola 25cl", 1.50);
            menu.Add("cola 33cl", 2.00);
            menu.Add("witte wijn", 3.00);
            menu.Add("pils", 2.00);
            menu.Add("toast", 5.00);
            menu.Add("kaasplank", 4.00);

            // Read out.

            foreach(var item in menu) 
            {
                Console.WriteLine(item.Key + " - " + item.Value + "EUR");
            }

            // Sorted by name.

            List<string> itemList = new List<string>();
            foreach(var key in menu) 
            {
                itemList.Add(key.Key);
            }
            
            itemList.Sort();

            Console.WriteLine("\nGesorteerd op naam:");
            foreach(var item in itemList) 
            {
                Console.WriteLine(item + " - " + menu[item] + "EUR");
            }

            // Find a certain item.
            Console.WriteLine("\nGeef een naam van een item op:");
            string value = Console.ReadLine().ToLower();
            try
            {
                Console.WriteLine(value + " kost " + menu[value] + "EUR.");
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("Dit item staat niet op dit menu.");
            }

        }
    }
}
