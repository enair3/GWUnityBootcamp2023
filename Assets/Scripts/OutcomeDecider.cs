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

    //UI words for player 1 (red)
    [SerializeField] GameObject p1Attack;
    [SerializeField] GameObject p1Dodge;
    [SerializeField] GameObject p1Charge;

    //UI words for player 2 (blue)
    [SerializeField] GameObject p2Attack;
    [SerializeField] GameObject p2Dodge;
    [SerializeField] GameObject p2Charge;

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
                Debug.Log("blue hit 1");
                gamepadControlsP2.playerAnimations.Play("BlueDamaged");

                //resets player 2 for next beat
                gamepadControlsP2.attacked = false;

                //resets player 2 charge amount
                gamepadControlsP2.chargeAmount = 1;

                StartCoroutine(p2Attacked());
                StartCoroutine(p1Attacked());
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
                Debug.Log("blue hit 2");
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
                Debug.Log("blue hit 3");
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

            StartCoroutine(p1Dodged());
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
                Debug.Log("blue hit 4");
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

            StartCoroutine(p1Charged());
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

    IEnumerator p1Attacked()
    {
        p1Attack.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        p1Attack.SetActive(false);
    }

    IEnumerator p1Dodged()
    {
        p1Dodge.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        p1Dodge.SetActive(false);
    }

    IEnumerator p1Charged()
    {
        p1Charge.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        p1Charge.SetActive(false);
    }

    IEnumerator p2Attacked()
    {
        p2Attack.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        p2Attack.SetActive(false);
    }

    IEnumerator p2Dodged()
    {
        p2Dodge.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        p2Dodge.SetActive(false);
    }

    IEnumerator p2Charged()
    {
        p2Charge.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        p2Charge.SetActive(false);
    }
}
