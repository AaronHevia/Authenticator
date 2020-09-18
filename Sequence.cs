using System;
using System.Collections.Generic;

namespace Authenticator
{
    class Sequence
    {
        public static List<User> users = new List<User>();

        Menu menu = new Menu();
        Authenticate authenticate = new Authenticate();
        Establish establish = new Establish();
        Encryption encryption = new Encryption();

        private string input;
        private string userName;
        private string password;

        private int choice;
        private int element;

        private bool validUser;

        public void Run()
        {
            //Reset validUser for additional registering.
            validUser = false;

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
                    Console.Clear();
                    establish.UserName();
                    input = Console.ReadLine();

                    if (input == "")
                    {
                        Console.Clear();
                        Run();
                    }
                    else
                    {
                        while (input.Length < 5)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Username must be (6) characters or more.  Please try again.\n");
                            establish.UserName();
                            input = Console.ReadLine();
                        }
                    }

                    // Check if list contains userName
                    RegistryCheckList(input);

                    //Ask and Confirm Password
                    password = establish.Password();

                    //Encrypt Password
                    password = encryption.Encrypt(password);

                    //Add User to List
                    users.Add(new User(userName, password));
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Username and Password Established.");
                    Run();
                    break;
                case 2 :
                    //Authenticate
                    Console.Clear();
                    authenticate.UserName();
                    input = Console.ReadLine();

                    if (input == "")
                    {
                        Console.Clear();
                        Run();
                    }

                    AuthenticateUser(input);
                    authenticate.Password();
                    input = Console.ReadLine();
                    password = encryption.Encrypt(input);

                    if (password == users[element].Password)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\t\tAUTHENTICATION COMPLETE");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Username:  {userName}");
                        Console.WriteLine($"Password:  {input}");
                        Console.WriteLine($"Encrypted Password:  {password}");
                        Run();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Invalid password.  Please try again.\n");
                        Run();
                    }
                    break;
                case 3 :
                    //Exit
                    Environment.Exit(0);
                break;
            }

            //Check if username exists prior to getting password.
            void AuthenticateUser(string input)
            {
                bool match = false;

                for (int i = 0; i < users.Count; i++)
                {
                    match = input == users[i].UserName;

                    if (match)
                    {
                        element = i;
                        userName = input;
                    }
                }

                if(!match)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Username does not exist.  Please try again.\n");
                    Run();
                }
            }

            //Check if username exists prior to registering.
            void RegistryCheckList(string input)
            {
                while (!validUser)
                {
                    int count = -1;

                    foreach (var user in users)
                    {
                        if (user.UserName.Contains(input))
                        {
                            count++;
                        }
                    }

                    count++;

                    if (count == 0)
                    {
                        userName = input;
                        validUser = true;
                    }
                    else if (count > 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Username already exists.  Please try again.\n\n");
                        establish.UserName();
                        input = Console.ReadLine();
                        RegistryCheckList(input);
                    }
                }
            }
        }
    }
}