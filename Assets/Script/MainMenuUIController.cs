using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        optionsButton.onClick.AddListener(Options);
        exitButton.onClick.AddListener(ExitGame);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("PinballGame");
    }

    public void Options()
    {
        SceneManager.LoadScene("Credit");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
