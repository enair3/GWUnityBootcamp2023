using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class GamepadControls : MonoBehaviour
{
    //booleans to determine what action the player does
    public bool attacked = false;
    public bool dodged = false; 
    public bool charged = false;

    //the amount of damage the player does when they attack
    public int chargeAmount = 1;

    //which player it is
    public int playerSelected; 

    //to stop the player from using dodge again directly on the next beat
    public int dodgeDelay = 0;

    public notePlatformCode npcP1;
    public notePlatformCode npcP2;

    public Audio_Manager sfx;

    // Start is called before the first frame update
    void Awake()
    {
        sfx = FindObjectOfType<Audio_Manager>();
    }

    //when player clicks attack button (B)
    public void DoesAttack(InputAction.CallbackContext cxt)
    {
        //if player clicks the attack button (B)
        if (cxt.performed)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                //Debug.Log("attacked");

                //sets the attacked boolean to true
                attacked = true;

                npcP1.destroyNote();
                sfx.allSounds[1].Play();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("attacked");

                //sets the attacked button to true
                attacked = true;

                npcP2.destroyNote();
                sfx.allSounds[1].Play();
            }

            //lowers dodge delay by 1 if 1 or higher
            if (dodgeDelay >= 1)
            {
                dodgeDelay -= 1;
            }
        }
    }

    //when player clicks dodge button (X)
    public void DoesDodge(InputAction.CallbackContext cxt)
    {
        //if player clicks the dodge button (X) and it isn't on delay
        if (cxt.performed && dodgeDelay == 0)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                //Debug.Log("dodged");

                //sets the dodged boolean to true
                dodged = true;

                //sets the dodge delay to 2 (goes down by one this beat, so it's only on 1 next beat)
                dodgeDelay = 2;

                npcP1.destroyNote();
                sfx.allSounds[2].Play();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("dodged");

                //sets the dodged boolean to true
                dodged = true;

                //sets the dodge delay to 2 (goes down by one this beat, so it's only on 1 next beat)
                dodgeDelay = 2;

                npcP2.destroyNote();
                sfx.allSounds[2].Play();
            }

            //lowers dodge delay by 1 if 1 or higher
            if (dodgeDelay >= 1)
            {
                dodgeDelay -= 1;
            }
        }
    }

    //when player clicks charge button (A)
    public void DoesCharge(InputAction.CallbackContext cxt) 
    {
        //if player clicks the charge button (A)
        if (cxt.performed)
        {
            if (npcP1.noteActive == true && playerSelected == 1)
            {
                //Debug.Log("charged");

                //damage goes up by one (must come first or it doesn't work)
                if (chargeAmount <= 10)
                {
                    chargeAmount += 1;
                }

                //sets the charged boolean to true
                charged = true;

                npcP1.destroyNote();
                sfx.allSounds[3].Play();
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("charged");

                //damage goes up by one (must come first or it doesn't work)
                if (chargeAmount <= 10)
                {
                    chargeAmount += 1;
                }

                //sets the charged boolean to true
                charged = true;

                npcP2.destroyNote();
                sfx.allSounds[3].Play();
            }

            //lowers dodge delay by 1 if 1 or higher
            if (dodgeDelay >= 1)
            {
                dodgeDelay -= 1;
            }
        }
    }

}
