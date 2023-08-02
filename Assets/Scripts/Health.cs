using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health; //set in Inspector
    public string winScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("playerDies", 1);
    }

    void playerDies()
    {
        if (health <= 0) //when player loses all health, destroy player
        {
            SceneManager.LoadScene(winScreen);
        }
    }
}
