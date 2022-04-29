using OOPS.InventoryDataManupulate;
using OOPS.InventoryDataManupulation;
using System;

class Program
{
    private static object inventoryManupulate;

    static void Main(String[] args)
    {
        const string INVENTORY_FILE_PATH = @"D:\dotnet\InventoryManagement\InventoryManagement\OOPS\InventoryDataManupulate\inventory.json";
        InventoryData invent = new InventoryData();
        bool check = true;
        Console.WriteLine("inventory program");
        Console.WriteLine("1.press 1 to diplay\n 2.press 2 to Edit  data");
        while (true)
        {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    invent.DisplayInventoryData(INVENTORY_FILE_PATH);
                    break;

                case 2:
                    Console.WriteLine("Enter the InventoryName List \n Grain Name\n FilePath");
                    string inventoryName = Console.ReadLine();
                    Inventory data1 = new Inventory();
                    data1.Name = Console.ReadLine();
                    data1.Weight = 40;
                    data1.Price = 75;
                    const string INVENTORY_FILE_PATH1 = @"D:\dotnet\InventoryManagement\InventoryManagement\OOPS\InventoryManagement\Inventory.json";
                    InventoryManupulate inventoryManupulate = new InventoryManupulate(); 
                    inventoryManupulate.EditInventory(data1, inventoryName, INVENTORY_FILE_PATH1);
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}
