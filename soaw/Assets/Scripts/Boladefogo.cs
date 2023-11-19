using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boladefogo : MonoBehaviour
{
    public float velocidade;

    public int danoParaDar;
    
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
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Inimigo"))
        {
            col.gameObject.GetComponent<Vidadoinimigo>().MachucarInimigo(danoParaDar);
            Destroy(this.gameObject);
        }
    }
}
