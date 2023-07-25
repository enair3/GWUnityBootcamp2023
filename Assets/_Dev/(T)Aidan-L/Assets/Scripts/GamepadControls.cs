using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadControls : MonoBehaviour
{
    PlayerControls controls;

    public GameObject player2;
    Health healthScript;

    public bool attacked;
    public bool dodged;
    public bool stalled;

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
        healthScript.health -= 1;
        Debug.Log("does damage");

        attacked = true;
    }

    void DoesDodge()
    {
        dodged = true;
        Debug.Log("does dodge");
    }

    void DoesStall()
    {
        stalled = true;
        Debug.Log("does stall");
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
