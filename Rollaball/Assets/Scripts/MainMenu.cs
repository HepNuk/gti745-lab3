using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuObj;

    public GameObject CreditsPage;
    public GameObject InstructionPage;

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

    public void GotoCreditsPage()
    {
        CreditsPage.SetActive(true);
        InstructionPage.SetActive(false);
    }

    public void GotoInstructionPage()
    {
        CreditsPage.SetActive(false);
        InstructionPage.SetActive(true);
    }

    public void GotoMainMenu()
    {
        CreditsPage.SetActive(false);
        InstructionPage.SetActive(false);
    }
}
