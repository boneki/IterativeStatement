using System;

namespace IterativeStatementEthanAnderson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiating boolean that will be used to restart or kill program
            bool restartProgram;

            // Program loop begins here
            do
            {
                string userInput;
                Console.WriteLine("Please enter an integer between 2 and 10:");
                userInput = Console.ReadLine();

                // ------------------------------------------------------------

                // Trying to convert user input to a useable integer form,
                // returning an error message if that fails
                if (Int32.TryParse(userInput, out int convert))
                {
                    if (convert >= 2 && convert <= 10)
                    {
                        int i;
                        int calc;

                        if (convert % 2 == 1)
                        {
                            calc = convert - 1;
                            for (i = 1; i <= calc; i++)
                            {
                                Console.WriteLine(i + ". You entered an odd number");
                            }
                        }

                        else
                        {
                            calc = convert + 1;
                            for (i = 1; i <= calc; i++)
                            {
                                Console.WriteLine(i + ". You entered an even number");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("That's not within range.");
                    }
                }

                // This is the error message if the user input fails the
                // conversion
                else
                {
                    Console.WriteLine("Could not use input.");
                }

                // ------------ Offering option to restart program ------------

                string yesNo;
                Console.WriteLine("Would you like to restart the program?");
                yesNo = Console.ReadLine();

                if (yesNo == "y")
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Welcome back!");
                    restartProgram = true;
                }

                else
                {
                    Console.WriteLine("Goodbye!");
                    restartProgram = false;
                }
                
                // ------------------------------------------------------------

            }

            while (restartProgram == true);
        }
    }
}
