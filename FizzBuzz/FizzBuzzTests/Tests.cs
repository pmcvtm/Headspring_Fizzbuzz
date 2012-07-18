using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzLibrary;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class Tests
    {
        FizzBuzzer fb;          //the fizzbuzzer functionality
        string input;           //string to represent console input
        string[] split;         //when split strings
        string output;          //output of acutal fizzbuzzing

        [SetUp]
        public void Init()
        {
            fb = new FizzBuzzer();
            input = "";
        }

        [Test]
        public void CheckforFizz()
        {
            output = fb.TestHelper(1, 100, "Fizz", "Buzz");
            split = output.Split();
            for (int i = 0; i < split.Length; i++)
            {
                if ((i + 1) % 3 == 0 && ((i + 1) % 15 != 0))
                    StringAssert.AreEqualIgnoringCase("Fizz", split[i], "i: " + i + "number: " );
            }
        }

        [Test]
        public void CheckforBuzz()
        {
            output = fb.TestHelper(1, 100, "Fizz", "Buzz");
            split = output.Split();
            for (int i = 0; i < split.Length; i++)
            {
                if ((i + 1) % 5 == 0 && ((i + 1) % 15 != 0))
                    StringAssert.AreEqualIgnoringCase("Buzz", split[i], "i: " + i + "number: ");
            }
        }

        [Test]
        public void CheckforFizzBuzz()
        {
            output = fb.TestHelper(1, 100, "Fizz", "Buzz");
            split = output.Split();
            for (int i = 0; i < split.Length; i++)
            {
                if((i+1) % 15 == 0)
                    StringAssert.AreEqualIgnoringCase("FizzBuzz", split[i], "i: " + i + "number: ");
            }
        }

        [Test]
        public void MinHigherThanMax()
        {
            Assert.Throws(Is.TypeOf<Exception>()
                 .And.Message.EqualTo("Start Number is not less than End Number"),
            delegate { fb.CustomFizzBuzzToConsole(1000, 0, "Fizz", "Buzz"); } );
        }

        [Test]
        [ExpectedException(typeof(FormatException))]
        public void InvalidCustomInputParams()
        {
            input = "xxxx xxxxx xxxxx xxxxx";
            split = input.Split(' ');
            fb.CustomFizzBuzzToConsole(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), split[2], split[3]);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NotEnoughCustomInputParams()
        {
            input = "000 000";
            split = input.Split(' ');
            fb.CustomFizzBuzzToConsole(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), split[2], split[3]);
        }

    }
}
