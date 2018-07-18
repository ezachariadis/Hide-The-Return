using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statmanager : Singleton<Statmanager> {

    PlayerStats playerStats = new PlayerStats()
    {
        Health = 50,
        Mana = 20,
        Coin = 0
    };

    public List<Item> ItemList;

    public override void Awake()
    {
    
        base.Awake();
    }

    public int GetHealth()
    {
        return playerStats.Health;
    }

    public void ChangeStats(PlayerStats stats)
    {
        playerStats.Health += stats.Health;
        playerStats.Mana += stats.Mana;
        playerStats.Coin += stats.Coin;
    }
	
}
