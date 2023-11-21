using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolhasAcidas : MonoBehaviour
{
    public float velocidadeBolha;

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
        transform.Translate(Vector3.down * velocidadeBolha * Time.deltaTime);
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
