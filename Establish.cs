using System;
using System.Linq;

namespace Authenticator
{
    class Establish
    {
        private readonly char[] lowerCased =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        private readonly char[] upperCased =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private readonly char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        private readonly char[] characters = { '!', '@', '#', '$', '%', '&', '*', '(', ')', '_', '-', '=', '+' };

        private string input;
        private string password;

        private int lowerCount;
        private int upperCount;
        private int numberCount;
        private int characterCount;

        public void UserName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t\t\tUSER REGISTRATION");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPress <ENTER> to Cancel\t\t--OR--\n\nEnter a Username to register and press <ENTER> to begin registering:  ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string Password()
        {
            //Ask for Password
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEnter a Password to register and press <ENTER>:  ");
            Console.ForegroundColor = ConsoleColor.White;
            input = Console.ReadLine();
            
                while (input.Length < 7)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Password must be (8) characters or more and contain (2) of the following:" +
                                  "\n (2) lower-cased letters." +
                                  "\n (2) upper-cased letters." +
                                  "\n (2) numbers." +
                                  "\n (2) characters (! , @ , # , $ , % , & , * , ( , ) , _ , - , = , +)" +
                                  "\nPlease try again.\n");
                    Password();
                    input = Console.ReadLine();
                }
            
            foreach (var c in input)
            {
                if (lowerCased.Contains(c))
                {
                    lowerCount++;
                }

                if (upperCased.Contains(c))
                {
                    upperCount++;
                }

                if (numbers.Contains(c))
                {
                    numberCount++;
                }

                if (characters.Contains(c))
                {
                    characterCount++;
                }
            }

            if (lowerCount < 2 || upperCount < 2 || numberCount < 2 || characterCount < 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Password must be (8) characters or more and contain (2) of the following:" +
                              "\n (2) lower-cased letters" +
                              "\n (2) upper-cased letters" +
                              "\n (2) numbers" +
                              "\n (2) characters (! , @ , # , $ , % , & , * , ( , ) , _ , - , = , +)" +
                              "\nPlease try again.\n");
                Password();
            }

            password = input;

            //Confirm Password
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nConfirm your Password:  ");
            Console.ForegroundColor = ConsoleColor.White;
            input = Console.ReadLine();

            if (input != password)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Password and Password confirmation do not match.  Please try again.\n");
                Password();
            }

            return password;
        }
    }
}
