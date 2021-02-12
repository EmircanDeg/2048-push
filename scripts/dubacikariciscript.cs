using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dubacikariciscript : MonoBehaviour
{
    public GameObject[] dubas;
    int secim;
    int hangi;
    public GameObject sahteduba;
    void Start()
    {
        
    }

    public void dubacikar() 
    {
        hangi = Random.Range(0, 10);
        if (hangi<5) { Instantiate(sahteduba,transform.position+new Vector3(0,10,0),transform.rotation); }
        secim = Random.Range(0, dubas.Length);
        if (hangi > 4) { Instantiate(dubas[secim], transform.position, transform.rotation); Instantiate(sahteduba, transform.position + new Vector3(0, 10, 0), transform.rotation); }
    }
    void Update()
    {
        
    }
}
