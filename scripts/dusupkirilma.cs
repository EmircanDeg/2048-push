using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusupkirilma : MonoBehaviour
{
    public GameObject kirik;
    public AudioSource ses;
    void Start()
    {
        
    }

    public void kirilma() { Instantiate(kirik, transform.position, transform.rotation); Destroy(gameObject); }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ev") { Instantiate(kirik, transform.position, transform.rotation); ses.Play() ; Destroy(gameObject); }
    }
    void Update()
    {
        
    }
}
