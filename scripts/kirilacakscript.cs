using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirilacakscript : MonoBehaviour
{
    public GameObject silinecek;
    public GameObject[] icindekiler;
    float olmezaman;
    public int sayisi;
    bool kirildi = false;
    public int puani;
    void Start()
    {
        
    }

    public void kirma() 
    {
        if (kirildi == false) {
            kirildi = true;
            Destroy(silinecek);
            for (int i = 0; i < icindekiler.Length; i++)
            {
                icindekiler[i].GetComponent<Rigidbody>().isKinematic = false;
                icindekiler[i].GetComponent<MeshCollider>().enabled = true;
                //olmezaman = Random.Range(4, 6);Destroy(icindekiler[i], olmezaman);
                icindekiler[i].GetComponent<Rigidbody>().AddForce(Random.Range(-0.02f, 0.02f), Random.Range(0.03f, 0.07f), Random.Range(0.02f, 0.05f));
            }
        }
        gameObject.GetComponent<BoxCollider>().center = new Vector3(gameObject.GetComponent<BoxCollider>().center.x,3, gameObject.GetComponent<BoxCollider>().center.z);
    }
    void Update()
    {
        
    }
}
