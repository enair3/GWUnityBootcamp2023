using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public HealthBar healthbar;

    public void decreaseHealth()
    {
        healthbar.health -= 1;
    }
}
