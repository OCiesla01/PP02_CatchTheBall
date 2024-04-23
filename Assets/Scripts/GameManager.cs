using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ballsLeftText;
    public GameObject gameOverScreen;
    public GameObject levelCompletedScreen;

    private Score scoreManager;

    public float ballsAmount;
    public float ballsRequiredToPass;
    public bool isGameActive = false;
    private bool isLevelCompleted = false;

    void Start()
    {
        scoreManager = GameObject.Find("Box").GetComponent<Score>();
        isGameActive = true;
    }

    void Update()
    {
        UpdateUI();
        CheckLevelCompletion();

        if (ballsAmount == 0 && scoreManager.score < ballsRequiredToPass && isGameActive)
        {
            GameOver();
        }
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + scoreManager.score + "/" + ballsRequiredToPass;
        ballsLeftText.text = "Balls left: " + ballsAmount;

        if (scoreManager.score >= ballsRequiredToPass)
        {
            scoreText.color = Color.green;
        }
        else if (scoreManager.score < ballsRequiredToPass)
        {
            scoreText.color = Color.white;
        }
    }

    void CheckLevelCompletion()
    {
        if (scoreManager.score >= ballsRequiredToPass && !isLevelCompleted)
        {
            isLevelCompleted = true;
            LevelPassed();
        }
        else if (scoreManager.score < ballsRequiredToPass && isLevelCompleted)
        {
            isLevelCompleted = false;
            LevelPassed();
        }
    }

    void LevelPassed()
    {
        if (isGameActive && isLevelCompleted)
        {
            levelCompletedScreen.SetActive(true);
        }
        else
        {
            levelCompletedScreen.SetActive(false);
        }
    }

    void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("GameScene");
    }
   
    public void BackToMenu()
    {
        SceneManager.LoadScene("GameScene");
    }
}
