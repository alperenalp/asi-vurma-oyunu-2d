using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerDead")
        {
            Destroy(player.gameObject);
            Time.timeScale = 0f;
        }

        if (GameObject.FindGameObjectWithTag("Player")!=null)
        {
            if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Border")
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}
