using System;
using System.Collections.Generic;

namespace Authenticator
{
    public class Sequence
    {
        Menu menu = new Menu();
        Authenticate authenticate = new Authenticate();
        Establish establish = new Establish();
        Encryption encryption = new Encryption();
        List<User> users = new List<User>();

        private string input;
        private string userName;
        private string password;

        private int choice;

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

                    

                    break ;
                case 3 :
                    //Exit
                    Environment.Exit(0);
                break;
            }

            //Check if username exists prior to registering.
            void RegistryCheckList(string input)
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
                }
                else if (count > 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Username already exists.  Please try again.\n");
                    establish.UserName();
                }
            }
        }
    }
}