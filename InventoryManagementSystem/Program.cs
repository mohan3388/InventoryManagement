using System;
namespace InventoryManagementSystem;

class Program
{
    static void Main(String[] args)
    {
        const string INVENTORY_FILE_PATH = @"D:\dotnet\inventorymanage\Inventory\invent.json";
        InventoryManagement invent = new InventoryManagement();
        bool check = true;
        Console.WriteLine("inventory program");
        Console.WriteLine("press 1 to diplay");
        while (true)
        {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    invent.DisplayInventory(INVENTORY_FILE_PATH);
                    break;

                case 0:
                    check = false;
                    break;
            }
        }
    }
}
