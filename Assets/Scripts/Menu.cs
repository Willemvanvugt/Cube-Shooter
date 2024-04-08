using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuCanvas; //Game object containing the Resume and Menu buttons.
    public KeyCode menuButton; //Key for displaying the menu.

    private void Update()
    {
        if(Input.GetKeyDown(menuButton))
        {
            PauseGame();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Scene 1 was loaded.");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Scene 0 was loaded.");
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        menuCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        menuCanvas.SetActive(false);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        Debug.Log("Game was exited.");
#else
        Application.Quit();
#endif
    }
}
