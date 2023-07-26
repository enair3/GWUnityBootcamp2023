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
            healthP1.health -= 1;
            healthP2.health -= 1;
            gamepadControlsP1.attacked = false;
            gamepadControlsP2.attacked = false;
        }

        else if (gamepadControlsP1.attacked == true && gamepadControlsP2.dodged == true)
        {
            gamepadControlsP1.attacked = false;
            gamepadControlsP2.dodged = false;
        }

        else if (gamepadControlsP1.attacked == true && gamepadControlsP2.stalled == true)
        {
            healthP2.health -= 1;
            gamepadControlsP1.attacked = false;
            gamepadControlsP2.stalled = false;
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

        else if (gamepadControlsP1.dodged == true && gamepadControlsP2.stalled == true)
        {
            gamepadControlsP1.dodged = false;
            gamepadControlsP2.stalled = false;
        }

        else if (gamepadControlsP1.stalled == true && gamepadControlsP2.attacked == true)
        {
            healthP1.health -= 1;
            gamepadControlsP1.stalled = false;
            gamepadControlsP2.attacked = false;
        }

        else if (gamepadControlsP1.stalled == true && gamepadControlsP2.dodged == true)
        {
            gamepadControlsP1.stalled = false;
            gamepadControlsP2.dodged = false;
        }

        else if (gamepadControlsP1.stalled == true && gamepadControlsP2.stalled == true)
        {
            gamepadControlsP1.stalled = false;
            gamepadControlsP2.stalled = false;
        }
    }
}
