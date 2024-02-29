using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TriggerRampController : MonoBehaviour
{
    public float score;

    public Collider bola;
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            //add score
            scoreManager.AddScore(score);
        }
    }
}
