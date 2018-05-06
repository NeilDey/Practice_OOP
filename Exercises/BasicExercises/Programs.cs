using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Programs
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

            //Part 6
            Console.WriteLine("\n \n ");
            int num1, num2, num3;
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine(result);

            //Part 7
            Console.WriteLine("\n \n ");
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} x {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 % number2);
          

            //Part 8 
            Console.WriteLine("\n \n ");

            Console.WriteLine("Enter a number to get it's multiplication table");
            int p8num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(p8num1 * i);
            }
            Console.ReadKey();

            Console.WriteLine("/n /n");
            Console.WriteLine("Moving to part 2");
            part2();
        }

        static void part2() {
            //Part 9
            Console.WriteLine("\n \n ");

            double number1, number2, number3, number4;

            Console.Write("Enter number one: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number two:  ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number three:  ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number four:  ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
         number1, number2, number3, number4, result);


            //Part 10
            Console.WriteLine("\n \n ");

            int num1, num2, num3;

            Console.Write("Enter first number - ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
                num1, num2, num3, ((num1 + num2) * num3), (num1 * num2 + num2 * num3));
        }
    }
    }

