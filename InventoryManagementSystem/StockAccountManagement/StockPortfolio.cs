using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagementSystem.StockAccountManagement
{
    public class StockPortfolio
    {


        public void DisplayStockDetails(string File_Path)
        {
            using (StreamReader reader = new StreamReader(File_Path))
            {
                string json = reader.ReadToEnd();
                var stockPrice = JsonConvert.DeserializeObject<List<StockDetails>>(json);
                Console.WriteLine("StockName" + "\t" + "NumberOfShare" + "\t" + "SharePrice" + "\t" + "TotalSharePrice");
                foreach (var data in stockPrice)
                {
                    Console.WriteLine(data.StockName + "\t\t" + data.NumberOFShare + "\t\t" + data.SharePrice + "\t\t" + (data.NumberOFShare * data.SharePrice));
                }
            }
        }
    }
}
