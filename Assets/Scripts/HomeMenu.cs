using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Scene 1 was loaded.");
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