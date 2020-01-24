using System;

namespace powerstable
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int userInput;
            //begin validation do-while loop
            do
            {   
                //asks for number, checks for valid input & outputs to int
                userInput = ParseInput("Give me a number: ");
                //set up for table
                Console.WriteLine("====================");
                Console.WriteLine("Number  Square  Cube");
                Console.WriteLine("====================");
                //for loop runs for numbers 1 through input number
                for(int i = 1; i <= userInput; i++)
                {
                    //outputs a line with input, squared, & cubed numbers
                    Console.WriteLine($"{i}\t{Squared(i)}\t{Cubed(i)}");
                }
                Console.WriteLine("====================");
                
                
              //confirm program continuation or end  
            } while (ValidateInput());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Goodbye");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int Cubed(int num1)
        {
            //cube output
            return num1 * num1 * num1;
        }
        public static int Squared(int num1)
        {
            //square output
            return num1 * num1;
        }
        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int ParseInput(string message)
        {
            //parsed value
            int value;
            //checks for valid input and parse input if valid
                while(!int.TryParse(GetUserInput(message),out value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entry is not a valid number, please try agian");
                    Console.ResetColor();
                }
                return value;
        }
        public static bool ValidateInput()
        {
            string usertInput = GetUserInput("Would you like to proceed? ").ToLower();
            if(usertInput == "y")
            {
                return true;
            }
            else if(usertInput == "n")
            {
                return false;
            }
            else
            {
                return ValidateInput();
            }
        }
    }
}
