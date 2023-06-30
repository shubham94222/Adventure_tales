using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinPick : MonoBehaviour
{
    public int score = 0;
    public int pointsPerPickup = 10;
    public Text scoreText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Points"))
        {
            score += pointsPerPickup;
            Destroy(collision.gameObject);
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text =  score.ToString();
    }
    
}
