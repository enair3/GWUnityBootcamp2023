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
        SceneManager.LoadScene("test");
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
}