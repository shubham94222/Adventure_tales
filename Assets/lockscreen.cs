using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockscreen : MonoBehaviour
{
    private void Start()
    {
        // Lock the cursor to the center of the game window
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; // Optional: hide the cursor
    }

    private void Update()
    {
        // Unlock the cursor by pressing the Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; // Optional: show the cursor
        }
    }
}
