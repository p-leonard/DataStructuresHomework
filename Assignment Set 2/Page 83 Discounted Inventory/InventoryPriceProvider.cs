// Written By: Patrick Leonard
// 2/6/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounted_Inventory
{
    public class InventoryPriceProvider
    {

        // We need two separate records to make sure we can maintain consistent indices for each item.
        // Dictionaries do not guarantee insertion order when accessing keys.
        private Dictionary<string, int> priceList = new()
            {
                {"Rope", 10 },
                {"Torches", 15 },
                {"Climbing Equipment", 25 },
                {"Clean Water", 1 },
                {"Machete", 20 },
                {"Canoe", 200 },
                { "Food Supplies", 1 }
            };

        private List<string> itemIndex = new() // INTERNALLY, items are zero-indexed. EXTERNALLY, items are one-indexed.
            {
                "Rope",
                "Torches",
                "Climbing Equipment",
                "Clean Water",
                "Machete",
                "Canoe",
                "Food Supplies"
            };

        // Gets, Sets, and Calculated Properties
        private List<string> Items
        {
            get => itemIndex;
        }

        // Methods
        public void PrintItems()
        {
            Console.WriteLine("The following items are available:");
            int i = 1;
            foreach(string ItemName in Items)
            {
                Console.WriteLine($"{i} - {ItemName}");
                i++;
            }
        }

        public string ItemNameByIndex(int index)
        {
            return Items[index - 1];
        }

        public int ItemPriceByIndex(int index)
        {
            return priceList[ItemNameByIndex(index)];
        }

        public int GetItemPriceByIndex(int index)
        {
            // To be entirely clear. I would never in a million years implement it this way.
            // I'm satisfying external restraints here: a switch statement is required.
            return index switch
            {
                1 => priceList[Items[0]],
                2 => priceList[Items[1]],
                3 => priceList[Items[2]],
                4 => priceList[Items[3]],
                5 => priceList[Items[4]],
                6 => priceList[Items[5]],
                7 => priceList[Items[6]],
                _ => throw new ArgumentException()
            };
        }

        public int GetItemPriceByIndex(int index, string customerName)
        {
            int price = index switch
            {
                1 => priceList[Items[0]],
                2 => priceList[Items[1]],
                3 => priceList[Items[2]],
                4 => priceList[Items[3]],
                5 => priceList[Items[4]],
                6 => priceList[Items[5]],
                7 => priceList[Items[6]],
                _ => throw new ArgumentException()
            };

            return customerName == "Patrick" ? price / 2 : price;
        }
    }
}
