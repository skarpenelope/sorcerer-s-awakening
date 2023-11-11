using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movimento
    public float velocidade;
    private Rigidbody2D rig;
    
    //Pulo
    public float Jumpforce;
    
    //pulo duplo
    public bool duploPulo;
    public bool isJumping;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        MovimentoJogador();
        Pulo();
    }

    public void MovimentoJogador()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f,0f); //input; ao apertar a ou d, o personagem vai movimentar no eixo x, eixo y e z estão sem nada.
        transform.position += movimento * Time.deltaTime * velocidade; //posição vai ser somado ao movimento que pode ser +1, para direita, ou -1, para esquerda.
    }

    public void Pulo()
    {
        if (Input.GetButtonDown("Jump"))  //se o botão jump(espaço) for apertado, vai executar.
        {
            rig.AddForce(new Vector2(0f, Jumpforce), ForceMode2D.Impulse);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D Colisor)
    {
        if (Colisor.gameObject.layer == 6)
        {
            
        }
    }
    
    private void OnCollisionExit2D(Collision2D Colisor)
    {
        if (Colisor.gameObject.layer == 6)
        {
            
        }
        
    }
}
