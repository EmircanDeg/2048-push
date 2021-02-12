using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evtetikscript : MonoBehaviour
{
    public GameObject evcikarici;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ev") { evcikarici.GetComponent<evcikariciscript>().evcikar(); }
    }
    void Update()
    {
        
    }
}
