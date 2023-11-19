using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerVida : MonoBehaviour
{
    public int vidaParaDar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.CompareTag("Player"))
        {
            colisor.gameObject.GetComponent<VidaDoJogador>().GanharVida(vidaParaDar);
            Destroy(this.gameObject);
        }
    }
}
