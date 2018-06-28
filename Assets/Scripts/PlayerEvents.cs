using UnityEngine;
using System.Collections;

public class PlayerEvents : MonoBehaviour
{
    IInteractable interactable;

    void OnTriggerEnter(Collider other)
    {
        interactable = other.GetComponent<IInteractable>();
        if(interactable != null)
        {
            interactable.Interact();
        }
    }
}
