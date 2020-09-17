using System;
using System.Collections.Generic;

namespace UserLogin
{
    public class Sequence
    {
        Menu menu = new Menu();
        Login login = new Login();
        Establish establish = new Establish();
        List<User> users = new List<User>();

        private string input;
        private string userName;
        private string password;

        private int choice;

        private bool storeUserName;

        public void Run()
        {
            //Run Menu
            menu.Display();
            input = Console.ReadLine();

            while (int.TryParse(input, out choice) == false || choice < 0 || choice > 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid Input.  Please enter the number that coincides with your choice.\n");
                menu.Display();
                input = Console.ReadLine();
            }

            switch (choice)
            {
                case 1 :
                    //Establish Account
                    establish.AskForUserName();
                    input = Console.ReadLine();

                    while (input.Length < 5)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Username must be (6) characters or more.  Please try again.\n");
                        establish.AskForUserName();
                        input = Console.ReadLine();
                    }

                    // Check if list contains userName
                    RegistryCheckList(input);

                    //Ask and Confirm Password

                    //Encrypt Password
                    //Add User
                    AddUser(userName, password);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Username and Password Authenticated.");
                    Run();
                    break;
                case 2 :
                    //Authenticate
                    
                    break ;
                case 3 :
                    //Exit
                    Environment.Exit(0);
                break;
            }

            void RegistryCheckList(string input)
            {
                int count = -1;
                foreach (var u in users)
                {
                    if (u.UserName.Contains(input))
                    {
                        count++;
                    }
                }

                count++;

                if (count == 0)
                {
                    userName = input;
                }
                else if (count > 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Username already exists.  Please try again.\n");
                    establish.AskForUserName();
                }
            }

            // Add user to list
            void AddUser(string userName, string password)
            {
                users.Add(new User(userName, password));
            }

            ///     Return to Menu
        }
    }
}