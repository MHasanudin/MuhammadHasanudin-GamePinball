using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuUIController : MonoBehaviour
{
    public Button resumeButton;
    public Button mainMenuButton;

    public Button pauseButton;
    public GameObject pauseCanvas;

    private void Start()
    {
        resumeButton.onClick.AddListener(Resume);
        mainMenuButton.onClick.AddListener(MainMenu);
        pauseButton.onClick.AddListener(PauseMenu);
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        pauseCanvas.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseMenu()
    {
        Time.timeScale = 0f;
        pauseCanvas.SetActive(true);
    }
}
