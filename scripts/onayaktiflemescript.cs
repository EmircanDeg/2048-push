using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onayaktiflemescript : MonoBehaviour
{
    public string prefadi;
    void Start()
    {
        if (PlayerPrefs.GetInt(prefadi) == 0) { gameObject.SetActive(false); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
