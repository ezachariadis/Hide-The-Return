using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPotion : MonoBehaviour,IInteractable
{
    public int HealthPoints = 5;

    public void Interact()
    {
        Statmanager.Instance.AddHealth(HealthPoints);
        this.gameObject.SetActive(false);
    }
}
