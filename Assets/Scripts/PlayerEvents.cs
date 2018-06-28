using UnityEngine;
using System.Collections;

public class PlayerEvents : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
        Manager.Instance.Interact();
    }

    // Update is called once per frame
    void Update()
    {
        Manager.Instance.Interact();
    }
}
