// Written By: Patrick Leonard
// 2/26/25

namespace AnimalsAndSounds;

public class Program
{
    static void Main(string[] args)
    {
        Dog mahPuppy = new("Caesar");
        Cat mahKitty = new("Hera");

        Console.WriteLine(mahPuppy);
        Console.WriteLine(mahKitty);
    }
}

public class Animal
{
    // Backing Field
    private string name = "n/a";

    // Gets and Sets
    public string Name
    {
        get => name;
        set => name = value;
    }

    // Constructors
    public Animal(string name) => Name = name;

    // Methods
    public virtual string MakeSound() => "Some generic animal sound";
    public override string ToString() => $"{this.GetType().Name}: {Name}, Sound: {MakeSound()}";
}

public class Cat : Animal
{
    // Constructors
    public Cat(string name) : base(name) { }

    // Methods
    public override string MakeSound() => "Meow";
}

public class Dog : Animal
{
    // It sparks primal joy to make code this condensed while still being readable.

    // Constructors
    public Dog(string name) : base(name) { }

    // Methods
    public override string MakeSound() => "Bark";
}
