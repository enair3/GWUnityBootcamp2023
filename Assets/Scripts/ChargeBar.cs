using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour
{
    public GameObject player;

    public Slider slider;

    GamepadControls gamepadControls;

    // Start is called before the first frame update
    void Awake()
    {
        gamepadControls = player.GetComponent<GamepadControls>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = gamepadControls.chargeAmount;
    }
}
