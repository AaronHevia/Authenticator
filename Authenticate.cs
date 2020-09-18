using System;

namespace Authenticator
{
    class Authenticate
    {
        public void UserName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t\t\tUSER AUTHENTICATION");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPress <ENTER> to Cancel\t\t--OR--\n\nEnter a Username to authenticate:  ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Password()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEnter your Password:  ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
