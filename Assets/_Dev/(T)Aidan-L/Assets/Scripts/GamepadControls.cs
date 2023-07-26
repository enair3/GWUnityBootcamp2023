using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadControls : MonoBehaviour
{
    PlayerControls controls;

    public bool attacked = false; //creates the "attacked" boolean and sets it to false
    public bool dodged = false; //creates the "dodged" boolean and sets it to false
    public bool stalled = false; //creates the "stalled" boolean and sets it to false

    void Awake()
    {
        controls = new PlayerControls();

        //when the attack button (B) is pressed, does DoesDamage
        controls.Fighting.Attack.performed += ctx => DoesDamage();

        //when the dodge button (X) is pressed, does DoesDodge
        controls.Fighting.Dodge.performed += ctx => DoesDodge();

        //when the stall button (A) is pressed, does DoesStall
        controls.Fighting.Stall.performed += ctx => DoesStall();
    }

    void DoesDamage() //sets "attacked" to true
    {
        attacked = true;
    }

    void DoesDodge() //sets "dodged" to true
    {
        dodged = true;
    }

    void DoesStall() //sets "stalled" to true
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
