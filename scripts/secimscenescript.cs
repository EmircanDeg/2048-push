using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secimscenescript : MonoBehaviour
{
    public GameObject[] karakters;
    public GameObject[] butons;
    public GameObject havayfisek;
    public Vector3 vektor;
    public AudioSource sagsolses;
    public AudioSource secimses;
    void Start()
    {
        karakters[PlayerPrefs.GetInt("secimscene")].SetActive(true);
        butons[PlayerPrefs.GetInt("secimscene")].SetActive(true);
        PlayerPrefs.SetInt("ailkadam", 1);
    }

    public void ileri() 
    {
        sagsolses.Play();
        if (PlayerPrefs.GetInt("secimscene") == 34) 
        { 
            PlayerPrefs.SetInt("secimscene", 0);
            karakters[0].SetActive(true);
            karakters[34].SetActive(false);

            if (PlayerPrefs.GetInt(butons[PlayerPrefs.GetInt("secimscene")].GetComponent<onayaktiflemescript>().prefadi) == 1) { butons[0].SetActive(true); }
            
            butons[34].SetActive(false);
        }
        else 
        { 
            PlayerPrefs.SetInt("secimscene", PlayerPrefs.GetInt("secimscene") + 1);
            karakters[PlayerPrefs.GetInt("secimscene") - 1].SetActive(false);
            karakters[PlayerPrefs.GetInt("secimscene")].SetActive(true);
            butons[PlayerPrefs.GetInt("secimscene") - 1].SetActive(false);
            if (PlayerPrefs.GetInt(butons[PlayerPrefs.GetInt("secimscene")].GetComponent<onayaktiflemescript>().prefadi) == 1) { butons[PlayerPrefs.GetInt("secimscene")].SetActive(true); }
                
        }
    }

    public void geri() 
    {
        sagsolses.Play();
        if (PlayerPrefs.GetInt("secimscene") == 0)
        {
            PlayerPrefs.SetInt("secimscene", 34);
            karakters[0].SetActive(false);
            karakters[34].SetActive(true);
            butons[0].SetActive(false);
            if (PlayerPrefs.GetInt(butons[PlayerPrefs.GetInt("secimscene")].GetComponent<onayaktiflemescript>().prefadi) == 1) { butons[34].SetActive(true); }
           
        }
        else
        {
            PlayerPrefs.SetInt("secimscene", PlayerPrefs.GetInt("secimscene") - 1);
            karakters[PlayerPrefs.GetInt("secimscene") + 1].SetActive(false);
            karakters[PlayerPrefs.GetInt("secimscene")].SetActive(true);
            butons[PlayerPrefs.GetInt("secimscene") + 1].SetActive(false);
            if (PlayerPrefs.GetInt(butons[PlayerPrefs.GetInt("secimscene")].GetComponent<onayaktiflemescript>().prefadi) == 1) { butons[PlayerPrefs.GetInt("secimscene")].SetActive(true); }
        }
    }

    public void secimonay() 
    {
        secimses.Play();
        Instantiate(havayfisek, vektor, transform.rotation);
        karakters[PlayerPrefs.GetInt("secimscene")].GetComponent<Animator>().Play("secilme");
        PlayerPrefs.SetInt("karaktersecim", PlayerPrefs.GetInt("secimscene"));
    }
    void Update()
    {
        
    }
}
