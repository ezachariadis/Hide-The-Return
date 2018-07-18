using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPotion : MonoBehaviour, IInteractable
{
    Potion Red = new Potion("RedPotion", 000001, new PlayerStats() { Health = 5});

    public void Interact()
    {
        EquipmentManager.Instance.AddItem(Red);
        this.gameObject.SetActive(false);
    }
}
