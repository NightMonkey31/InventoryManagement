using System;
using System.Collections.Generic;

namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!~~~~WELCOME TO ASSET MANAGEMENT~~~~!!!!");
            items additems = new items();

            while (true)
            {
                Console.WriteLine("*--------------------*");
                Console.WriteLine("| 1. New User        |");
                Console.WriteLine("| 2. Existing User   |");
                Console.WriteLine("| 3. Exit            |");
                Console.WriteLine("*--------------------*");

                Console.WriteLine("Select Option!");
                string user = Console.ReadLine();

                switch (user)
                {
                    case "1":
                        additems.NEWUSER();
                        break;
                    case "2":
                        additems.EXISTINGUSER();
                        break;

                    case "3":
                        Console.WriteLine("**~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
                        Console.WriteLine("||             !GOODBYE!            ||");
                        Console.WriteLine("**~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Choose from the 3 options");
                        break;
                }


                while (true)
                {
                    Console.WriteLine("*--------------------*");
                    Console.WriteLine("| 1. Add Assets      |");
                    Console.WriteLine("| 2. Display Assets  |");
                    Console.WriteLine("| 3. Delete Assets   |");
                    Console.WriteLine("| 4. Update Assets   |");
                    Console.WriteLine("| 5. Exit            |");
                    Console.WriteLine("*--------------------*");
                    Console.WriteLine("Enter your option:");

                    string option = Console.ReadLine();

                    if (option == "1")
                    {
                        additems.Additems();
                    }
                    else if (option == "2")
                    {
                        additems.DisplayItems();
                    }
                    else if (option == "3")
                    {
                        additems.DeleteItems();
                    }
                    else if (option == "4")
                    {
                        additems.UpdateItems();
                    }
                    else if (option == "5")
                    {
                        Console.WriteLine("**~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
                        Console.WriteLine("||    !Thank you for using this!    ||");
                        Console.WriteLine("**~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~**");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Choose from the above options");
                    }
                }
            }
        }
    }
}
