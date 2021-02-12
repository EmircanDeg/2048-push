using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetikscript : MonoBehaviour
{
    public GameObject cikarici;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sayi") 
        {
            if (other.gameObject.GetComponent<sayilarscript>().gelenmi == true) { cikarici.GetComponent<cikariciscript>().cikart(); }

        }
    }
    void Update()
    {
        
    }
}
