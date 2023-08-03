using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeDecider : MonoBehaviour
{
    //player objects, set in inspector
    public GameObject player1;
    public GameObject player2;

    //player gamepad controls scripts
    GamepadControls gamepadControlsP1; 
    GamepadControls gamepadControlsP2; 

    //player health scripts
    Health healthP1; 
    Health healthP2; 

    // Start is called before the first frame update
    void Awake()
    {
        //sets the two variables to the GamepadControls components on the player 1 and player 2 objects
        gamepadControlsP1 = player1.GetComponent<GamepadControls>();
        gamepadControlsP2 = player2.GetComponent<GamepadControls>();

        //sets the two variables to the Health components on the player 1 and player 2 objects
        healthP1 = player1.GetComponent<Health>();
        healthP2 = player2.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        //if player 1 attacks
        if (gamepadControlsP1.attacked == true)
        {
            //resets player 1 for next beat
            gamepadControlsP1.attacked = false;

            //if player 2 attacks when player 1 attacks
            if (gamepadControlsP2.attacked == true)
            {
                //player 1 takes damage
                healthP1.health -= gamepadControlsP2.chargeAmount;
                gamepadControlsP1.playerAnimations.Play("RedDamaged");

                //player 2 takes damage
                healthP2.health -= gamepadControlsP1.chargeAmount;
                gamepadControlsP2.playerAnimations.Play("BlueDamaged");

                //resets player 2 for next beat
                gamepadControlsP2.attacked = false;

                //resets player 2 charge amount
                gamepadControlsP2.chargeAmount = 1;
            }

            //if player 2 dodges when player 1 attacks
            else if (gamepadControlsP2.dodged == true)
            {
                //resets player 2 for next beat
                gamepadControlsP2.dodged = false;
            }

            //if player 2 charges when player 1 attacks
            else if (gamepadControlsP2.charged == true)
            {
                //player 2 takes damage
                healthP2.health -= gamepadControlsP1.chargeAmount;
                gamepadControlsP2.playerAnimations.Play("BlueDamaged");

                //resets player 2 for next beat
                gamepadControlsP2.charged = false;

                //resets player 2 charge amount
                gamepadControlsP2.chargeAmount = 1;
            }

            //if player 2 misses the beat when player 1 attacks
            else if (gamepadControlsP2.attacked == false && gamepadControlsP2.dodged == false && gamepadControlsP2.charged == false)
            {
                //player 2 takes damage
                healthP2.health -= gamepadControlsP1.chargeAmount;
                gamepadControlsP2.playerAnimations.Play("BlueDamaged");

                //player 2 reset charge amount
                gamepadControlsP2.chargeAmount = 1;

                //player 2 dodge delay goes down by 1 if higher than 0
                if (gamepadControlsP2.dodgeDelay >= 1)
                {
                    gamepadControlsP2.dodgeDelay -= 1;
                }
            }

            //player 1 reset charge amount
            gamepadControlsP1.chargeAmount = 1;
        }

        //if player 1 dodges
        else if (gamepadControlsP1.dodged == true)
        {
            //resets player 1 for next beat
            gamepadControlsP1.dodged = false;

            //if player 2 attacks when player 1 dodges
            if (gamepadControlsP2.attacked == true)
            {
                //resets player 2 for next beat
                gamepadControlsP2.attacked = false;

                //player 2 reset charge amount
                gamepadControlsP2.chargeAmount = 1;
            }

            //if player 2 dodges when player 1 dodges
            else if (gamepadControlsP2.dodged == true)
            {
                //resets player 2 for next beat
                gamepadControlsP2.dodged = false;
            }

            //if player 2 charges when player 1 dodges
            else if (gamepadControlsP2.charged == true)
            {
                //resets player 2 for next beat
                gamepadControlsP2.charged = false;
            }

            //if player 2 misses the beat when player 1 dodges
            else if (gamepadControlsP2.attacked == false && gamepadControlsP2.dodged == false && gamepadControlsP2.charged == false)
            {
                //player 2 dodge delay goes down by 1 if higher than 0
                if (gamepadControlsP2.dodgeDelay >= 1)
                {
                    gamepadControlsP2.dodgeDelay -= 1;
                }
            }
        }

        //if player 1 charges
        else if (gamepadControlsP1.charged == true)
        {
            //resets player 1 for next beat
            gamepadControlsP1.charged = false;

            //if player 2 attacks when player 1 charges
            if (gamepadControlsP2.attacked == true)
            {
                //player 2 takes damage
                healthP1.health -= gamepadControlsP2.chargeAmount;
                gamepadControlsP2.playerAnimations.Play("BlueDamaged");

                //player 1 reset charge amount
                gamepadControlsP1.chargeAmount = 1;

                //reset player 2 for next beat
                gamepadControlsP2.attacked = false;

                //player 2 reset charge amount
                gamepadControlsP2.chargeAmount = 1;
            }

            //if player 2 dodges when player 1 charges
            else if (gamepadControlsP2.dodged == true)
            {
                //resets player 2 for next beat
                gamepadControlsP2.dodged = false;
            }

            //if player 2 charges when player 1 charges
            else if (gamepadControlsP2.charged == true)
            {
                //resets player 2 for next beat
                gamepadControlsP2.charged = false;
            }

            //if player 2 misses the beat when player 1 charges
            else if (gamepadControlsP2.attacked == false && gamepadControlsP2.dodged == false && gamepadControlsP2.charged == false)
            {
                //player 2 dodge delay goes down by 1 if higher than 0
                if (gamepadControlsP2.dodgeDelay >= 1)
                {
                    gamepadControlsP2.dodgeDelay -= 1;
                }
            }
        }

        //if player 2 attacks when player 1 misses
        else if (gamepadControlsP2.attacked == true)
        {
            //resets player 2 for next beat
            gamepadControlsP2.attacked = false;

            //if player 1 misses when player 2 attacks
            if (gamepadControlsP1.attacked == false && gamepadControlsP1.dodged == false && gamepadControlsP1.charged == false)
            {
                //player 1 takes damage
                healthP1.health -= gamepadControlsP2.chargeAmount;
                gamepadControlsP1.playerAnimations.Play("RedDamaged");

                //player 1 reset charge amount
                gamepadControlsP1.chargeAmount = 1;

                //player 1 dodge delay goes down by 1 if higher than 0
                if (gamepadControlsP1.dodgeDelay >= 1)
                {
                    gamepadControlsP1.dodgeDelay -= 1;
                }
            }

            //player 2 reset charge amount
            gamepadControlsP2.chargeAmount = 1;
        }

        //if player 2 dodges when player 1 misses
        else if (gamepadControlsP2.dodged == true)
        {
            //resets player 2 for next beat
            gamepadControlsP2.dodged = false;

            //if player 1 misses when player 2 dodges
            if (gamepadControlsP1.attacked == false && gamepadControlsP1.dodged == false && gamepadControlsP1.charged == false)
            {
                //player 1 dodge delay goes down by 1 if higher than 0
                if (gamepadControlsP1.dodgeDelay >= 1)
                {
                    gamepadControlsP1.dodgeDelay -= 1;
                }
            }
        }

        //if player 2 charges when player 1 misses
        else if (gamepadControlsP2.charged == true)
        {
            //resets player 2 for next beat
            gamepadControlsP2.charged = false;

            //if player 1 misses when player 2 charges
            if (gamepadControlsP1.attacked == false && gamepadControlsP1.dodged == false && gamepadControlsP1.charged == false)
            {
                //player 1 dodge delay goes down by 1 if higher than 0
                if (gamepadControlsP1.dodgeDelay >= 1)
                {
                    gamepadControlsP1.dodgeDelay -= 1;
                }
            }
        }
    }
}
