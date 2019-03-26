using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load our module
            // Note that we are using a seed value -- as long as we specify the same seed, 
            // the same names will be produced every time we run the code.
            // Change this for your program -- any integer is valid
            Names names = new Names(50);

            // Generate 100 random names
            for (int i = 1; i <= 100; i++)
            {
                String name = names.Generate();
                Console.WriteLine($"{i}: {name}");
            }
            Console.ReadKey();
        }
    }
}
