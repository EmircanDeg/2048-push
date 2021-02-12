using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayilarhareket : MonoBehaviour
{
    float hiz ;
    GameObject player;
    public bool enerjimi = false;
    void Start()
    {
        player = GameObject.Find("player");
        if (transform.position.x < -20) { hiz = 0; }
        if (transform.position.x > -20) { hiz = player.GetComponent<playerhareket>().hiz; }
    }

    // Update is called once per frame
    void Update()
    {
        if (enerjimi == false) { if (transform.position.x > -20) { transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime * player.GetComponent<playerhareket>().hiz; } }
        if (enerjimi == true) 
        {
            if (player.GetComponent<playerhareket>().hiz > -11) { if (transform.position.x > -20) { transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime * player.GetComponent<playerhareket>().hiz; } }
            else { if (transform.position.x > -20) { transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime * -11.1f; } }
        }
           
    }
}
