using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public static Audio instance;

    public void Awake()
    {
        instance = this;
    }

    public void IncreaseLife()
    {

    }

}
