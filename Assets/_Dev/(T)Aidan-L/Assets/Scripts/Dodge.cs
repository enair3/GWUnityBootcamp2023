using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dodge : MonoBehaviour
{
    public bool dodged;

    PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Fighting.Dodge.performed += ctx => DoesDodge();
    }

    void DoesDodge()
    {
        dodged = true;
        Debug.Log("does dodge");
    }

    void OnEnabled()
    {
        controls.Fighting.Enable();
    }

    void OnDisabled()
    {
        controls.Fighting.Disable();
    }
}
