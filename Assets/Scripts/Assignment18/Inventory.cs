using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> items;
    public Inventory()
    {
        items = new List<string>();
    }

    public void addItem(string item)
    {
        items.Add(item);
    }

    public List<string> showItems()
    {
        foreach (string item in items)
        {
            Debug.Log(item);
        }
        return items;
    }

    public static Inventory operator +(Inventory a, Inventory b)
    {
        Inventory ans = new Inventory();
        foreach (string item in a.items) 
        {
            ans.addItem(item);
        }

        foreach (string item in b.items)
        {
            ans.addItem(item);
        }

        return ans;
    }
}
