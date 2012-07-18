using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FizzBuzzLibrary
{
    public class FizzBuzzer
    {
        private string basePath;

        public FizzBuzzer()
        {
            DirectoryInfo di = Directory.GetParent(Directory.GetCurrentDirectory());
            basePath = (Directory.GetParent(Directory.GetParent(di.ToString()).ToString()).ToString()) + @"\Output\";
            Directory.CreateDirectory(basePath);
        }

        public void SimpleFizzBuzzToConsole()
        {
            Console.Write(FizzBuzzHelper(1, 100, "Fizz", "Buzz"));
        }

        public void CustomFizzBuzzToConsole(int min, int max, string wordFor3, string wordFor5)
        {
            Console.Write(FizzBuzzHelper(min,max, wordFor3, wordFor5));
        }

        public void SimpleFizzBuzzToFile(string filename)
        {
            try
            {
                File.WriteAllText(basePath + filename + ".txt", FizzBuzzHelper(1, 100, "Fizz", "Buzz"));
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CustomFizzBuzzToFile(string filename, int min, int max, string wordFor3, string wordFor5)
        {
            try
            {
                File.WriteAllText(basePath + filename + ".txt", FizzBuzzHelper(min, max, wordFor3, wordFor5));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
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