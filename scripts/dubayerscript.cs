using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dubayerscript : MonoBehaviour
{
    public bool x, y, z;
    public bool yrotasyon;
    public float x1;
    public float y1;
    public float z1;
    public float yr;
    void Start()
    {
        if (x == true) { transform.position = new Vector3(x1, transform.position.y, transform.position.z); }
        if (y == true) { transform.position = new Vector3(transform.position.x, y1, transform.position.z); }
        if (z == true) { transform.position = new Vector3(transform.position.x, transform.position.y, z1); }
        if (yrotasyon == true) { transform.eulerAngles=new Vector3(transform.eulerAngles.x,yr,transform.eulerAngles.z);}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
