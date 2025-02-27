// Written By: Patrick Leonard
// 2/17/25

namespace Zombies;

public class Zombie
{
    // Backing Fields
    private string _name = "n/a";
    private int _health = -1;
    private int _damage = -1;
    private int _speed = -1;
    private int _armor = -1;
    private int _maxHealth = -1;

    // Gets and Sets
    public string Name { get => _name; set => _name = value; }
    public int Health { get => _health; set => _health = value; }
    public int Damage { get => _damage; set => _damage = value; }
    public int Speed { get => _speed; set => _speed = value; }
    public int Armor { get => _armor; set => _armor = value; }
    public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }

    // Constructors
    public Zombie(string name, int health, int damage, int speed, int armor, int maxHealth)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Speed = speed;
        Armor = armor;
        MaxHealth = maxHealth;
    }

    public Zombie() : this("Zombie", 100, 5, 2, 3, 100) { }


}
