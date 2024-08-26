

using System; // Using System Namespace

namespace Task1 // My Namespace
{
    class Calculator // My Class name
    {
        public static void Main(string[] args) // Because we always need a Main function
        {
            char Menu = 'c'; // Stores the input for the main menu
            float Num1, Num2; // Stores the numbers for the calculation
            char Symbol; // Stores the operator for the calculation

            do // The loop that will run till the user is finish
            {
                Console.Write("\n Welcome to my Calculator!" +
                              "\n Main Menu: " +
                              "\n 'C' Continue to Calculator" +
                              "\n 'Q' Quit \n"); // This is the main menu
                Menu = (Convert.ToChar(Console.ReadLine())); // Converting the input to a char

                switch (Menu) // Main flow control switch
                {
                    case 'Q' or 'q': // Pressing Q will quit the program
                        Console.WriteLine("Thank you for using my Calculator!");
                        return;
                    case 'C' or 'c': //Pressing C will boot up the programs purpose
                        Console.Write("Please enter the first number: "); // asking user for an input
                        while (!float.TryParse(Console.ReadLine(), out Num1)) // Tries to convert the input above to a float and then saves as a variable called Num1
                        {
                            Console.Write("Invalid input. Please enter a valid number: "); // If input is invalid
                        }
                        Console.Write("Please enter the second number: "); // Asks the user to input a second number
                        while (!float.TryParse(Console.ReadLine(), out Num2))// Tries to convert the input above to a float and then saves as a variable called Num2
                        {
                            Console.Write("Invalid input. Please enter a valid number: "); // If input in invalid
                        }
                        Console.Write("Please enter the operator: " +
                                "\n '+' For Addition" +
                                "\n '-' For Subtraction" +
                                "\n '*' For Multiplication" +
                                "\n '/' For Division \n"); // Asks the user for an operator
                        Symbol = (Convert.ToChar(Console.ReadLine())); // Tries to convert the input to a char and saves it to a variable named Symbol

                        switch (Symbol) // Starts the calculation functionality
                        {
                            case '+': // If addition was selected
                                Console.WriteLine("Result: "); // Prints Result to the screen
                                Console.WriteLine(Num1 + Num2); // Does addition calculation
                                break;
                            case '-': // If subtraction was selected
                                Console.WriteLine("Result: ");// Prints Result to the screen
                                Console.WriteLine(Num1 - Num2); // Does subtraction calculation
                                break;
                            case '*': // If multiplication was selected
                                Console.WriteLine("Result: ");// Prints Result to the screen
                                Console.WriteLine(Num1 * Num2); // Does multiplication calculation
                                break;
                            case '/': // If division was selected
                                Console.WriteLine("Result: "); // Prints Result to the screen
                                Console.WriteLine(Num1 / Num2); // Does division calculation
                                break;
                            default: // If input was invalid
                                Console.WriteLine("That is an invalid operator, Please try again!"); // Handles if the user inputs an invalid operator
                                break;
                        }
                        break;
                }

            } while (Menu == 'c'); // Keeps the loop going till the user is finish
        }
    }
}
