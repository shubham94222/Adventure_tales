using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private bool isOnMovingObject = false;
    private Transform movingObjectTransform;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MovingObject"))
        {
            isOnMovingObject = true;
            movingObjectTransform = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("MovingObject"))
        {
            isOnMovingObject = false;
            movingObjectTransform = null;
        }
    }

    private void FixedUpdate()
    {
        if (isOnMovingObject && movingObjectTransform != null)
        {
            // Move the player with the moving object
            Vector3 movement = movingObjectTransform.position - transform.position;
            transform.position += movement;
        }
    }
}