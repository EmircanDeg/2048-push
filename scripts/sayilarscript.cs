using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayilarscript : MonoBehaviour
{
    public int sayi;
    public GameObject[] sayilar;
    public bool gelenmi = false;
    GameObject player;
    public bool ekledi = false;
    public GameObject kirikkup;
    int diziyeri;
    public GameObject[] kupefektler;
    public GameObject[] yemekefektler;
    int efektsecim;
    public GameObject[] kirmaefekt;
    public Vector3[] enbasvektorler;
    public GameObject[] artipuanobje;
    public GameObject carpiobje;
    public GameObject[] iksler;
    GameObject kamera;
    public AudioSource kirilmases;
    public AudioSource kupkirilmases;
    public AudioSource yemeses;
    public AudioSource iyises;
    public AudioSource kotuses;
    public AudioSource sayises;
    int kirildimi = 0;

    void Start()
    {
        kamera = GameObject.Find("denemekamera");
        diziyeri = PlayerPrefs.GetInt("kacinci");
        player = GameObject.Find("player");
        if (gelenmi == false) 
        { 
            gameObject.transform.parent = player.transform;
            if (transform.position.x < 5) 
            {
                if (sayi != 10) { player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")] = gameObject; }
                if (sayi == 10) 
                { 
                    player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")] = gameObject;
                    PlayerPrefs.SetInt("kacinci", PlayerPrefs.GetInt("kacinci") + 1);
                    PlayerPrefs.SetInt("kombo", PlayerPrefs.GetInt("kombo") + 10);
                    Instantiate(sayilar[0], transform.position + new Vector3(0, 0, 1.05f), transform.rotation);
                    Instantiate(kupefektler[0], transform.position + new Vector3(0, 0, 1.05f), transform.rotation);
                    ekledi = true;
                    if (gelenmi == false) 
                    {
                        if (PlayerPrefs.GetInt("ikssayac") > 1)
                        {
                            iksler[PlayerPrefs.GetInt("ikssayac")-1].SetActive(true);
                            iksler[PlayerPrefs.GetInt("ikssayac") - 2].SetActive(false);
                        }
                        PlayerPrefs.SetInt("ikssayac", PlayerPrefs.GetInt("ikssayac") + 1);
                    }
                    
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (gelenmi == false)
        {
            if (collision.gameObject.tag == "sayi")
            {
                if (collision.gameObject.GetComponent<sayilarscript>().gelenmi == true) 
                {
                    if (sayi != 10)
                    {
                        if (collision.gameObject.GetComponent<sayilarscript>().sayi == sayi)
                        {
                            sayises.Play();
                            Instantiate(sayilar[sayi + 1], transform.position, transform.rotation);
                            Instantiate(kupefektler[sayi + 1], transform.position, transform.rotation);
                            Destroy(collision.gameObject);
                            Destroy(gameObject);
                        }
                        if (collision.gameObject.GetComponent<sayilarscript>().sayi != sayi)
                        {
                            /*if(sayi- collision.gameObject.GetComponent<sayilarscript>().sayi > 0) 
                            {
                                Instantiate(sayilar[sayi - collision.gameObject.GetComponent<sayilarscript>().sayi-1], transform.position, transform.rotation);
                                Destroy(gameObject);
                            }
                            if(sayi - collision.gameObject.GetComponent<sayilarscript>().sayi < 0) 
                            { 
                                player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")] = null;
                                player.GetComponent<playerhareket>().hiz = 0;
                                Destroy(gameObject); 
                            }*/
                            kamera.GetComponent<kamerascript>().titret();
                            kupkirilmases.Play();
                            Instantiate(sayilar[0], transform.position, transform.rotation);
                            Instantiate(kupefektler[0], transform.position, transform.rotation);
                            Instantiate(carpiobje, transform.position + new Vector3(0, 1, 0), transform.rotation);
                            Destroy(gameObject);
                            if (collision.gameObject.GetComponent<sayilarscript>().gelenmi == true) { collision.gameObject.GetComponent<sayilarscript>().kupkirilma(); }
                            //collision.gameObject.GetComponent<sayilarscript>().kupkirilma();
                        }
                    }
                }
                
                if (sayi == 10)
                {
                    if (collision.gameObject.GetComponent<sayilarscript>().gelenmi == true)
                    {
                        /*if (ekledi == false)
                        {
                            Instantiate(sayilar[collision.gameObject.GetComponent<sayilarscript>().sayi], transform.position + new Vector3(0, 0, 1.05f), transform.rotation);
                            Destroy(collision.gameObject);
                            ekledi = true;
                        }*/
                        if (ekledi == true)
                        {
                            if (collision.gameObject.GetComponent<sayilarscript>().gelenmi == true) 
                            {
                                Instantiate(carpiobje, transform.position + new Vector3(0, 1, 0), transform.rotation);
                                Invoke("ekstrasyon", 0.1f);
                                collision.gameObject.GetComponent<sayilarscript>().kupkirilma();
                            }
                            
                        }
                    }

                }
            }

            if (collision.gameObject.tag == "kirilacak") 
            {
                
                kirilmases.Play();
                if(sayi< collision.gameObject.GetComponent<kirilacakscript>().sayisi) 
                {
                    kotuses.Play();
                    Instantiate(artipuanobje[2], transform.position + new Vector3(0, 1, 0), transform.rotation);
                    player.GetComponent<playerhareket>().enerjiayar(1 + collision.gameObject.GetComponent<kirilacakscript>().sayisi);
                    kamera.GetComponent<kamerascript>().titret();
                    
                }
                if(sayi>= collision.gameObject.GetComponent<kirilacakscript>().sayisi) 
                {
                    Instantiate(artipuanobje[0],transform.position+new Vector3(0,1,0), transform.rotation);
                    iyises.Play();
                    player.GetComponent<playerhareket>().puan = player.GetComponent<playerhareket>().puan + collision.gameObject.GetComponent<kirilacakscript>().puani*PlayerPrefs.GetInt("kombo");
                    player.GetComponent<playerhareket>().puanyaz();
                }
                Instantiate(kirmaefekt[collision.gameObject.GetComponent<kirilacakscript>().sayisi-2], transform.position + new Vector3(0, 0, 1), transform.rotation);
                collision.gameObject.GetComponent<kirilacakscript>().kirma(); 
                collision.gameObject.GetComponent<BoxCollider>().isTrigger = true;
                
            }
            if (collision.gameObject.tag == "yemek") 
            {
                yemeses.Play();
                Instantiate(artipuanobje[1], transform.position + new Vector3(0, 1, 0), transform.rotation);
                player.GetComponent<playerhareket>().enerjiayar(-collision.gameObject.GetComponent<donmescript>().kacenerji);
                efektsecim = Random.Range(0, yemekefektler.Length);
                Instantiate(yemekefektler[efektsecim], transform.position+new Vector3(0,0,1), transform.rotation);
                Destroy(collision.gameObject) ; 
            }
        }
        if (gelenmi == true) 
        {
            if (collision.gameObject.tag == "kirilacak") { Destroy(collision.gameObject); }
            if (collision.gameObject.tag == "yemek") { Destroy(collision.gameObject); }
        }
    }

    void ekstrasyon() 
    {
        /*Destroy(player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")]);
        Instantiate(sayilar[0], transform.position + new Vector3(0, 0, 1.05f*(PlayerPrefs.GetInt("kacinci")-diziyeri)), transform.rotation);
        player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci") + 1] = null;*/
        if (PlayerPrefs.GetInt("cikarsin") == 1) 
        {
            Destroy(player.GetComponent<playerhareket>().itilenler[PlayerPrefs.GetInt("kacinci")]);
            Instantiate(sayilar[0], enbasvektorler[PlayerPrefs.GetInt("kacinci") + 1] + new Vector3(player.transform.position.x, 0, 0), transform.rotation);
            PlayerPrefs.SetInt("cikarsin", 0);
        }
        
    }
    public void kupkirilma() 
    {
        if (kirildimi==0) 
        {
            kirildimi = 1;
            Instantiate(kirikkup, transform.position, transform.rotation); Destroy(gameObject);
        }  
    }
    void Update()
    {
        
    }
}
