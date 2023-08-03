using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    // Button Click SFX Variables

    public BGmusic BGmusic;
    
    public AudioSource buttonClick;
    //public AudioClip clip;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Battle Scene")
            BGmusic.instance.GetComponent<AudioSource>().Pause();

        /*if (SceneManager.GetActiveScene().name == "Menu")
            BGmusic.instance.GetComponent<AudioSource>().Play();*/
    }

    // Remember to add scenes to the build settings or it won't work!

    // menu and tutorial screen switch
    public void playGame()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Battle Scene");
        Time.timeScale = 1f;
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
        buttonClick.Play();
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
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

    public void goToTutorialPage3()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Tutorial Page 3");
    }

    public void goToTutorialPage4()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Tutorial Page 4");
    }

    public void goToTutorialPage5()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Tutorial Page 5");
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