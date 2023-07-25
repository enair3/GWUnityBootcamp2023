using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Stall : MonoBehaviour
{
    public bool stalled;

    PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Fighting.Stall.performed += ctx => DoesStall();
    }

    void DoesStall()
    {
        stalled = true;
        Debug.Log("does stall");
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
