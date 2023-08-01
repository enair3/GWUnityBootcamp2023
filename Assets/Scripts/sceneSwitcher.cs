using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    // Button Click SFX Variables
    public AudioSource source;
    public AudioClip clip;

    // Remember to add scenes to the build settings or it won't work!

    public void playGame()
    {
        source.PlayOneShot(clip);
        // System.Threading.Thread.Sleep(1000);
        SceneManager.LoadScene("Battle Scene");
    }
    public void howToPlay() {
        SceneManager.LoadScene("How to Play");
    }
    public void quitGame() {
        Application.Quit();
    }
    public void goToMainMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void goToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void player1Wins()
    {
        SceneManager.LoadScene("Player1Win");
    }

    public void player2Wins()
    {
        SceneManager.LoadScene("Player2Win");
    }
}