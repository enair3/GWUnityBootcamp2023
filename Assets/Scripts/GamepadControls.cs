using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class GamepadControls : MonoBehaviour
{
    public bool attacked = false;
    public bool dodged = false;
    public bool charged = false;

    public int chargeAmount = 1;

    public int playerSelected;

    public int dodgeDelay = 0;

    public notePlatformCode npcP1;
    public notePlatformCode npcP2;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    void Update()
    {

    }

    public void DoesAttack(InputAction.CallbackContext cxt) //when player clicks attack button (B), attacked variable becomes true
    {
        if (cxt.performed)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                //Debug.Log("attacked");
                attacked = true;
                npcP1.destroyNote();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("attacked");
                attacked = true;
                npcP2.destroyNote();
            }

            if (dodgeDelay >= 1)
            {
                dodgeDelay -= 1;
            }
        }
    }

    public void DoesDodge(InputAction.CallbackContext cxt) //when player clicks dodge button (X), dodged variable becomes true
    {
        if (cxt.performed && dodgeDelay == 0)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                //Debug.Log("dodged");
                dodged = true;
                dodgeDelay = 2;
                npcP1.destroyNote();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("dodged");
                dodged = true;
                dodgeDelay = 2;
                npcP2.destroyNote();
            }

            if (dodgeDelay >= 1)
            {
                dodgeDelay -= 1;
            }
        }
    }

    public void DoesCharge(InputAction.CallbackContext cxt) //when player clicks stall button (A), stalled variable becomes true
    {
        if (cxt.performed)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                //Debug.Log("charged");
                chargeAmount += 1;
                charged = true;
                npcP1.destroyNote();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("charged");
                chargeAmount += 1;
                charged = true;
                npcP2.destroyNote();
            }

            if (dodgeDelay >= 1)
            {
                dodgeDelay -= 1;
            }
        }
    }

}
