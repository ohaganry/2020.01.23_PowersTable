using System;

namespace powerstable
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int squared;
            int cubed;
            int userInput;
            string temp;
            bool proceed = false;
            //begin validation do-while loop
            do
            {
                do
                {
                    Console.WriteLine("Give me a whole number up to 20");
                    temp = Console.ReadLine();
                    bool num = int.TryParse(temp, out userInput);

                } while (temp == false);
               
            } while (proceed == true);
        }
        public static int Cubed(int num1)
        {
            int cubed = Squared(num1) * num1;
            return cubed;
        }
        public static int Squared(int num1)
        {
            int squared = num1 * num1;
            return squared;
        }
    }
}
