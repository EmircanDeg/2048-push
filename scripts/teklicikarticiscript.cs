using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teklicikarticiscript : MonoBehaviour
{
    int sec;
    public GameObject[] sayiler;
    void Start()
    {
        sec = Random.Range(0, sayiler.Length);
        Instantiate(sayiler[sec], transform.position, transform.rotation);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
