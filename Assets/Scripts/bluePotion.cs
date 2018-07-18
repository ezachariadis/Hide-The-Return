using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePotion : MonoBehaviour,IInteractable
{
    Potion Potion = new Potion("BluePotion", 000001, new PlayerStats(){ Health = -5 });

    public void Interact()
    {
        EquipmentManager.Instance.AddItem(Potion);
        this.gameObject.SetActive(false);
    }

}
