using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVirus : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //player objesini tagý ile bulduk
    }
    private void OnTriggerEnter2D(Collider2D collision)  //tetiklenme ile obje yakalama
    {
        if (collision.gameObject.tag == "PlayerDead")  // player'in yasaklý bölgesine çarparsa player ölsün oyun bitsin
        {
            Destroy(player.gameObject);  //playeri'i öldür destroy et
            Time.timeScale = 0f;    //oyunu durdur
        }

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Border")  //player'a veya sinirlara carptýysa
        {
            Destroy(this.gameObject);  //bu gameobjeyi yani virüsü yok et.
        }

    }
}
