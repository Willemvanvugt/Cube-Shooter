using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public KeyCode menuButton; //Key for displaying the menu.
    public GameObject menuParent; //Game object containing the Resume and Menu buttons.
    public GameObject reticleImage; //Game object containing the reticle image.
    public PlayerController playerController;

    private void Start() //Enables the game mode when starting the game.
    {
        GameMode(); //ABSTRACTION
        Debug.Log("Game was started.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(menuButton))
        {
            Debug.Log("Menu button was pressed.");
            PauseGame(); //ABSTRACTION
        }

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        menuParent.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        reticleImage.SetActive(false);
        playerController.enabled = false;
        Debug.Log("Game was paused.");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        menuParent.SetActive(false);
        GameMode();
        Debug.Log("Game was resumed.");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Scene 0 was loaded.");
    }

    private void GameMode()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        reticleImage.SetActive(true);
        playerController.enabled = true;
        Debug.Log("Game mode was enabled.");
    }
}
