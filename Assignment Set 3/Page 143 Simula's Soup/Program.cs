// Written By: Patrick Leonard
// 2/16/25

using System.Runtime.InteropServices;

namespace Page_143_Simula_s_Soup;

public class Program
{
    public static void Main(string[] args)
    {
        SoupFactory sf = new SoupFactory();

        SoupFactory.Soup soup = sf.QuerySeasoning().QueryIngredient().QueryType().Create();

        Console.WriteLine($"Your soup is: {soup.ToTuple()}");
    }
}

public class SoupFactory
{
    // Backing Fields
    private SeasoningType seasoning;
    private IngredientType ingredient;
    private SoupType soupType;

    #region Enums
    public enum SeasoningType
    {
        HOT,
        SALTY,
        SWEET
    }

    public enum IngredientType
    {
        MUSHROOMS,
        CHICKEN,
        CARROTS,
        POTATOES
    }

    public enum SoupType
    {
        SOUP,
        STEW,
        GUMBO
    }
    #endregion

    // Methods
    public SoupFactory QuerySeasoning()
    {

        seasoning = Util.QueryEnumFromUser<SeasoningType>("What kind of seasoning do you want?");
        return this;
    }

    public SoupFactory QueryIngredient()
    {
        ingredient = Util.QueryEnumFromUser<IngredientType>("What kind of ingredient do you want?"); ;
        return this;
    }

    public SoupFactory QueryType()
    {
        soupType = Util.QueryEnumFromUser<SoupType>("What kind of soup do you want?"); ;
        return this;
    }

    public Soup Create()
    {
        return new Soup(seasoning, ingredient, soupType);
    }
    public class Soup
    {
        // Backing Fields
        SeasoningType seasoning;
        IngredientType ingredient;
        SoupType soupType;

        // Gets and Sets
        public SeasoningType Seasoning
        {
            get => seasoning;
            init => seasoning = value;
        }
        public IngredientType Ingredient
        {
            get => ingredient;
            init => ingredient = value;
        }
        public SoupType Type
        {
            get => soupType;
            init => soupType = value;
        }

        // Constructors
        internal Soup(SeasoningType s, IngredientType i, SoupType t) 
        {
            Seasoning = s;
            Ingredient = i;
            Type = t;
        }

        // Methods
        public (SeasoningType, IngredientType, SoupType) ToTuple()
        {
            return (Seasoning, Ingredient, Type);
        }
    }
}

public static class Util
{
    public static T QueryEnumFromUser<T>(string prompt) where T : struct, Enum
    {
        while (true)
        {
            Console.Write(prompt);
            string? resp = Console.ReadLine();

            if (Enum.TryParse(resp, true, out T output) && Enum.IsDefined(typeof(T), output))
            {
                return output;
            }

            Console.WriteLine("Invalid choice. Try again.");
        }
    }
}
