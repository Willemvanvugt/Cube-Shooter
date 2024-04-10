using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    public static string playerNameInput;
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Scene 1 was loaded.");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Game was restarted.");
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

    public void ReadStringInput(string playerNameString)
    {
        playerNameInput = playerNameString;
        Debug.Log("Player name is " + playerNameString);
    }
}
