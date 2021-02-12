using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uikodlar : MonoBehaviour
{
    public GameObject player;
    public GameObject pausemenu;
    public GameObject karakter;
    public GameObject[] pauselar;
    float hiz;
    int pausemu = 0;
    public bool oyunmu = false;
    public bool anamenu = false;
    public GameObject[] highscor;
    public GameObject[] sesbutons;
    public GameObject settingsayfa;
    public GameObject[] settingbutons;
    
    void Start()
    {
        sesbak();
        sesbutonbak();
        Invoke("karakteribul", 0.2f);
        if (anamenu == true) 
        {
            highscor[0].GetComponent<Text>().text = PlayerPrefs.GetInt("yuksekskor").ToString();
            highscor[1].GetComponent<Text>().text = PlayerPrefs.GetInt("yuksekskor").ToString();
        }
    }

    public void anamenugit() { SceneManager.LoadScene("anamenu"); }
    public void oyungit() { SceneManager.LoadScene("SampleScene"); }
    public void satinalmagit() { SceneManager.LoadScene("satinalma"); }
    public void secmegit() { SceneManager.LoadScene("secimscene"); }

    public void settingac() 
    {
        settingsayfa.GetComponent<Animator>().Play("settingduz");
        settingbutons[0].SetActive(false);
        settingbutons[1].SetActive(true);
    }

    public void settingkapa()
    {
        settingsayfa.GetComponent<Animator>().Play("settingters");
        settingbutons[1].SetActive(false);
        settingbutons[0].SetActive(true);
    }

    public void seskontrol() 
    {
        AudioListener.pause = true;
        PlayerPrefs.SetInt("ses", 1);
        sesbutons[0].SetActive(false);
        sesbutons[1].SetActive(true);
    }

    public void seskontrol2() 
    {
        AudioListener.pause = false;
        PlayerPrefs.SetInt("ses", 0);
        sesbutons[1].SetActive(false);
        sesbutons[0].SetActive(true);
    }

    void sesbutonbak() 
    {
        if (anamenu == true) 
        {
            if(AudioListener.pause == true) { sesbutons[1].SetActive(true); }
            if (AudioListener.pause == false) { sesbutons[0].SetActive(true); }
        }
        
    }

    void sesbak() 
    {
        if (PlayerPrefs.GetInt("ses") == 0) { AudioListener.pause = false; }
        else { AudioListener.pause = true; }
    }

    public void pause() 
    {
        pauselar[0].SetActive(false);
        pauselar[1].SetActive(true);
        hiz = player.GetComponent<playerhareket>().hiz;
        player.GetComponent<playerhareket>().hiz = 0;
        karakter.GetComponent<Animator>().speed = 0;
        pausemenu.SetActive(true);
        pausemu = 1;
    }

    public void resume() 
    {
        pauselar[1].SetActive(false);
        pauselar[0].SetActive(true);
        player.GetComponent<playerhareket>().hiz = hiz;
        karakter.GetComponent<Animator>().speed = 1;
        pausemenu.SetActive(false);
        pausemu = 0;
    }

    void Update()
    {
        
    }

    public void karakteribul() 
    {
        if (oyunmu == true) { karakter = GameObject.FindGameObjectWithTag("karakter"); }
    }
}
