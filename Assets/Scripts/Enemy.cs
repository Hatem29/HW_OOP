using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public int Damage { get; private set; }
    public Enemy(int health, string name) : base(health, name)
    {
        Damage = 50;
    }

    public void Attack(Character target)
    {
        target.Health = target.Health - Damage;
    }
}
