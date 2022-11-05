using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;
    public int score=0;

    
    void Update()
    {
        scoreText.text = score.ToString();

        if (PlayerPrefs.GetInt("bestScore") < score)
        {
            PlayerPrefs.SetInt("bestScore",score);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }
}
