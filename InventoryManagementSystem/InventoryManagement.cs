using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace InventoryManagementSystem
{
    public class InventoryManagement
    {
        public void DisplayInventory(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                Console.WriteLine("name" + "\t" + "weight" + "\t" + "pricekg"+"\t\t"+"TotalPrice");
                foreach (var item in inventory)
                {
                    Console.WriteLine(item.name + "\t" + item.weight + "\t" + item.pricekg +"\t\t"+ (item.pricekg * item.weight));
                }
            }


        }
    }
}
