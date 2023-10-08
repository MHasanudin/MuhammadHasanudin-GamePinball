using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    public ScoreManager scoreManager;

    public TMP_Text scoreText;

    private void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
