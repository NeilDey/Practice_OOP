using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args) {
            //Part 1
            Console.WriteLine("\n \n ");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Neil Dey");

            //Part 2 
            Console.WriteLine("\n \n ");
            Console.WriteLine(13 + 11);

            //Part 3
            Console.WriteLine("\n \n ");
            Console.WriteLine(10 / 2);

            //Part 4
            Console.WriteLine("\n \n ");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            //Part 5
            Console.WriteLine("\n \n ");
            int x = 5;
            int y = 10;
            Console.WriteLine("Original Value of X: " + x);
            Console.WriteLine("Original Value of Y: " + y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("New Value of X: " + x);
            Console.WriteLine("New Value of Y: " + y);

            Console.ReadKey();
        }
    }
}
