using System;
// Namespace https://www.youtube.com/watch?v=GcFJjpMFJvI
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";

            //Change Text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset textcolor
            Console.ResetColor();

            //Ask User Name
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} Lets play a game...", inputName);

            while (true) {

                //Init correct number
                //int correctNumber = 7;

                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask User for Number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber) {
                    // Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess)) {
                        //Change Text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its not a number
                        Console.WriteLine("Thats not a number");

                        //Reset textcolor
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber) {
                        //Change Text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its the wron number
                        Console.WriteLine("Wrong number please try again");

                        //Reset textcolor
                        Console.ResetColor();

                    }
                }
                //output succes message

                //Change Text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                //tell the user its the right number
                Console.WriteLine("You are correct!");

                //Reset textcolor
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
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
        }
    }


//xamarin forms tut https://www.youtube.com/watch?v=93ZU6j59wL4
