using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject player;
    
    public Slider slider;
    Health healthScript;

    void Awake()
    {
        healthScript = player.GetComponent<Health>();
    }

    void Update()
    {
        slider.value = healthScript.health;
    }
}
