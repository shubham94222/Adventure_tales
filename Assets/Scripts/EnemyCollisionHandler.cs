using UnityEngine;

public class EnemyCollisionHandler : MonoBehaviour
{
    public float disableGravityDuration = 1f;

    private Rigidbody rb;
    private bool isCollidingWithPlayer = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isCollidingWithPlayer = true;
            rb.useGravity = false;

            Invoke("EnableGravity", disableGravityDuration);
        }
    }

    private void EnableGravity()
    {
        if (isCollidingWithPlayer)
        {
            rb.useGravity = true;
            isCollidingWithPlayer = false;
        }
    }
}

