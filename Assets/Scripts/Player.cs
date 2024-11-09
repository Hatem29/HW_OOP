using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(int health, string name) : base(health, name)
    {
    }

    public void heal(int amount)
    {
        Health = Health + amount;
    }

}
