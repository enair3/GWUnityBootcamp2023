using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    public void playGame()
    {
        // Replace "test" with your scene
        // Make sure it's in "Scenes in build" File > Build Settings > and add the scene
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

    public void goToMoreInfo()
    {
        SceneManager.LoadScene("More Info");
    }

    public void goToTutorialPage1()
    {
        SceneManager.LoadScene("Tutorial Page 1");
    }

    public void goToTutorialPage2()
    {
        SceneManager.LoadScene("Tutorial Page 2");
    }
}