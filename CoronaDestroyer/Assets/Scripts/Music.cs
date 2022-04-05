using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            this.gameObject.SetActive(false);
        }
    }
}
