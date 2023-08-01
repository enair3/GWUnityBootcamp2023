using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeDecider : MonoBehaviour
{
    public GameObject player1; //set in inspector
    public GameObject player2; //set in inspector

    GamepadControls gamepadControlsP1;
    GamepadControls gamepadControlsP2;

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
        //all possible things that could happen
        if (gamepadControlsP1.attacked == true && gamepadControlsP2.attacked == true)
        {
            healthP1.health -= gamepadControlsP2.chargeAmount;
            healthP2.health -= gamepadControlsP1.chargeAmount;

            gamepadControlsP1.attacked = false;
            gamepadControlsP2.attacked = false;

            gamepadControlsP1.chargeAmount = 1;
            gamepadControlsP2.chargeAmount = 1;
        }

        else if (gamepadControlsP1.attacked == true && gamepadControlsP2.dodged == true)
        {
            gamepadControlsP1.attacked = false;
            gamepadControlsP2.dodged = false;
        }

        else if (gamepadControlsP1.attacked == true && gamepadControlsP2.charged == true)
        {
            healthP2.health -= gamepadControlsP1.chargeAmount;

            gamepadControlsP1.attacked = false;
            gamepadControlsP2.charged = false;

            gamepadControlsP1.chargeAmount = 1;
            gamepadControlsP2.chargeAmount = 1;
        }

        else if (gamepadControlsP1.dodged == true && gamepadControlsP2.attacked == true)
        {
            gamepadControlsP1.dodged = false;
            gamepadControlsP2.attacked = false;
        }

        else if (gamepadControlsP1.dodged == true && gamepadControlsP2.dodged == true)
        {
            gamepadControlsP1.dodged = false;
            gamepadControlsP2.dodged = false;
        }

        else if (gamepadControlsP1.dodged == true && gamepadControlsP2.charged == true)
        {
            gamepadControlsP1.dodged = false;
            gamepadControlsP2.charged = false;
        }

        else if (gamepadControlsP1.charged == true && gamepadControlsP2.attacked == true)
        {
            healthP1.health -= gamepadControlsP2.chargeAmount;

            gamepadControlsP1.charged = false;
            gamepadControlsP2.attacked = false;

            gamepadControlsP1.chargeAmount = 1;
            gamepadControlsP2.chargeAmount = 1;
        }

        else if (gamepadControlsP1.charged == true && gamepadControlsP2.dodged == true)
        {
            gamepadControlsP1.charged = false;
            gamepadControlsP2.dodged = false;
        }

        else if (gamepadControlsP1.charged == true && gamepadControlsP2.charged == true)
        {
            gamepadControlsP1.charged = false;
            gamepadControlsP2.charged = false;
        }

        else if (gamepadControlsP1.attacked == true && gamepadControlsP2.attacked == false && gamepadControlsP2.dodged == false && gamepadControlsP2.charged == false)
        {
            healthP2.health -= gamepadControlsP1.chargeAmount;

            gamepadControlsP1.attacked = false;
        }

        else if (gamepadControlsP1.dodged == true && gamepadControlsP2.attacked == false && gamepadControlsP2.dodged == false && gamepadControlsP2.charged == false)
        {
            gamepadControlsP1.dodged = false;
        }

        else if (gamepadControlsP1.charged == true && gamepadControlsP2.attacked == false && gamepadControlsP2.dodged == false && gamepadControlsP2.charged == false)
        {
            gamepadControlsP1.charged = false;
        }

        else if (gamepadControlsP2.attacked == true && gamepadControlsP1.attacked == false && gamepadControlsP1.dodged == false && gamepadControlsP1.charged == false)
        {
            healthP1.health -= gamepadControlsP2.chargeAmount;

            gamepadControlsP2.attacked = false;
        }

        else if (gamepadControlsP2.dodged == true && gamepadControlsP1.attacked == false && gamepadControlsP1.dodged == false && gamepadControlsP1.charged == false)
        {
            gamepadControlsP2.dodged = false;
        }

        else if (gamepadControlsP2.charged == true && gamepadControlsP1.attacked == false && gamepadControlsP1.dodged == false && gamepadControlsP1.charged == false)
        {
            gamepadControlsP2.charged = false;
        }
    }
}
