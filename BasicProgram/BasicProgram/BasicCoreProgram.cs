using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class BasicCoreProgram
    {
        public static void LeapYear()
        {
            int Year;
            Console.WriteLine("Enter a Year: ");
            Year = int.Parse(Console.ReadLine());
            if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("It is not a Leap Year");
            }
        }
        public static void PrimeNumber()
        {
            int count = 0;
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is not a Prime Number");
            }
        }
        public static void LargestNumber()
        {
            int numOne, numTwo, numThree;
            Console.WriteLine("Enter a First Number");
            numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Third Number");
            numThree = int.Parse(Console.ReadLine());
            if (numOne > numTwo && numOne > numThree)
            {
                Console.WriteLine("First Number Is Greater Than Other Two Numbers");
            }
            else if (numTwo > numThree && numTwo > numOne)
            {
                Console.WriteLine("Second Number Is Greater Than Other Two Numbers");
            }
            else if (numThree > numTwo && numThree > numOne)
            {
                Console.WriteLine("Third Number Is Greater Than Other Two Numbers");
            }
            else
            {
                Console.WriteLine("All Three Number are Equal");
            }
        }
    }
}