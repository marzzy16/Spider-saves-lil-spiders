using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Little spider run");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("_MainMenu");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
