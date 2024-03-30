using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int score;
    // Start is called before the first frame update
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
