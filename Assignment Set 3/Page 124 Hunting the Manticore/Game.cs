// Written By: Patrick Leonard
// 2/12/25

using System.ComponentModel.DataAnnotations;

namespace Page_124_Hunting_the_Manticore
{
    public interface IGameAgent
    {
        // Properties
        string Name { get; }

        // Methods
        public void MakeAttack(IGameAgent target);
        public AttackResult ReceiveDamage(int targetNumber, int damageAmount);
        public bool IsDefeated();

        // Enums
        public enum AttackResult
        {
            OVERSHOT,
            UNDERSHOT,
            DIRECT_HIT
        }
    }

    public class Game
    {
        // Backing Fields
        private int roundNumber = -1;
        private Airship airship;
        private City city;

        // Gets and Sets
        public int RoundNumber
        {
            get => roundNumber;
            private set => roundNumber = value;
        }

        private City CityAgent
        {
            get => city;
            init => city = value;
        }

        private Airship AirshipAgent
        {
            get => airship;
            init => airship = value;
        }

        // Constructors
        public Game()
        {
            RoundNumber = 1;
            airship = new Airship("Manticore", 10, this);
            city = new City("Consolas", 15, this);
        }

        // Methods
        public void Start()
        {
            while (true)
            {
                Console.WriteLine(new string('-', 59));
                Console.WriteLine(GenerateStatus());

                CityAgent.MakeAttack(AirshipAgent);
                if (AirshipAgent.IsDefeated()) break;

                AirshipAgent.MakeAttack(CityAgent);
                if (CityAgent.IsDefeated()) break;

                roundNumber++;
            }

            if (CityAgent.IsDefeated()) Console.WriteLine($"The {AirshipAgent.Name} has proven too strong! The city has fallen!");
            if (AirshipAgent.IsDefeated()) Console.WriteLine($"The {AirshipAgent.Name} has been defeated!");
        }

        private string GenerateStatus()
        {
            return $"""
                STATUS: Round: {RoundNumber} City: {CityAgent.Health}/{CityAgent.MaxHealth} {AirshipAgent.Name}:{AirshipAgent.Health}/{AirshipAgent.MaxHealth}
                """;
        }
    }

    public class Airship : IGameAgent
    {
        // Backing Fields
        private string name = "";
        private int maxHealth = -1;
        private int health = -1;
        private int distanceFromCity = -1;
        private int maxDistance = -1;
        private int minDistance = -1;
        private Game? gameObject = null;

        // Gets and Sets
        public string Name
        {
            get => name;
            init => name = value;
        }

        public int MaxHealth
        {
            get => maxHealth;
            init => maxHealth = value;
        }

        private int DistanceFromCity
        {
            get => distanceFromCity;
            init => distanceFromCity = value.InclusiveClamp(MinimumDistance, MaximumDistance);
        }

        public int Health
        {
            get => health;
            private set => health = value.InclusiveClamp(0, MaxHealth);
        }

        public int MinimumDistance
        {
            get => minDistance;
            private init => minDistance = value.InclusiveClamp(0, int.MaxValue);
        }

        public int MaximumDistance
        {
            get => maxDistance;
            private init => maxDistance = value;
        }

        public Game GameObject
        {
            get => gameObject ?? throw new NullReferenceException();
            init => gameObject = value;
        }
        

        // Constructors
        public Airship(string aName, int aMaxHealth, Game aGame) : this(aName, aMaxHealth, 0, 100, aGame) {}

        public Airship(string aName, int aMaxHealth, int aMinDistance, int aMaxDistance, Game aGame)
        {
            Name = aName;
            MaxHealth = aMaxHealth;
            Health = MaxHealth;
            MinimumDistance = aMinDistance;
            MaximumDistance = aMaxDistance;
            GameObject = aGame;
            DistanceFromCity = Util.QueryParsableFromUser<int>($"How far is the {Name} from the city?");
            Console.Clear();
        }


        // Methods
        public IGameAgent.AttackResult ReceiveDamage(int targetNumber, int damageAmount)
        {
            if(targetNumber > DistanceFromCity)
            {
                return IGameAgent.AttackResult.OVERSHOT;
            } 
            else if(targetNumber < DistanceFromCity)
            {
                return IGameAgent.AttackResult.UNDERSHOT;
            } 
            else
            {
                Health -= damageAmount;
                return IGameAgent.AttackResult.DIRECT_HIT;
            }
        }

        public void MakeAttack(IGameAgent target)
        {
            // Airships only do one damage at a time, guaranteed.
            target.ReceiveDamage(1, 1);
        }

        public bool IsDefeated()
        {
            return Health <= 0;
        }

    }

    public class City : IGameAgent
    {
        // Backing Fields
        private string name = "";
        private int maxHealth = -1;
        private int health = -1;
        private Game? gameObject = null;

        // Constructors
        public City(string aName, int aMaxHealth, Game aGame)
        {
            Name = aName;
            MaxHealth = aMaxHealth;
            Health = MaxHealth;
            GameObject = aGame;
        }

        // Gets and Sets
        public string Name
        {
            get => name;
            init => name = value;
        }

        public int MaxHealth
        {
            get => maxHealth;
            init => maxHealth = value;
        }

        public int Health
        {
            get => health;
            private set => health = value.InclusiveClamp(0, MaxHealth);
        }

        public Game GameObject
        {
            get => gameObject ?? throw new NullReferenceException();
            init => gameObject = value;
        }

        // Methods
        public bool IsDefeated()
        {
            return Health <= 0;
        }

        public void MakeAttack(IGameAgent target)
        {
            int damage = MagicCannonPredictor.PredictDamageFromRoundNum(GameObject.RoundNumber);
            Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

            int cannonAimIndex = Util.QueryParsableFromUser<int>("Enter desired cannon range:");

            IGameAgent.AttackResult result = target.ReceiveDamage(cannonAimIndex, damage);

            switch (result)
            {
                case IGameAgent.AttackResult.OVERSHOT:
                    Console.WriteLine($"That round OVERSHOT the {target.Name}");
                    break;
                case IGameAgent.AttackResult.UNDERSHOT:
                    Console.WriteLine($"That round UNDERSHOT the {target.Name}");
                    break;
                case IGameAgent.AttackResult.DIRECT_HIT:
                    Console.WriteLine($"That was a direct hit on {target.Name}!");
                    break;
            }
        }

        public IGameAgent.AttackResult ReceiveDamage(int targetNumber, int damageAmount)
        {
            // Attacks on cities always hit for one damage.
            Health -= 1;
            return IGameAgent.AttackResult.DIRECT_HIT;
        }

    }
}

public static class Util
{
    public static T QueryParsableFromUser<T>(string prompt) where T : IParsable<T>
    {
        while (true)
        {
            Console.Write(prompt);

            string? resp = Console.ReadLine();

            if (T.TryParse(resp, null, out T? output)){
                if(output is not null)
                {
                    return output;
                }
            }

            Console.WriteLine("Could not parse: try again");
        }
    }

    public static T InclusiveClamp<T>(this T val, T min, T max) where T : IComparable<T>
    {
        if (min.CompareTo(max) > 0)
            throw new ArgumentException("min should not be greater than max");

        if (val.CompareTo(min) < 0) return min;
        else if (val.CompareTo(max) > 0) return max;
        else return val;
    }
}
