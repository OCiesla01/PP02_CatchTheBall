using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    private float direction = 1.0f;
    private float bound = 15.0f;
    public bool isActive = false;

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            transform.Translate(Vector3.forward * moveSpeed * direction * Time.deltaTime);
        }
        
        if (transform.position.z >= bound)
        {
            direction = -1.0f;
        }
        else if (transform.position.z <= -bound) 
        {
            direction = 1.0f;
        }
    }
}
