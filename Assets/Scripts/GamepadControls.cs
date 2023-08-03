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

    public Audio_Manager sfx;
    public AudioClip attack;
    public AudioClip dodge;
    public AudioClip charge;

    public Animator playerAnimations;


    public AnimatorStateInfo animTime;
    public float animationTime = -10;

    // Start is called before the first frame update
    void Awake()
    {
        sfx = FindObjectOfType<Audio_Manager>();
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
                Debug.Log("attacked");
                attacked = true;
                npcP1.destroyNote();
                sfx.allSounds[0].PlayOneShot(attack, sfx.volumeSet);
                playerAnimations.Play("RedAttack");
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("attacked");
                attacked = true;
                npcP2.destroyNote();
                sfx.allSounds[0].PlayOneShot(attack, sfx.volumeSet);
                playerAnimations.Play("BlueAttack");
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
                Debug.Log("dodged");
                dodged = true;
                dodgeDelay = 2;
                npcP1.destroyNote();
                sfx.allSounds[0].PlayOneShot(dodge, sfx.volumeSet);
                playerAnimations.Play("RedDodge");
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                //Debug.Log("dodged");
                dodged = true;
                dodgeDelay = 2;
                npcP2.destroyNote();
                sfx.allSounds[0].PlayOneShot(dodge, sfx.volumeSet);
                playerAnimations.Play("BlueDodge");
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
                Debug.Log("charged");
                chargeAmount += 1;
                charged = true;
                npcP1.destroyNote();
                sfx.allSounds[0].PlayOneShot(charge, sfx.volumeSet);
                playerAnimations.Play("RedCharge");
            }

            if (npcP2.noteActive == true && playerSelected == 2)
            {
                Debug.Log("charged");
                chargeAmount += 1;
                charged = true;
                npcP2.destroyNote();
                sfx.allSounds[0].PlayOneShot(charge, sfx.volumeSet);
                playerAnimations.Play("BlueCharge");
            }

            if (dodgeDelay >= 1)
            {
                dodgeDelay -= 1;
            }
        }
    }

}
