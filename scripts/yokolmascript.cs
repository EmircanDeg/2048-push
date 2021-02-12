using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokolmascript : MonoBehaviour
{
    public float olmezaman = 2;
    void Start()
    {
        Destroy(gameObject, olmezaman);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
