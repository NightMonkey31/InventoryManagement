using System;

namespace InventoryManagement
{
    internal class users
    {

        public void newUser()
        {
            int license_Key = 0000;

            while (true)
            {
                Console.WriteLine("Enter UserName: ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter Pin: ");
                var pin = Console.ReadLine();


                Console.WriteLine("Enter PassKey:");
                int Key = int.Parse(Console.ReadLine());

                if (license_Key == Key)
                {
                    Console.WriteLine($"Weclome to our Inventory Management {user}");
                    break;
                }
                else
                {
                    Console.WriteLine("The PassKey does not match!! Try Again!!!//n");
                }
            }

        }

        public void existingUser()
        {

            int key = 1111;

            while (true)
            {
                Console.WriteLine("Enter username: ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter Pin: ");
                int passkey = int.Parse(Console.ReadLine());

                if (passkey == key)
                {
                    Console.WriteLine($"Wecome back {user}");
                    break;
                }
                else
                {
                    Console.WriteLine("Icorrect username / password. Please Try again");
                }
                Console.WriteLine();
            }

        }
    }
}
