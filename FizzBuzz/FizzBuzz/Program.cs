using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzLibrary;

namespace FizzBuzz
{
    //Added Functionality (From Library)
    class Program
    {
        static void Main(string[] args)
        {

            FizzBuzzer fb = new FizzBuzzer(); //make a fizzbuzzer from the library

            bool quitting = false;
            string[] input;
            while (!quitting)
            {
                Console.Write("Select one of the following, then press enter: 1-Simple to Console 2-Simple to File 3-Custom to Console 4-Custom to File 5-Exit:   ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        fb.SimpleFizzBuzzToConsole();
                        break;
                    case "2":
                        Console.WriteLine("Enter filename, then press enter:");
                        fb.SimpleFizzBuzzToFile(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Enter the following, separated by spaces: \n min number, max number, 'fizz' word, 'buzz' word\nThen press enter.");
                        input = Console.ReadLine().Split(' ');
                        try
                        {
                            fb.CustomFizzBuzzToConsole(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]), input[2], input[3]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid Input. Make sure you have provided the correct number of parameters and they are correctly formatted");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter the following, separated by spaces: \n filename, min number, max number, 'fizz' word, 'buzz' word\nThen press enter.");
                        input = Console.ReadLine().Split(' ');
                        try
                        {
                            fb.CustomFizzBuzzToFile(input[0], Convert.ToInt32(input[1]), Convert.ToInt32(input[2]), input[3], input[4]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid Input. Make sure you have provided the correct number of parameters and they are correctly formatted");
                        }
                        break;
                    case "5":
                        quitting = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;   
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
