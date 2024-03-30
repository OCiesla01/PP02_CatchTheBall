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

    private Score scoreManager;

    public float ballsAmount;
    public float ballsRequiredToPass;
    public bool isGameActive = false;
    public bool isLevelPassed = false;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Box").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();

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
            isLevelPassed = true;
        }
        else if (scoreManager.score < ballsRequiredToPass)
        {
            scoreText.color = Color.white;
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

    void LevelPassed()
    {
        if (isGameActive && isLevelPassed)
        {
            Debug.Log("Level Passed");
        }
    }
}
