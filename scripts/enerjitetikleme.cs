using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enerjitetikleme : MonoBehaviour
{
    GameObject player;
    GameObject tetikleyici;
    public GameObject[] yemeks;
    int sec;
    int lane;
    int yemekmi;
    void Start()
    {
        player = GameObject.Find("player");
        tetikleyici = GameObject.Find("enerjitetikleyici");
    }

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<playerhareket>().hiz = player.GetComponent<playerhareket>().hiz - 0.075f;
        player.GetComponent<playerhareket>().enerjiayar(1);
        tetikleyici.transform.position = new Vector3(40, 0,17);
        yemekmi = Random.Range(1, 15);
        if(yemekmi < 6) 
        {
            sec = Random.Range(0, yemeks.Length);
            lane = Random.Range(0, 2);
            if (lane == 0) { Instantiate(yemeks[sec], new Vector3(-3, 0.5f, 60), transform.rotation); }
            if (lane == 1) { Instantiate(yemeks[sec], new Vector3(0, 0.5f, 60), transform.rotation); }
            if (lane == 2) { Instantiate(yemeks[sec], new Vector3(3, 0.5f, 60), transform.rotation); }
        }
    }
    void Update()
    {
        
    }
}
