using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dubatetik : MonoBehaviour
{
    public GameObject dubacikarici;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kirilacak1") { dubacikarici.GetComponent<dubacikariciscript>().dubacikar(); }
    }
    void Update()
    {
        
    }
}
