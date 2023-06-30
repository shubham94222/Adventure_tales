using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class fall_die : MonoBehaviour
{
    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -2)
        {
            ShowGameOverUI();
        }
    }
    public void ShowGameOverUI()
    {
        gameOverUI.SetActive(true);
    }
}
