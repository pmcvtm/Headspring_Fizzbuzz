using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FizzBuzzLibrary
{
    public class FizzBuzzer
    {
        public void SimpleFizzBuzzToConsole()
        {
            Console.Write(FizzBuzzHelper(1, 100, "Fizz", "Buzz"));
        }

        public void CustomFizzBuzzToConsole(int min, int max, string wordFor3, string wordFor5)
        {
            Console.Write(FizzBuzzHelper(min,max, wordFor3, wordFor5));
        }

        public void SimpleFizzBuzzToFile()
        {
            
        }

        public void CustomFizzBuzzToFile()
        {

        }

        //Helper function returns string that's the result of a "fizzbuzz" of the given parameters
        private string FizzBuzzHelper(int min, int max, string word3, string word5)
        {
            string result = "";
            for (int i = min; i <= max; i++)  //loop from min to max
            {
                if (i % 15 == 0)            //divisible by 15 (== 5*3)
                    result += word3 + word5;
                else if (i % 3 == 0)        // or divisible by 3
                    result += word3;
                else if (i % 5 == 0)        // or divisible by 5
                    result += word5;
                else
                    result += i;       // the rest of them

                result += " ";
            }

            return result;
        }
    }
}