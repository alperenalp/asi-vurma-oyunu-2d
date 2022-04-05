using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnHaraket : MonoBehaviour
{
    public float hiz;
    private float yonKlavye;
    private float yonButon;
    private void Update()
    {
        //player'i butonlar ile haraket ettirme
        transform.position += new Vector3(yonButon * hiz, 0, 0) * Time.deltaTime;


        //player'i klavye ile haraket ettirme
        if (Input.GetAxisRaw("Horizontal") == -1) //yatay tuslara basildiginda -1 ile 1 arasýnda sol ve sag seklinde deger donuyor 
        {
            yonKlavye = -1;
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            yonKlavye = +1;
        }
        else
        {
            yonKlavye = 0;
        }
        transform.position += new Vector3(yonKlavye * hiz, 0, 0) * Time.deltaTime * 1;

    }

    public void goLeft()  // mobil versyon uyumlu butonlara basýldýðýnda bu metodlar çalýþtýrýlýyor.
    {
        yonButon = -1;
    }
    public void goRight()
    {
        yonButon = 1;
    }
    public void Stop()
    {
        yonButon = 0;
    }
}
