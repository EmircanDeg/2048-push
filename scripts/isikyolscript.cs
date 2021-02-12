using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isikyolscript : MonoBehaviour
{
    public GameObject player;
    float sayac = 0;
    public GameObject efektler;
    bool oldumu = false;
    GameObject karakter;
    public GameObject gocikar;
    public Vector3 vektor;
    public AudioSource duduksesi;
    public AudioSource kosmases;
    void Start()
    {
        player.GetComponent<playerhareket>().hiz = 0;
        karakter = GameObject.FindGameObjectWithTag("karakter");
        karakter.GetComponent<Animator>().speed = 0;
        Invoke("go", 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oldumu == false) {
            sayac = sayac + Time.deltaTime;
            if (sayac > 2)
            {
                if (player.GetComponent<playerhareket>().hiz > -8)
                {
                    karakter.GetComponent<Animator>().speed = 1;
                    player.GetComponent<playerhareket>().hiz = player.GetComponent<playerhareket>().hiz - Time.deltaTime*3;
                    
                }
                if (player.GetComponent<playerhareket>().hiz < -5) {  }
            }
        }
        if (player.GetComponent<playerhareket>().hiz < -8) { oldumu = true; }
        if (oldumu == true) { player.GetComponent<playerhareket>().hiz = -8; efektler.SetActive(true); }
        
    }

    void go() { Instantiate(gocikar, vektor, transform.rotation);Debug.Log("GO");kosmases.Play(); }
    void ses() { duduksesi.Play(); }
}
