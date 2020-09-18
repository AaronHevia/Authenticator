using System;

namespace Authenticator
{
    class Menu
    {
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t\t\tPASSWORD AUTHENTICATION SYSTEM");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\tPlease select one option:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t1.Establish an account\n\t\t\t2.Authenticate a user\n\t\t\t3.Exit the system");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEnter selection and press <ENTER>:  ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
