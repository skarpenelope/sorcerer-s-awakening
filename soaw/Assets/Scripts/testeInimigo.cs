using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeInimigo : MonoBehaviour
{
    public float speed;
    public Transform ponto1;
    public Transform ponto2;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "ponto2")
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (colisor.gameObject.tag == "ponto1")
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
