using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D _bouncy;
    private RectTransform _bouncyPos;
    public float speed = 100.0f;
    private Vector2 ResetPos;

    private void Awake()
    {
        _bouncy = GetComponent<Rigidbody2D>();
        _bouncyPos = GetComponent<RectTransform>();        
        ResetPos = _bouncy.transform.localPosition;
    }
    private void Start()
    {

        
    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D ball)
    {
        if (ball.gameObject.CompareTag("Wall"))
        {
            
            if (ball.gameObject.transform.position.y > 0)
            {
                Debug.Log ("bump");
                _bouncy.velocity = Vector2.zero;
                transform.localPosition = new Vector2 (transform.localPosition.x, 550);
            }
            else
            {
                _bouncy.velocity = Vector2.zero;
                transform.localPosition = new Vector2 (transform.localPosition.x, -550);
            }
        }
    }
    public Vector2 AnchorPos()
    {
        return _bouncyPos.anchoredPosition;
    }
    public Vector2 Resetpos()
    {
        return ResetPos;
    }
}