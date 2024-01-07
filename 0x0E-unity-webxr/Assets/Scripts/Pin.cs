using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isKnockedOver = false;
    public ScoreManager scoreManager;
    void OnCollisionEnter(Collision collision)
    {
        if (!isKnockedOver && collision.collider.CompareTag("Player"))
        {
            float angleThreshold = 45f;
            float angle = Vector3.Angle(Vector3.up, transform.up);

            if (angle > angleThreshold)
            {
                isKnockedOver = true;
                scoreManager.IncrementScore(1);
            }
        }

        if (!isKnockedOver && collision.collider.CompareTag("pins"))
        {
            isKnockedOver = true;
            scoreManager.IncrementScore(1);
        }
    }
}
