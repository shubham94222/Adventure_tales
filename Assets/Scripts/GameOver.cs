using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text pointsText;
    // Start is called before the first frame update
   public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "POINTS";
    }
}
