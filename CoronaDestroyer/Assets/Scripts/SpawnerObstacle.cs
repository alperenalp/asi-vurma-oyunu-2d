using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    void Start()
    {
        InvokeRepeating("Spawn", 0.1f, 0.8f); // basta 0.1 saniye bekledikten sonra her 1 saniye de bir olustur
    }
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);

        Instantiate(obstacle, new Vector3(randomX, 10, 0), transform.rotation);
    }
}
