using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public string Scene;

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Scene);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Quiting...");
    }
}
