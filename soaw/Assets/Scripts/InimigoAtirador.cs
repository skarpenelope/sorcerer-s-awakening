using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoAtirador : MonoBehaviour
{
    public GameObject laserInimigo;

    public Transform localDeDisparo;

    public float velocidadeInimigo;

    public float tempoMaximoEntreDisparos;

    public float tempoAtualdosLasers;

    private Animator anim;
    
    void Start()
    {
        tempoAtualdosLasers = tempoMaximoEntreDisparos;
    }

    // Update is called once per frame
    void Update()
    {
        AtirarLaser();
    }

    public void MovimentarInimigo()
    {
        transform.Translate(Vector3.left * velocidadeInimigo * Time.deltaTime);
    }

    public void AtirarLaser()
    {
        tempoAtualdosLasers -= Time.deltaTime;

        if (tempoAtualdosLasers <= 0)
        {
            Instantiate(laserInimigo, localDeDisparo.position, Quaternion.Euler(0f,0f,180f));
            tempoAtualdosLasers = tempoMaximoEntreDisparos;
            //anim.SetBool("ataqueClerigo", true);
        }
        if(tempoAtualdosLasers > 0)
        {
            //anim.SetBool("ataqueClerigo", false);
        }
    }
}
