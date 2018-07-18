using UnityEngine;
using System.Collections.Generic;

public class PlayerEvents : MonoBehaviour
{
    IInteractable interactable;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            EquipmentManager.Instance.UseItem(0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        interactable = other.GetComponent<IInteractable>();
        if(interactable != null)
        {
            interactable.Interact();
        }
    }
}
