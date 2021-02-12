using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerascript : MonoBehaviour
{
    public Transform player;
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void titret() 
    {
        anim.Play("kameraanim");
        Invoke("toparla", 0.2f);
    }
    public void toparla() { anim.Play("dafolt"); }
    void Update()
    {
        
    }
}
