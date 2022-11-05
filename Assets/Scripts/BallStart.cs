using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
  
    SpriteRenderer srBall;
    Rigidbody2D rbBall;

    [SerializeField]
    Sprite[] balls;

    private void Start()
    {
        srBall = transform.GetComponent<SpriteRenderer>();
        rbBall = transform.GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        int randomNumber = UnityEngine.Random.Range(0, 5);
        srBall.sprite = balls[randomNumber];
        rbBall.velocity = Vector3.up * 6;
       
    }
}
