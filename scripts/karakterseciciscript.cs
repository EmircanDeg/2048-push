using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterseciciscript : MonoBehaviour
{
    public GameObject[] karakterler;
    int secim;

    private void Awake()
    {
        secim = PlayerPrefs.GetInt("karaktersecim");
        karakterler[secim].SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
