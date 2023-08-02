using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    // Button Click SFX Variables
    
    public AudioSource buttonClick;
    //public AudioClip clip;

    // Remember to add scenes to the build settings or it won't work!

    // menu and tutorial screen switch
    public void playGame()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Battle Scene");
    }
    public void howToPlay() {
        buttonClick.Play();
        SceneManager.LoadScene("How to Play");
    }
    public void quitGame() {
        buttonClick.Play();
        Application.Quit();
    }
    public void goToMainMenu() {
        //buttonClick.Play();
        SceneManager.LoadScene("Menu");
    }

    public void goToCredits() {
        buttonClick.Play();
        SceneManager.LoadScene("Credits");
    }
    public void goToMoreInfo()
    {
        buttonClick.Play();
        SceneManager.LoadScene("More Info");
    }

    public void goToTutorialPage1()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Tutorial Page 1");
    }

    public void goToTutorialPage2()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Tutorial Page 2");
    }

    // win screen switch
    public void player1Wins()
    {
        SceneManager.LoadScene("Player1Win");
    }

    public void player2Wins() {
        SceneManager.LoadScene("Player2Win");
    }
}