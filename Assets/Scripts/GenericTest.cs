using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericTest : MonoBehaviour
{
    GameContainer<string> container;

    void Start()
    {
        container = new GameContainer<string>();
        container.setItem("Healing Potion");

        string item = container.getItem();
        GameUtils.DescribeItem(item);
    }
}
