using System;

// Namespace 
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run Get app infor for info of app
            GetAppInfo();

            // greet user and ask for name
            GreetUser();

            while (true)
            {
                // Set a random number
                //int correctNumber = 7;
                Random random = new Random(); // create a random object from Random Class
                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                // Prompt user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While the guess is not correct get user input
                while (guess != correctNumber)
                {
                    string inputNum = Console.ReadLine();
                    // Make sure it is a number
                    if (!int.TryParse(inputNum, out guess))
                    {
                        // Output message that it is not a number/integer
                        PrintColorMessage(ConsoleColor.DarkBlue, String.Format("{0} is not a number/integer! Please enter a number/integer!",inputNum));

                        //keep going
                        continue;
                    }
                    // Pars input string to integer
                    // Cast to int and put it into guess
                    guess = Int32.Parse(inputNum);
                    // Match the guess. if not loop again
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Try again");
                    }
                }
                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are Correct!!!");

                // ask to play again
                Console.WriteLine("Play again? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") {
                    continue;
                }
                else if (answer == "n") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //display app info
        static void GetAppInfo(){
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = " Berk Biryol";

            //PrintColorMessage(ConsoleColor.Green, appName + ": " + appVersion + " by " + appAuthor);
            PrintColorMessage(ConsoleColor.Green, String.Format("{0}: Version  {1} by {2}", appName, appVersion, appAuthor));

            ////Change Text Color
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("{0}: Version  {1} by {2}", appName, appVersion, appAuthor);

            //// Reset Text color
            //Console.ResetColor();            
        }

        // greet user
        static void GreetUser(){
            // Ask User name
            Console.WriteLine("Input your name");
            //get user name
            string input = Console.ReadLine();

            // Write out name
            Console.WriteLine("Hello {0}! Lets Play a game!", input);
        }

        // print color message
        static void PrintColorMessage(ConsoleColor color, string message){
            //Change Text Color
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            // Reset Text color
            Console.ResetColor();
        }
    }
}
