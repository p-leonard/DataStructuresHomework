// Written By: Patrick Leonard
// 2/6/25
namespace Buying_Inventory
{
    internal class Program
    {
        static void Main()
        {
            InventoryPriceProvider inventory = new();

            inventory.PrintItems();

            Console.Write("Which item do you want to view the price of? ");
            string? userChoice = Console.ReadLine();
            if (!int.TryParse(userChoice, out int userItemIndex)) throw new ArgumentException();

            Console.WriteLine($"{inventory.ItemNameByIndex(userItemIndex)} costs {inventory.ItemPriceByIndex(userItemIndex)} gold.");
        }
    }
}
