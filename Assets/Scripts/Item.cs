using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item {

    protected string Name;
    protected int id;

    public Item(string newName, int newid)
    {
        Name = newName;
        id = newid;
    }

    public virtual string GetName()
    {
        return Name;
    }
}

public class Potion : Item
{
    PlayerStats stats;
    public Potion(string newName, int newid, PlayerStats newStats) : base(newName, newid)
    {
        stats = newStats;
    }

    public PlayerStats GetPotionStats()
    {
        return stats;
    }

    public override string GetName()
    {
        return base.GetName();
    }
}

public class PlayerStats
{
    public int Health;
    public int Mana;
    public int Coin;

    public PlayerStats()
    {
        Health = 0;
        Mana = 0;
        Coin = 0;
    }
}
