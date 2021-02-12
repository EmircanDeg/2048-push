using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirikkupscript : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(Random.Range(-0.02f, 0.02f), Random.Range(0.01f, 0.03f), Random.Range(0.02f, 0.05f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
