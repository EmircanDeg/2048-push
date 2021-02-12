using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomyokolma : MonoBehaviour
{
    float zaman;
    void Start()
    {
        zaman = Random.Range(5, 8);
        Destroy(gameObject, zaman);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
