using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditController : MonoBehaviour
{
    public Button buttonGithub;
    public Button buttonLinkedIn;
    public Button buttonMail;
    public Button buttonMainMenu;

    private void Start()
    {
        buttonMainMenu.onClick.AddListener(MainMenu);
        buttonGithub.onClick.AddListener(openGit);
        buttonLinkedIn.onClick.AddListener(openLinkedin);
        buttonMail.onClick.AddListener(sendEmail);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void openGit()
    {
        Application.OpenURL("https://github.com/MHasanudin");
    }

    public void openLinkedin()
    {
        Application.OpenURL("https://linkedin.com/in/mhhasanudin/");
    }

    public void sendEmail()
    {
        string mail = "mhhasanudin22@gmail.com";
        string subject = "Subject Test Game Pong";
        string body = "Hasan, Game-mu keren dan Kamu tampan, hehe....";

        string mailTo = "mailTo:" + mail + "?subject=" + subject + "&body=" + body;

        Application.OpenURL(mailTo);
    }
}
