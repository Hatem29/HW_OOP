using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtils
{
    public static void DescribeItem<T>(T item)
    {
        Debug.Log("This item is a " + item);
    }
}
