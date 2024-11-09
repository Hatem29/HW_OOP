using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Player player = new Player(100, "Shawqe");
        Enemy enemy = new Enemy(100, "jawad");

        Debug.Log("Player name is : " + player.Name + "\n and his Health is : " + player.Health);
        Debug.Log("Enemy name is : " + enemy.Name + "\n and his Health is : " + enemy.Health);

        player.heal(20);
        Debug.Log(player.Name + " healed, new health : " + player.Health);

        enemy.Attack(player);
        Debug.Log(enemy.Name + " attacked " + player.Name + "\n his new health is : " + player.Health);
    }

}
