using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerhareket : MonoBehaviour
{
    int yol = 0;
    Vector3 sol, orta, sag;
    int hareket = 0;
    public GameObject[] itilenler;
    public float hiz;
    int enerji = 50;
    public GameObject enerjitext;
    float cikarsinn = 0;
    public int puan = 0;
    public GameObject puantext;
    public GameObject karakter;
    bool oldu = false;
    public GameObject[] bar;
    public GameObject[] textler;
    public GameObject gameovermenu;


    private void Awake()
    {
        PlayerPrefs.SetInt("ikssayac", 01);
        karakter = GameObject.FindGameObjectWithTag("karakter");
        puantext.GetComponent<Text>().text = puan.ToString();
        PlayerPrefs.SetInt("cikarsin", 0);
        PlayerPrefs.SetInt("kombo", 10);
        PlayerPrefs.SetInt("kacinci", 0);
        enerjitext.GetComponent<Text>().text = enerji.ToString();
    }
    void Start()
    {
        Invoke("karakteral", 2);
        sol = new Vector3(-3, 0.505f, -5);
        orta = new Vector3(0, 0.505f, -5);
        sag = new Vector3(3, 0.505f, -5);
    }

    public void puanyaz() { puantext.GetComponent<Text>().text = puan.ToString(); puantext.GetComponent<Animator>().Play("puananim"); Invoke("animsifirlapuan", 0.2f); }

    void animsifirlapuan() { puantext.GetComponent<Animator>().Play("default"); }

    public void enerjiayar(int enerj) 
    {
        if (enerji - enerj > 50) { enerji = 50; }
        if (enerji + enerj < 0) { enerji = 0; }
        else { enerji = enerji - enerj; }
        if (enerji > 49) { enerjitext.GetComponent<Text>().text = 50.ToString(); }
        else { enerjitext.GetComponent<Text>().text = enerji.ToString(); }
        
        barkontrol();
    }

    void barkontrol() 
    {
        if (enerji > 49) { for (int i = 0; i < bar.Length; i++) { bar[i].SetActive(true); } }
        else {
            for (int i = 0; i < enerji; i++) { bar[i].SetActive(true); }
            for (int i = enerji; i < bar.Length; i++)
            {
                if (i > -1) { bar[i].SetActive(false); }
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (oldu == false) 
        {
            if (SwipeManager.swipeRight) { hareket = 1; }
            if (SwipeManager.swipeLeft) { hareket = -1; }
        }
        
        if (PlayerPrefs.GetInt("cikarsin") == 0) 
        {
            cikarsinn = cikarsinn + Time.deltaTime;
            if (cikarsinn > 0.5f) 
            {
                PlayerPrefs.SetInt("cikarsin", 1);
                cikarsinn = 0;
            }
        }

        if (enerji < 1) 
        {
            if (oldu == false) 
            {
                enerjitext.GetComponent<Text>().text = 0.ToString();
                hiz = 0;
                karakter.GetComponent<Animator>().Play("olmek");
                oldu = true;
                Invoke("gameover", 2.5f);
                textler[0].GetComponent<Text>().text = puan.ToString();
                textler[1].GetComponent<Text>().text = puan.ToString();
            }
        }
        
    }
    void gameover() 
    { 
        gameovermenu.SetActive(true); 
        if(puan > PlayerPrefs.GetInt("yuksekskor")) { PlayerPrefs.SetInt("yuksekskor",puan); }
        PlayerPrefs.SetInt("para",PlayerPrefs.GetInt("para")+puan);
    }
    public void karakteral() { karakter = GameObject.FindGameObjectWithTag("karakter"); }
    private void FixedUpdate()
    {
        if (hareket == 1) 
        {
            if (yol == 0) 
            { 
                if (transform.position.x > 2.99) { hareket = 0;yol = 1;transform.position = new Vector3(3, transform.position.y, transform.position.z);}
                transform.position = Vector3.Lerp(transform.position,sag,0.3f);
            }
            if (yol == 1) { hareket = 0; }
            if (yol == -1) 
            {
                if (transform.position.x > -0.01f) { hareket = 0; yol = 0; transform.position = new Vector3(0, transform.position.y, transform.position.z);}
                transform.position = Vector3.Lerp(transform.position, orta, 0.3f);
            }

        }
        if (hareket == -1)
        {
            if (yol == 0)
            {
                if (transform.position.x < -2.99) { hareket = 0; yol = -1; transform.position = new Vector3(-3, transform.position.y, transform.position.z);}
                transform.position = Vector3.Lerp(transform.position, sol, 0.3f);
            }
            if (yol == 1)
            {
                if (transform.position.x < 0.01f) { hareket = 0; yol = 0; transform.position = new Vector3(0, transform.position.y, transform.position.z); }
                transform.position = Vector3.Lerp(transform.position, orta, 0.3f);
            }
            if (yol == -1){hareket = 0;}


        }
    }
}
