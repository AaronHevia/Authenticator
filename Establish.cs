using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class Establish
    {
        public void AskForUserName()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t\t\tUSER REGISTRATION");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nPlease enter a userName and press <ENTER> or press <ESC> to Cancel:  ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void AskForPassword(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nPlease enter a Password and press <ENTER> or press <ESC> to Cancel:  ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ConfirmPassword(string password)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nPlease enter a Password and press <ENTER> or press <ESC> to Cancel:  ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        ///
        ///     Password
        ///
        ///     Confirm Password input
        /// 
        ///     Verify password matches requirements
        ///
        ///     Encrypt Password
        ///
        ///

        //  if (password.text.Length > 5 && password.text == confirmPassword.text)
        //{
        //    validPassword = true;
        //}
        //else if (password.text.Length< 6)
        //{
        //    Debug.Log("Password must be at least 6 characters long");
        //    registerMessageBoard.text = "Password must be at least 6 characters long";
        //}
        //else if (password.text != confirmPassword.text)
        //{
        //    Debug.Log("Passwords do not match");
        //    registerMessageBoard.text = "Passwords do not match";
        //}
    }
}
