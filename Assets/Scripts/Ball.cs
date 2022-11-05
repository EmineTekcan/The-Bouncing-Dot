using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour
{
    Rigidbody2D rbBall;
    [SerializeField]
    float jumpForce;

    SpriteRenderer srBall;
    [SerializeField]
    Sprite[] ballColors;
    private GameManager gameManager;

    AudioSource audioSource;

    [SerializeField]
    AudioClip clipD,clipY;

 

    void Start()
    {
        rbBall = transform.GetComponent<Rigidbody2D>();
        srBall = transform.GetComponent<SpriteRenderer>();
        audioSource = transform.GetComponent<AudioSource>();
        randomBall(3);
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    
    public void randomBall(int index)
    {
        switch (index)
        {
            case 0:
                srBall.sprite = ballColors[0];
                gameObject.tag = "Red";
                break;
            case 1:
                srBall.sprite = ballColors[1];
                gameObject.tag = "Yellow";
                break;
            case 2:
                srBall.sprite = ballColors[2];
                gameObject.tag = "Purple";
                break;
            case 3:
                srBall.sprite = ballColors[3];
                gameObject.tag = "Green";
                break;
            case 4:
                srBall.sprite = ballColors[4];
                gameObject.tag = "Blue";
                break;
            case 5:
                srBall.sprite = ballColors[5];
                gameObject.tag = "Orange";
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == gameObject.tag )
        {
            audioSource.PlayOneShot(clipD);
            gameManager.score += 1;
            rbBall.velocity = Vector3.up * jumpForce;
            int randomNumber = UnityEngine.Random.Range(0,5);
            randomBall(randomNumber);
           

        }
  
        else
        {
            audioSource.PlayOneShot(clipY);
            gameManager.restartGame();
        }
       
    }

}
