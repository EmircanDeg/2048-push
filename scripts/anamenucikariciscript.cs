using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anamenucikariciscript : MonoBehaviour
{
    public GameObject[] kutus;
    float sayac = 0;
    float tekrar;
    public float x;
    public float xeksi;
    public float z;
    public float zeksi;
    int sec;
    void Start()
    {
        cikart();
    }

    void cikart() 
    {
        tekrar = Random.Range(0.5f, 2);
        sec = Random.Range(0, kutus.Length);
        Instantiate(kutus[sec], transform.position, transform.rotation);
        transform.position = new Vector3(Random.Range(xeksi, x), transform.position.y, Random.Range(zeksi, z));
        sayac = 0;
    }
    void Update()
    {
        sayac = sayac + Time.deltaTime;
        if (sayac > tekrar) 
        {
            cikart();
        }
    }
}
