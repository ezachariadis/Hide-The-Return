using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour {

    public Text textCanvas;

    public void Awake()
    {
        textCanvas = GetComponent<Text>();
    }

    public void Update()
    {
        textCanvas.text = "health: " + Statmanager.Instance.GetHealth();
    }
}
