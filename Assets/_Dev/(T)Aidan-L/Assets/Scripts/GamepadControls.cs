using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class GamepadControls : MonoBehaviour
{
    public GameObject player;

    public bool attacked = false;
    public bool dodged = false;
    public bool charged = false;

    public int chargeAmount = 1;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    public void DoesAttack(InputAction.CallbackContext cxt) //when player clicks attack button (B), attacked variable becomes true
    {
        if (cxt.performed)
        {
            attacked = true;
        }
    }

    public void DoesDodge(InputAction.CallbackContext cxt) //when player clicks dodge button (X), dodged variable becomes true
    {
        if (cxt.performed)
        {
            dodged = true;
        }
    }

    public void DoesCharge(InputAction.CallbackContext cxt) //when player clicks stall button (A), stalled variable becomes true
    {
        if (cxt.performed)
        {
            chargeAmount += 1;
            charged = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
