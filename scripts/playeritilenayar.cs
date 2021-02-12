using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeritilenayar : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
        Invoke("ayarcekme", 1);
    }

    void ayarcekme() 
    {
        PlayerPrefs.SetInt("kacinci", 0);
        PlayerPrefs.SetInt("kombo", 10);
        player.GetComponent<playerhareket>().itilenler[0] = gameObject;
        player.GetComponent<playerhareket>().itilenler[1] = null;
    }
    void Update()
    {
        
    }
}
