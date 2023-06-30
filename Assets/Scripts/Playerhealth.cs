using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    public int score = 100;
    public int damage = 1;
    public int Healthincrease = 400;
    public Text scoreText;
    public GameObject Aid;
    public GameObject gameOverUI;

    void Start()
    {
        gameOverUI.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            score = score - damage;
            UpdateScoreText();
        }
        if(score <= 0)
        {
            gameOverUI.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Aid")
        {
            score = score + Healthincrease;
            Destroy(Aid);
            UpdateScoreText();
        }
        if(collision.gameObject.tag == "Capsule")
        {
            gameOverUI.SetActive(true);
        }
    }

   

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }


   


}
