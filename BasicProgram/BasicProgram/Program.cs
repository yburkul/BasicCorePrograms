using System;

namespace BasicProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome In Basic Program");
            int input;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1: For Leap Year");
                Console.WriteLine("2: For Prime Number");
                Console.WriteLine("3: For Find Largest Number");
                Console.WriteLine("4: For Find Perfect Number");
                Console.WriteLine("5: For Palindrome Number");
                Console.WriteLine("6: For Reverse The Number");
                Console.WriteLine("7: For Check Number is Even or Odd");
                Console.WriteLine("8: For Swap Number");
                Console.WriteLine("9: For Prime Factor");
                Console.WriteLine("10: For Check the given Alphabet is Vowel or Consonant");
                Console.WriteLine("11: For Factorial");
                Console.WriteLine("12: For Fibonacci Series");
                Console.WriteLine("13: For Quotient And Remainder");
                Console.WriteLine("14: For Basic Math Opertions");
                Console.WriteLine("15: For Find the Number is Divisible by 2 or not");
                Console.WriteLine("16: For Print all the Multiples of Given Number which are Less than 100");
                Console.WriteLine("17: For Harmonic");
                Console.WriteLine("0: For Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        BasicCoreProgram.LeapYear();
                        break;
                    case 2:
                        BasicCoreProgram.PrimeNumber();
                        break;
                    case 3:
                        BasicCoreProgram.LargestNumber();
                        break;
                    case 4:
                        BasicCoreProgram.PerfectNumber();   
                        break;
                    case 5:
                        BasicCoreProgram.Palindrome();
                        break;
                    case 6:
                        BasicCoreProgram.ReverseNumber();
                        break;
                    case 7:
                        BasicCoreProgram.OddEven();
                        break;
                    case 8:
                        BasicCoreProgram.SwapNumber();
                        break;
                    case 9:
                        BasicCoreProgram.PrimeFactor();
                        break;
                    case 10:
                        BasicCoreProgram.Vowel();
                        break;
                    case 11:
                        BasicCoreProgram.FactorialNumber();
                        break;
                    case 12:
                        BasicCoreProgram.FibonacciSeries();
                        break;
                    case 13:
                        BasicCoreProgram.QuotientAndRemainder();
                        break;
                    case 14:
                        BasicCoreProgram.MathOperation();
                        break;
                    case 15:
                        BasicCoreProgram.DivisibleByTwo();
                        break;
                    case 16:
                        BasicCoreProgram.MultipleByGivenNumber();
                        break;
                    case 17:
                        BasicCoreProgram.Harmonic();
                        break;
                    case 0:
                        Console.WriteLine("Exit\n");
                        break;
                    default:
                        Console.WriteLine("Invalid Input: ----- Please Enter Vaild Input");
                        break ;
                }
            }
            while(input != 0); 
        }
    }
}