using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : Paddle
{
    public KeyCode upKey;
    public KeyCode downKey;

    float moveSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    void playerMovement()
    {
        if(Input.GetKey(upKey))
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        if(Input.GetKey(downKey))
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}