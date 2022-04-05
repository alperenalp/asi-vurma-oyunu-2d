using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score=0;
    public GameObject player;
    public AudioSource ses;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Dusman")
        {
            score += 1;
            scoreText.text = "Score: "+score.ToString();
            ses.Play();
        }
    }
}
