using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{

    private Button button;
    private GameManager gameManager;
    private BoxMove boxMove;
    public GameObject levelUI;
    public GameObject mainMenuUI;

    public float ballsAmount;
    public float ballsRequiredToPass = 99;
    public float boxMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        boxMove = GameObject.Find("Box").GetComponent<BoxMove>();

        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonClick()
    {
        gameManager.ballsAmount = ballsAmount;
        gameManager.ballsRequiredToPass = ballsRequiredToPass;
        boxMove.moveSpeed = boxMoveSpeed;

        boxMove.isActive = true;
        gameManager.isGameActive = true;

        levelUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }
}
