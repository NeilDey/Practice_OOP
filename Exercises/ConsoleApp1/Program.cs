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
            Console.WriteLine("\n \n ");

            int num;

            Console.Write("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);

            //Part 14
            Console.WriteLine("\n \n ");

            Console.Write("Enter temperature in C ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = " + (celsius + 273));
            Console.WriteLine("Fahrenheit = " + (celsius * 18 / 10 + 32));

            //Part 15
            Console.WriteLine("\n \n ");

            Console.WriteLine(remove_char("Test", 1));
            Console.WriteLine(remove_char("Test", 2));
            Console.WriteLine(remove_char("Test", 0));

            //Part 16
            Console.WriteLine("\n \n ");

            Console.WriteLine(Swap_first_with_last("yeet"));
            Console.WriteLine(Swap_first_with_last("Paperjack"));

            //Part 17
            Console.WriteLine("\n \n ");

            Console.WriteLine("Please Enter a String");
            string str = Console.ReadLine();
            char charAtStart = str[0];
            Console.WriteLine(charAtStart + str + charAtStart);

            //Part 18
            Console.WriteLine("\n \n ");

            Console.WriteLine("Enter 2 numbers");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > 0 ^ numero2 > 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");

            }

            //Part 19
            Console.WriteLine("\n \n ");

            P19Sum(2, 3);
            P19Sum(2, 2);

            //Part 20
            Console.WriteLine("\n \n ");

            AbsoluteDifference(20, 30);
            AbsoluteDifference(30, 20);

            //Part 21
            Console.WriteLine("\n \n ");

            CheckForTwenty(10, 10);
            CheckForTwenty(2, 5);
            CheckForTwenty(20, 10);

            //Part 23
            Console.WriteLine("\n \n ");

            string line = "The quick brown fox jumped over the lazy dog";
            Console.WriteLine(line.ToLower());

            //Part 24
            string largestString = "";
            string input = "The quick brown fox jumped over the lazy dog";
            string[] wordArray = input.Split(' ');

            for (int i = 0; i < wordArray.Length; i++)
            {

                if (wordArray[i].Length > largestString.Length)
                {
                    largestString = wordArray[i];
                }

            }
            Console.WriteLine("Largest word is: " + largestString);
        }

        //Part 21 Method
        private static void CheckForTwenty(int a, int b)
        {
            Console.WriteLine(a == 20 || b == 20 || (a+b) == 20);
        }

        //Part 20 Method
        private static void AbsoluteDifference(int a, int b)
        {
            Console.WriteLine(Math.Abs(a - b));
        }

        //Part 19 Method
        public static int P19Sum(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }

        //Part 16 Method
        private static String Swap_first_with_last(string v)
        {
            string answer;
            answer = (v.Substring(1, v.Length - 1));
            answer += v[0];
            return answer;
        }

        //Part 15 Method
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}


