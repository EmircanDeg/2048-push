using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evcikariciscript : MonoBehaviour
{
    public GameObject[] evler;
    int secim;
    void Start()
    {
        
    }

    public void evcikar() 
    {
        secim = Random.Range(0, evler.Length);
        Instantiate(evler[secim], transform.position, transform.rotation);
    
    }
    void Update()
    {
        
    }
}
