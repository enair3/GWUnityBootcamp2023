using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    PlayerControls controls;

    public GameObject player2;
    Health healthScript;
    int health;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Fighting.Attack.performed += ctx => Damage();


        player2 = GameObject.Find("Player2");

        healthScript = player2.GetComponent<Health>();

        health = healthScript.health;
    }

    void Damage()
    {
        health -= 1;
        Debug.Log("does damage");
    }

    void OnEnable()
    {
        controls.Fighting.Enable();
    }

    void OnDisable()
    {
        controls.Fighting.Disable();
    }
}
