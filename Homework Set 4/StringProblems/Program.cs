// Written By: Patrick Leonard
// 2/16/25

using System.Text;

namespace StringProblems;

public class Program
{
    static void Main(string[] args)
    {
        Solution1.Test();
        Solution2.Test();
        Solution3.Test();
        Solution4.Test();
        Solution5.Test();
    }
}

public static class Solution1
{
    public static void Test()
    {
        Console.WriteLine($"Testing:");
        List<(string, int)> testData = new()
        {
            ("Just an example here, move along.", 6),
            ("This is a test", 4),
            ("What an easy task, right", 5)
        };

        foreach((string, int) tup in testData)
        {
            Console.WriteLine($"  In: {tup.Item1} Result: {CountWords(tup.Item1)} Expected: {CountWords(tup.Item1)}");
        }
    }

    public static int CountWords(string str)
    {
        int numWords = 0;
        char lastProcessed = ' ';
        foreach(char c in str)
        {
            if (c == ' ' && lastProcessed != ' ') numWords++;
            lastProcessed = c;
        }

        return numWords;
    }
}

public static class Solution2
{
    public static void Test()
    {
        Console.WriteLine($"Testing:");
        List<(string, string)> testData = new()
        {
            ("Cat, dog, and mouse.",  ".at, dog, and mouseC"),
            ("ada", "Two's a pair."),
            ("z", "Incompatible.")
        };

        foreach ((string, string) tup in testData)
        {
            Console.WriteLine($"  In: {tup.Item1} Result: {flipEndChars(tup.Item1)} Expected: {tup.Item2}");
        }
    }

    public static string flipEndChars(string str)
    {
        if (str[^1] == str[0]) return "Two's a pair.";
        if (str.Length < 2) return "Incompatible";

        StringBuilder stringBuilder = new(str);

        stringBuilder[0] = str[^1];
        stringBuilder[^1] = str[0];

        return stringBuilder.ToString();
    }
}

public static class Solution3
{
    public static void Test()
    {
        Console.WriteLine($"Testing:");
        List<(string, bool)> testData = new()
        {
            ("abc",  true),
            ("edabit", false),
            ("123",true),
            ("xyzz", true)
        };

        foreach ((string, bool) tup in testData)
        {
            Console.WriteLine($"  In: {tup.Item1} Result: {isInOrder(tup.Item1)} Expected: {tup.Item2}");
        }
    }

    public static bool isInOrder(string str)
    {
        int highestSeenCode = -1;
        foreach (char c in str)
        {
            if ((int) c < highestSeenCode) return false;
            highestSeenCode = (int) c;
        }

        return true;
    }
}

public static class Solution4
{
    public static void Test()
    {
        Console.WriteLine($"Testing:");
        List<(string, int, string)> testData = new()
        {
            ("sharpening skills", 3, "aei"),
            ("major league", 5, "aoeau"),
            ("hostess", 5, "invalid")
        };

        foreach ((string, int, string) tup in testData)
        {
            Console.WriteLine($"  In: ({tup.Item1},{tup.Item2}) Result: {firstNVowels(tup.Item1, tup.Item2)} Expected: {tup.Item3}");
        }
    }

    public static string firstNVowels(string str, int n)
    {
        StringBuilder output = new();
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        foreach(char c in str)
        {
            if (vowels.Contains(c)) output.Append(c);
            if (output.Length == n) return output.ToString();
        }

        return "invalid";

    }
}

public static class Solution5
{
    public static void Test()
    {
        Console.WriteLine($"Testing:");
        List<(string, string)> testData = new()
        {
            ("hello", "ifmmp"),
            ("bye", "czf"),
            ("welcome", "xfmdpnf")
        };

        foreach ((string, string) tup in testData)
        {
            Console.WriteLine($"  In: {tup.Item1} Result: {move(tup.Item1)} Expected: {tup.Item2}");
        }
    }

    public static string move(string str)
    {
        StringBuilder output = new(str.Length);
        foreach(char c in str)
        {
            output.Append((char)((int)c + 1));
        }

        return output.ToString();
    }
}
