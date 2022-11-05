using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text bestScoreText;

  
    void Update()
    {
       
        bestScoreText.text = PlayerPrefs.GetInt("bestScore").ToString();
  
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}
