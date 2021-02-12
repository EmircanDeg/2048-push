using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukaricikmascript : MonoBehaviour
{
    public float ysi = 10;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 5, 0) * Time.deltaTime;
        if (transform.position.y > ysi) { Destroy(gameObject); }
    }
}
