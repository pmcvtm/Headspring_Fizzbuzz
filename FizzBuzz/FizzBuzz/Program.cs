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

            bool quitting = false;  //flag for quit
            string[] input;
            while (!quitting)   //input loop till exit
            {
                Console.Write("Select one of the following, then press enter: 1-Simple to Console 2-Simple to File 3-Custom to Console 4-Custom to File 5-Exit:   ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":   //simple-console
                        fb.SimpleFizzBuzzToConsole();
                        break;
                    case "2":   //simple-file
                        Console.WriteLine("Enter filename, then press enter:");
                        fb.SimpleFizzBuzzToFile(Console.ReadLine());    //looks for filename. Exceptions handled in library
                        break;
                    case "3":   //custom-console
                        Console.WriteLine("Enter the following, separated by spaces: \n min number, max number, 'fizz' word, 'buzz' word\nThen press enter.");
                        input = Console.ReadLine().Split(' ');
                        try
                        {
                            fb.CustomFizzBuzzToConsole(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]), input[2], input[3]);
                        }
                        catch (Exception e)//look for any invalidities in the input and provide a general message
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
                        catch (Exception e)//look for any invalidities in the input and provide a general message, filename is first so the library will catch that
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
                Console.WriteLine("\n\n");  //add some space between runs
            }
        }
    }
}
