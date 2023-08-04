using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxSong : MonoBehaviour
{
    public float hardSong = 3;
    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
        if(Input.GetKeyDown("c") && hardSong !=3)
        {
            hardSong = 3;
        }else if(Input.GetKeyDown("c") && hardSong == 3)
        {
            hardSong = 1;
        }
    }
}
