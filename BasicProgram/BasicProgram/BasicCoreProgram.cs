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
        public static void PerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("It is a Perfect Number");
            }
            else
            {
                Console.WriteLine("It is not a Perfect Number");
            }
        }
        public static void Palindrome()
        {
            int reverse = 0;
            int remainder;
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            while(number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine("It is a Palindrome Number");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome Number");
            }
        }
        public static void ReverseNumber()
        {
            int reverse = 0;
            int remainder;
            int num;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Reverse the Number is: " + num);
            while(num != 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            Console.WriteLine("After Reverse the Number is: " + reverse);
        }
        public static void OddEven()
        {
            int num;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("It is Even Number");
            }
            else
            {
                Console.WriteLine("It is Odd Number");
            }
        }
        public static void SwapNumber()
        {
            int a,b;
            Console.WriteLine("Enter a First number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second Number: ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After swap First Number: " + a);
            Console.WriteLine("After swap Second Number: " + b);
        }
        public static void PrimeFactor()
        {
            int a;
            int b;
            Console.WriteLine("Enter a Number");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
        }
        public static void Vowel()
        {
            Console.WriteLine("Enter a Letter: ");
            char Letter = char.Parse(Console.ReadLine().ToLower());
            if(Letter == 'a' || Letter == 'e' || Letter == 'i' || Letter == 'o' || Letter == 'u')
            {
                Console.WriteLine("Enter Letter is Vowel: " + Letter);
            }
            else
            {
                Console.WriteLine("Enter Letter is Consonant: " + Letter);
            }
        }
        public static void FactorialNumber()
        {
            int factorial = 1;
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of number: " + factorial);
        }
        public static void FibonacciSeries()
        {
            int FirstNum = 0;
            int SecondNum = 1;
            int ThirdNum;
            Console.WriteLine("Enter a number");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("The Fibonacci Series are: ");
            for (int i = 0; i < Number; i++)
            {
                ThirdNum = FirstNum + SecondNum;
                Console.WriteLine(ThirdNum + " ");
                FirstNum = SecondNum;
                SecondNum = ThirdNum;
            }
        }
        public static void QuotientAndRemainder()
        {
            int divident, divisor, quotient, remainder;
            Console.WriteLine("Enter a Divident");
            divident = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Divisor");
            divisor = int.Parse(Console.ReadLine());
            quotient = divident / divisor;
            remainder = divident % divisor;
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
        public static void MathOperation()
        {
            Console.WriteLine("Welcome in Basic Math Operations");
            Console.WriteLine("Enter a First Number");
            double FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            int input;
            do
            {
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Divison");
                Console.WriteLine("5: Avarage");
                Console.WriteLine("0: Back to Main Method");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        double Sum = FirstNumber + SecondNumber;
                        Console.WriteLine("Sum Of Two Numbers are {0}+{1} = {2} ",FirstNumber, SecondNumber, Sum);
                        break;
                    case 2:
                        double Subtraction = FirstNumber - SecondNumber;
                        Console.WriteLine("Subtraction of Two Number are {0}-{1} = {2}", FirstNumber, SecondNumber, Subtraction);
                        break;
                    case 3:
                        double Multiplication = SecondNumber * FirstNumber;
                        Console.WriteLine("Multiplication of Two Number is {0}*{1} = {2}", FirstNumber, SecondNumber, Multiplication);
                        break;
                    case 4:
                        double Division = FirstNumber / SecondNumber;
                        Console.WriteLine("Division of two number are {0}/{1} = {2}", FirstNumber, SecondNumber, Division);
                        break;
                    case 5:
                        double Avarage = (FirstNumber + SecondNumber) / 2;
                        Console.WriteLine("Avarge of Two Number is {0}*{1} / {2} ", FirstNumber, SecondNumber, Avarage);
                        break;
                    case 0:
                        Console.WriteLine("Back to Main Method");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (input != 0);
        }
        public static void DivisibleByTwo()
        {
            int number;
            Console.WriteLine("Enter the Number:");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered Number is Divisible by 2");
            }
            else
            {
                Console.WriteLine("Entered Number is Not Divisible by 2");
            }
        }
    }
}