using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadControls : MonoBehaviour
{
    PlayerControls controls;

    public GameObject player2;
    Health healthScript;

    public bool attacked = false;
    public bool dodged = false;
    public bool stalled = false;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Fighting.Attack.performed += ctx => DoesDamage();

        controls.Fighting.Dodge.performed += ctx => DoesDodge();

        controls.Fighting.Stall.performed += ctx => DoesStall();

        player2 = GameObject.Find("Player2");

        healthScript = player2.GetComponent<Health>();
    }

    void DoesDamage()
    {
        attacked = true;
    }

    void DoesDodge()
    {
        dodged = true;
    }

    void DoesStall()
    {
        stalled = true;
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
