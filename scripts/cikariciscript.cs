using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cikariciscript : MonoBehaviour
{
    public GameObject[] cikacak;
    public GameObject sonkutu;
    int secim;
    public GameObject sahtesayi;
    GameObject player;
    int hangi;
    void Start()
    {
        player = GameObject.Find("player");
        
    }

    public void cikart()
    {
        hangi = Random.Range(0, 8);
        secim = Random.Range(0, 10);
        if (hangi > 3) { Instantiate(cikacak[secim], transform.position, transform.rotation); }
        if (hangi == 3) { Instantiate(sonkutu, transform.position, transform.rotation); }
        if (hangi <3) { Instantiate(sahtesayi, transform.position, transform.rotation); }

    }
    void Update()
    {
        if (player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")] != null) 
        {
            if (player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")].GetComponent<sayilarscript>().sayi < 10)
            {
                sonkutu = cikacak[player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")].GetComponent<sayilarscript>().sayi];
            }
            if (player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")].GetComponent<sayilarscript>().sayi == 10) { sonkutu = cikacak[0]; }
            /*if (player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")].GetComponent<sayilarscript>().sayi == 9) { sonkutu = cikacak[4]; }*/
        }
        


    }
}
