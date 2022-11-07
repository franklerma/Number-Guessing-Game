using System;


// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo

            GreetUser(); //Ask for user name and greet

            while (true)
            {

                // Init correct number
                // int correctNumber = 7;

                // Create new random object
                Random random = new Random();

                int correctNumber = random.Next(1,10);

                // Init guess var
                int guess = 0;

                // Ask user for input
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Thats not a number you dummy");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please try again");

                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!");

                // Ask to play again
                Console.WriteLine("Play agian? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") 
                { 
                    return;
                }
                else 
                {
                    return;
                }

            }



        }

        //Get and display app info
        static void GetAppInfo() {

            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.5.0";
            string appAuther = "Frank Lerma";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther);

            // Reset text color
            Console.ResetColor();
        }
        //Ask user name and greet
        static void GreetUser() {
            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            //Change text color
            Console.ForegroundColor = color;

            // Tell user number is incorrect
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
