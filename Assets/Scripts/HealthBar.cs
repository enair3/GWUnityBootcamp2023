using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    Health healthp1script;
    Health healthp2script;
    int healthp1;
    int healthp2;

    void Awake()
    {
        healthp1script = player1.GetComponent<Health>();
        healthp2script = player2.GetComponent<Health>();
        healthp1 = healthp1script.health;
        healthp1 = healthp1script.health;
    }

    void Update()
    {
        float width = player1.GetComponent<Transform>().scale.x;
        Vector2.scale(player1.localScale.x * healthp1, player1.localScale.y);
    }
}
