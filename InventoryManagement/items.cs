using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class items : users
    {

        users users = new users();

        public void NEWUSER()
        {
            users.newUser();
        }

        public void EXISTINGUSER()
        {
            users.existingUser();
        }
        
        public List<string> item = new List<string>();
        public void Additems()
        {
            Console.WriteLine("How many assets you want to add: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Enter asset {i + 1}: \n");
                string asset = Console.ReadLine();
                item.Add(asset);

            }
            Console.WriteLine("Assets added successfully");
        }

        public void DisplayItems()
        {
            if (item.Count > 0)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Currently there are no assests in your inventory! :(");
            }
        }

        public void DeleteItems()
        {
            Console.WriteLine("Enter the index of the asset to be deleted: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 0 && x <= item.Count)
            {
                item.RemoveAt(x);
                Console.WriteLine("Asset has been removed successfully!!");
            }
            else
            {
                Console.WriteLine("Asset does not exist at the current index");
            }

        }
        public void UpdateItems()
        {
            Console.WriteLine("Enter the index of the asset to be updated: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the updated asset: ");
            string asset = Console.ReadLine();

            if (x >= 0 && x <= item.Count)
            {
                item[x] = asset;
                Console.WriteLine("Asset has been updated successfully!!");
            }
            else
            {
                Console.WriteLine("Asset does not exist at the current index");
            }

        }

    }
}
