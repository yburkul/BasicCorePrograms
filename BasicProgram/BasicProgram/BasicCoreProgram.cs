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
    }
}
