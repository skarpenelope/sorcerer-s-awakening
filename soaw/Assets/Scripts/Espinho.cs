using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour
{
    public int danoParaDar;

    private Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
            colisao.gameObject.GetComponent<VidaDoJogador>().MachucarJogador(danoParaDar);
            gameObject.GetComponent<Player>().SofrendoDano();
            Destroy(this.gameObject);
        }
    }
}
