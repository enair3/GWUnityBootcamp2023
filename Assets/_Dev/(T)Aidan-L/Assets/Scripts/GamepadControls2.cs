using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class GamepadControls2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DoesAttack(InputAction.CallbackContext cxt)
    {
        Debug.Log("Attacks");
    }

    public void DoesDodge(InputAction.CallbackContext cxt)
    {
        Debug.Log("Dodged");
    }

    public void DoesStall(InputAction.CallbackContext cxt)
    {
        Debug.Log("Stalled");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
