using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Pause menu created with the help of https://www.youtube.com/watch?v=JivuXdrIHK0
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public string Scene;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; //Resume Game Speed
        GameIsPaused = false;
    }

    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Pause Game Speed
        GameIsPaused = true;
    }
    
    public void GotoToMainMenu()
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
