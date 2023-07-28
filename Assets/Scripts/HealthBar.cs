using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public int health;

    public void SetMaxHealth()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth()
    {
        slider.value = health;
    }

    void Update()
    {
        slider.value = health;
    }
}