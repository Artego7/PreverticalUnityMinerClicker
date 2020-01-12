using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [SerializeField]
    GameObject mainMenu;
    [SerializeField]
    GameObject optionsMenu;
    public static bool gameIsPaused = false;
    private void Awake()
    {
        Time.timeScale = 0f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Resume()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    void Pause()
    {
        mainMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
