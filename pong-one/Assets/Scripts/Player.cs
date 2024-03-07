using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float paddleSpeed = 15;
    public KeyCode upKey;
    public KeyCode downKey;

void Update()
{
    // Move the paddle up if the upKey is pressed
    if (Input.GetKey(upKey))
    {
        transform.Translate(Vector3.up * paddleSpeed * Time.deltaTime);
    }

    // Move the paddle down if the downKey is pressed
    if (Input.GetKey(downKey))
    {
        transform.Translate(Vector3.down * paddleSpeed * Time.deltaTime);
    }

}
}
