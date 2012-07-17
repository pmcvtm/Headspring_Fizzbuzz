using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    //Simple Console Solution
    class Program
    {
        static void Main(string[] args)
        {
            //Pretty straightforward:
            for (int i = 1; i <= 100; i++)  //loop from 1 to 100
            {
                if (i % 15 == 0)            //divisible by 15 (== 5*3)
                    Console.Write("FizzBuzz ");
                else if (i % 3 == 0)        // or divisible by 3
                    Console.Write("Fizz ");
                else if (i % 5 == 0)        // or divisible by 5
                    Console.Write("Buzz ");
                else
                    Console.Write(i + " "); // the rest of them
            }
        }
    }
}
