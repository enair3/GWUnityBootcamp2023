using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongEndsPlayerWins : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject musicObject;

    Health healthP1;
    Health healthP2;

    MusicSync musicScript;

    public string player1Win;
    public string player2Win;
    public string noWin;

    // Start is called before the first frame update
    void Awake()
    {
        healthP1 = player1.GetComponent<Health>();
        healthP2 = player2.GetComponent<Health>();

        musicScript = musicObject.GetComponent<MusicSync>();
    }

    // Update is called once per frame
    void Update()
    {
        if (musicScript.songOver == true)
        {
            if (healthP1.health > healthP2.health)
            {
                SceneManager.LoadScene(player1Win);
            }

            else if (healthP2.health > healthP1.health)
            {
                SceneManager.LoadScene(player2Win);
            }

            else
            {
                SceneManager.LoadScene(noWin);
            }
        }
    }
}
