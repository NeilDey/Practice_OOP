using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 12
            Console.WriteLine("\n \n ");

            int userNum;

            Console.WriteLine("Enter a digit: ");
            userNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(userNum);
            Console.Write(" ");
            Console.Write(userNum);
            Console.Write(" ");
            Console.Write(userNum);
            Console.Write(" ");
            Console.Write(userNum);
            Console.WriteLine();

            Console.Write(userNum);
            Console.Write(userNum);
            Console.Write(userNum);
            Console.WriteLine(userNum);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", userNum);
            Console.WriteLine("{0}{0}{0}{0}", userNum);

            //Part 13
            int num;

            Console.Write("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);
        }
    }
}

