using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpurgoInimigo : MonoBehaviour
{
    public float velocidadeExpurgo;

    public int danoParaDar;

    private Animation anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarLaser();
    }

    public void MovimentarLaser()
    {
        transform.Translate(Vector3.right * velocidadeExpurgo * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
            colisao.gameObject.GetComponent<VidaDoJogador>().MachucarJogador(danoParaDar);
            gameObject.GetComponent<VidaDoJogador>().anim.SetBool("dano", true);
            Destroy(this.gameObject);
        }
    }
}
