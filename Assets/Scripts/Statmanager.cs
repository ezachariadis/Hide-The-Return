using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statmanager : Singleton<Statmanager> {

    private int Health;
    private int KeysCount;
    private string Name;

    public override void Awake()
    {
        base.Awake();
        Health = 50;
    }

    public int GetHealth()
    {
        return Health;
    }

    public void AddHealth(int additionalhealth)
    {
        Health += additionalhealth;
    }
	
}
