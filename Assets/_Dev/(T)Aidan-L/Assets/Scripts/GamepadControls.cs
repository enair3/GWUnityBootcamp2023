using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class GamepadControls : MonoBehaviour
{
    public GameObject player;
    Health health;

    public bool attacked = false;
    public bool dodged = false;
    public bool stalled = false;

    // Start is called before the first frame update
    void Awake()
    {
        health = player.GetComponent<Health>();
    }

    public void DoesAttack(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            Debug.Log("Attacked");
            attacked = true;
        }
    }

    public void DoesDodge(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            Debug.Log("Dodged");
            dodged = true;
        }
    }

    public void DoesStall(InputAction.CallbackContext cxt)
    {
        if (cxt.performed)
        {
            Debug.Log("Stalled");
            stalled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
