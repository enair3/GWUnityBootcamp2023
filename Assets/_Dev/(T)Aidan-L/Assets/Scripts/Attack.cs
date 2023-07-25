using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    PlayerControls controls;

    public GameObject player2;
    Health healthScript;

    public bool attacked;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Fighting.Attack.performed += ctx => DoesDamage();


        player2 = GameObject.Find("Player2");

        healthScript = player2.GetComponent<Health>();
    }

    void DoesDamage()
    {
        healthScript.health -= 1;
        Debug.Log("does damage");

        attacked = true;
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
