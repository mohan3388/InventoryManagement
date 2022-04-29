using System;
using InventoryManagementSystem.InventoryManagement;
using InventoryManagementSystem.StockAccountManagement;

public class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("welcome to the Program");
        const string INVENTORY_FILE_PATH = @"D:\dotnet\InventoryManagementSystem\InventoryManagementSystem\InventoryManagement\Inventory.json";
        InventoryData InventoryData = new InventoryData();
        Console.WriteLine("1.enter 1 to Display \n 2.enter 2 to Display Stock");
        bool check = true;
        while(check)
        {
            Console.WriteLine("enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    InventoryData.DisplayInventoryData(INVENTORY_FILE_PATH);
                    break;
                case 2:
                    const string File_Path = @"D:\dotnet\InventoryManagementSystem\InventoryManagementSystem\StockAccountManagement\StockAccount.json";
                    StockPortfolio port = new StockPortfolio();
                    port.DisplayStockDetails(File_Path);
                    break;
            }
        }
    }
}