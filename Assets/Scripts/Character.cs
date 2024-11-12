
using System;

public class Character
{
    private int health;
    public int Health
    {
        get { return health; }
        set { health = Math.Min(value, 100); }
    }

    public string Name { get; set; }

    public Character(int health, string name)
    {
        Health = health;
        Name = name;
    }
}
