****USE****

The program has four functionalities, these can each be accessed via the console by keyboard input:

1- Perform a "simple" (0-100, using "Fizz" and "Buzz") FizzBuzz out to the console
2- Perform a simple FizzBuzz to a file. Asks for a filename from the user
3- Perform a "custom" FizzBuzz with input begining and ending numbers, as well as replaced words instead of "Fizz" and "Buzz" these are taken from a split user input
4- Perform a custom FizzBuzz out to a file. The filename should be entered before the other parameters

Pressing 5 exits the program
Files are output into a directory called "Output" within the solution's directory


****TESTS****

I will start this section off by saying I have never done unit tests before. A former classmate recommended the use of NUnit, and it seemed to be an industry standard so I dove in. That being said, I'm not super confident that the tests were as comprehensive as you might expect from a candidate, and I apologize if that's the case. Writing these was pretty darn near to a shot in the dark for me, but, it turned out to be pretty fun. If hired, I can assure you that with some time and practice I'll be doing test-driven development in my sleep.

These are the tests I included:

Checking FizzBuzzLibrary's core functionality
	CheckforFizz				Compares strings for "Fizz" when the appropriate number was divisible by 3 (but not 5)
	CheckforBuzz				Compares strings for "Buzz" when the appropriate number was divisible by 5 (but not 3) 
	CheckforFizzBuzz			Compares strings for "FizzBuzz" when the appropriate number was divisible by 15
	MinHigherThanMax			Checks for exception thrown when the start number is less than the end number
Checking Input handling for exceptions
	InvalidCustomInputParams	Checks for an exception when custom inputs are formatted incorrectly
	NotEnoughCustomInputParams	Checks for an exception when not all custom inputs are provided
	
As you might guess, I created these tests after writing the main code, which if I understand correctly is backwards in some test-driven circumstances. However, it did make certain problems apparent, particularly the min > max issue and making sure my exceptions were properly typed-out. While writing the CheckforFizz,Buzz,FizzBuzz tests I encountered a problem on the tests' side that was causing them to fail. Their failure really concerned me at first since I had seen the correct output while raw debugging the code


****PROCCESS****

It did not take very long to implement the basic solution. After trying to decide between a switch and some if's I sided with ifs, starting with a 5*3 and working down. After uploading that solution, I spent a half hour or so trying to think of the best way to implement the other functionalities: One method overloaded a bunch of times? A single method with a set of properties that determine the output result? A method for every single possibility? I ended up siding with splitting the methods between console and file versions, and included both "simple" versions (of the classic problem) and a parameterized version with custom endpoints and words.

The largest block of time spent "working" on this was folly. After implementing the simple solution and starting the library project, I had the delusion that I would not be able to output the .dll file with the free version of Visual Studio on my laptop. I spent the next few hours downloading and attempting to install VS Pro on an old family computer. A true waste of time, and I am embarassed for it. During this time I decided that rather than write a whole i/o stream thing I'd use the much simpler File.WriteAllText method for this project's purposes. After all that installation was over (about 5 hours time waiting on the internet and then VS's long installation process), I tossed in the file-writing functions (after wrestling with redirecting file output to the project's directory) and an input loop to use the actual program.

As I stated before, I've never done unit testing. After downloading NUnit and reading through its "getting started" page and some of the other documentation, I got started writing out test cases. Mostly to make sure exceptions were being thrown and that the actual output was correct. I know there's a whole bunch of NUnit functionality I am missing out on and some glaring tests I forgot, but I think it's a good shot for a first-timer.