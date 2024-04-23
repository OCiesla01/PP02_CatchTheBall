using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBall : MonoBehaviour
{

    public GameObject ball;
    private GameManager gameManager;

    private float yOffset = 3.0f;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.ballsAmount > 0) 
        {
            CreateDropBall();
        }
    }

    void CreateDropBall()
    {
        Vector3 ballPos = new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z);
        gameManager.ballsAmount -= 1;

        Instantiate(ball, ballPos, transform.rotation);
    }
}
