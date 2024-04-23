using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int score;

    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        IncreaseScore();
    }

    void IncreaseScore()
    {
        score += 1;
    }
}
