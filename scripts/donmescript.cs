using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donmescript : MonoBehaviour
{
    public int kacenerji;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kirilacak") { Destroy(gameObject); }
    }
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}
