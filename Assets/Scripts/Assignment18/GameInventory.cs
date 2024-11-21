using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{

    void Start()
    {
        Inventory potions = new Inventory();
        potions.addItem("Healing Potion");
        potions.addItem("Strength Potion");

        Inventory elixirs = new Inventory();
        elixirs.addItem("Elixir");
        elixirs.addItem("Dark Elixir");

        Inventory inventory = potions + elixirs;
        inventory.showItems();
    }
}
