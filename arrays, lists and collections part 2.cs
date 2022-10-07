using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Ana", "Richie", "Felipe" };
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
			// finding names through the list
			
            var index = names.IndexOf("Maria");
            Console.WriteLine($"We found Maria at {index}");
        }


            if (index != -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }

            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }		
    }
}