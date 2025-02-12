// Written By: Patrick Leonard
// 2/6/25

namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initArr = new int[5];

            for(int i = 0; i != initArr.Length; i++)
            {
                Console.WriteLine("Enter the value: ");
                string? userChoice = Console.ReadLine();

                if (!int.TryParse(userChoice, out int userInt)) throw new ArgumentException();

                initArr[i] = userInt;
            }

            int[] otherArr = Replicator.Replicate(initArr);

            for(int i = 0; i != initArr.Length; i++)
            {
                Console.WriteLine($"Index: {i} Initial Array Val: {initArr[i]} Replicated Value: {otherArr[i]}");
            }
        }
    }
}
