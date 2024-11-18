using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PipeScore"))
        {
            scoreManager.AddScore(1);
        }
    }
}