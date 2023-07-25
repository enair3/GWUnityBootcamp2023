using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeDecider : MonoBehaviour
{
    public GameObject player2;
    GamepadControls gamepadControls2;

    public GameObject player1;
    GamepadControls gamepadControls;

    // Start is called before the first frame update
    void Start()
    {
        player2 = GameObject.Find("Player2");
        gamepadControls2 = player2.GetComponent<GamepadControls>();

        player1 = GameObject.Find("Player1");
        gamepadControls = player1.GetComponent<GamepadControls>();
    }

    // Update is called once per frame
    void Update()
    {
        while (gamepadControls.attacked == true)
        {
            gamepadControls.attacked = false;
        }

        while (gamepadControls.dodged == true)
        {
            gamepadControls.dodged = false;
        }

        while (gamepadControls.stalled == true)
        {
            gamepadControls.stalled = false;
        }
    }
}
