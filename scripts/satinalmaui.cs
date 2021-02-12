using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class satinalmaui : MonoBehaviour
{
    public GameObject[] kupler;
    public GameObject[] karakterler;
    public GameObject gotit;
    int secim;
    public GameObject buydisi;
    public string[] prefadlar;
    int sifir = 0;
    public GameObject[] paratext;
    void Start()
    {
        if (PlayerPrefs.GetInt("ilktur") == 0) { PlayerPrefs.SetInt("para", 50000);PlayerPrefs.SetInt("ilktur", 1); }
        
        secim = Random.Range(0, karakterler.Length);
        karakterler[secim].SetActive(true);
        herkesacikmi();
        paratext[0].GetComponent<Text>().text = PlayerPrefs.GetInt("para").ToString();
        paratext[1].GetComponent<Text>().text = PlayerPrefs.GetInt("para").ToString();
    }

    public void satinal() 
    {
        if (secim == 0) { secimal();satinal(); }
        if (secim == 1) 
        { 
            if(PlayerPrefs.GetInt("biker")== 1){ secimal(); satinal(); }
            if (PlayerPrefs.GetInt("biker") == 0) { PlayerPrefs.SetInt("biker", 1);kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 2)
        {
            if (PlayerPrefs.GetInt("businessman1") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("businessman1") == 0) { PlayerPrefs.SetInt("businessman1", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 3)
        {
            if (PlayerPrefs.GetInt("businessman2") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("businessman2") == 0) { PlayerPrefs.SetInt("businessman2", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 4)
        {
            if (PlayerPrefs.GetInt("businesswoman") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("businesswoman") == 0) { PlayerPrefs.SetInt("businesswoman", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 5)
        {
            if (PlayerPrefs.GetInt("daughter") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("daughter") == 0) { PlayerPrefs.SetInt("daughter", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 6)
        {
            if (PlayerPrefs.GetInt("fastfoodworker") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("fastfoodworker") == 0) { PlayerPrefs.SetInt("fastfoodworker", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 7)
        {
            if (PlayerPrefs.GetInt("father1") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("father1") == 0) { PlayerPrefs.SetInt("father1", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 8)
        {
            if (PlayerPrefs.GetInt("father2") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("father2") == 0) { PlayerPrefs.SetInt("father2", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 9)
        {
            if (PlayerPrefs.GetInt("femalejacket") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("femalejacket") == 0) { PlayerPrefs.SetInt("femalejacket", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 10)
        {
            if (PlayerPrefs.GetInt("femalepolis") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("femalepolis") == 0) { PlayerPrefs.SetInt("femalepolis", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 11)
        {
            if (PlayerPrefs.GetInt("firefighter") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("firefighter") == 0) { PlayerPrefs.SetInt("firefighter", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 12)
        {
            if (PlayerPrefs.GetInt("gamergirl") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("gamergirl") == 0) { PlayerPrefs.SetInt("gamergirl", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 13)
        {
            if (PlayerPrefs.GetInt("gangster") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("gangster") == 0) { PlayerPrefs.SetInt("gangster", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 14)
        {
            if (PlayerPrefs.GetInt("grandma") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("grandma") == 0) { PlayerPrefs.SetInt("grandma", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 15)
        {
            if (PlayerPrefs.GetInt("grandpa") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("grandpa") == 0) { PlayerPrefs.SetInt("grandpa", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 16)
        {
            if (PlayerPrefs.GetInt("hipstergirl") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("hipstergirl") == 0) { PlayerPrefs.SetInt("hipstergirl", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 17)
        {
            if (PlayerPrefs.GetInt("hipsterguy") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("hipsterguy") == 0) { PlayerPrefs.SetInt("hipsterguy", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 18)
        {
            if (PlayerPrefs.GetInt("hobo") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("hobo") == 0) { PlayerPrefs.SetInt("hobo", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 19)
        {
            if (PlayerPrefs.GetInt("hotdogman") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("hotdogman") == 0) { PlayerPrefs.SetInt("hotdogman", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 20)
        {
            if (PlayerPrefs.GetInt("jock") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("jock") == 0) { PlayerPrefs.SetInt("jock", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 21)
        {
            if (PlayerPrefs.GetInt("malehoodie") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("malehoodie") == 0) { PlayerPrefs.SetInt("malehoodie", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 22)
        {
            if (PlayerPrefs.GetInt("mother") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("mother") == 0) { PlayerPrefs.SetInt("mother", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 23)
        {
            if (PlayerPrefs.GetInt("mother2") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("mother2") == 0) { PlayerPrefs.SetInt("mother2", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 24)
        {
            if (PlayerPrefs.GetInt("paramedic") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("paramedic") == 0) { PlayerPrefs.SetInt("paramedic", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 25)
        {
            if (PlayerPrefs.GetInt("polis") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("polis") == 0) { PlayerPrefs.SetInt("polis", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 26)
        {
            if (PlayerPrefs.GetInt("punkgirl") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("punkgirl") == 0) { PlayerPrefs.SetInt("punkgirl", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 27)
        {
            if (PlayerPrefs.GetInt("punkguy") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("punkguy") == 0) { PlayerPrefs.SetInt("punkguy", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 28)
        {
            if (PlayerPrefs.GetInt("roadworker") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("roadworker") == 0) { PlayerPrefs.SetInt("roadworker", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 29)
        {
            if (PlayerPrefs.GetInt("schoolboy") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("schoolboy") == 0) { PlayerPrefs.SetInt("schoolboy", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 30)
        {
            if (PlayerPrefs.GetInt("schoolgirl") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("schoolgirl") == 0) { PlayerPrefs.SetInt("schoolgirl", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 31)
        {
            if (PlayerPrefs.GetInt("shopkeeper") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("shopkeeper") == 0) { PlayerPrefs.SetInt("shopkeeper", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 32)
        {
            if (PlayerPrefs.GetInt("shopkeepergil") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("shopkeepergil") == 0) { PlayerPrefs.SetInt("shopkeepergil", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 33)
        {
            if (PlayerPrefs.GetInt("summergril") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("summergril") == 0) { PlayerPrefs.SetInt("summergril", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
        if (secim == 34)
        {
            if (PlayerPrefs.GetInt("tourist") == 1) { secimal(); satinal(); }
            if (PlayerPrefs.GetInt("tourist") == 0) { PlayerPrefs.SetInt("tourist", 1); kirdir(); }
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - 50000);
            gotit.SetActive(true);
        }
    }

    public void kirdir() { for (int i = 0; i < kupler.Length; i++) { kupler[i].GetComponent<dusupkirilma>().kirilma(); } }
    void secimal() 
    {
        karakterler[secim].SetActive(false);
        secim = Random.Range(0, karakterler.Length);
        karakterler[secim].SetActive(true);
    }

    void herkesacikmi() 
    { 
        for(int i = 0; i < prefadlar.Length; i++) { sifir = sifir + PlayerPrefs.GetInt(prefadlar[i]); }
        if (sifir > 34) { buydisi.SetActive(false); }
        Debug.Log(sifir);
        if (PlayerPrefs.GetInt("para") < 50000) { buydisi.SetActive(false); }
    }
    void Update()
    {
        
    }
}
