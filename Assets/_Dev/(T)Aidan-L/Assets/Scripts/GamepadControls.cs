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

    public int playerSelected;

    public notePlatformCode npcP1;
    public notePlatformCode npcP2;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    public void DoesAttack(InputAction.CallbackContext cxt) //when player clicks attack button (B), attacked variable becomes true
    {
        if (cxt.performed)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                Debug.Log("attacked");
                attacked = true;
                npcP1.destroyNote();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                Debug.Log("attacked");
                attacked = true;
                npcP2.destroyNote();
            }
        }
    }

    public void DoesDodge(InputAction.CallbackContext cxt) //when player clicks dodge button (X), dodged variable becomes true
    {
        if (cxt.performed)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                Debug.Log("dodged");
                dodged = true;
                npcP1.destroyNote();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                Debug.Log("dodged");
                dodged = true;
                npcP2.destroyNote();
            }
        }
    }

    public void DoesCharge(InputAction.CallbackContext cxt) //when player clicks stall button (A), stalled variable becomes true
    {
        if (cxt.performed)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                Debug.Log("charged");
                chargeAmount += 1;
                charged = true;
                npcP1.destroyNote();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                Debug.Log("charged");
                chargeAmount += 1;
                charged = true;
                npcP2.destroyNote();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
