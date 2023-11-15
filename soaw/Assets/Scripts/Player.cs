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
    
    //animações
    private Animator anim;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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

        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk_direita", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk_direita", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        
        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk_direita", false);
        }
        
    }

    public void Pulo()
    {
        if (Input.GetButtonDown("Jump"))  //se o botão jump(espaço) for apertado, vai executar. Analisa se o isJumping está verdadeiro.
        {
            if (!isJumping)
            {
                rig.AddForce(new Vector2(0f, Jumpforce), ForceMode2D.Impulse);
                duploPulo = true;
            }
            else
            {
                if (duploPulo)
                {
                    rig.AddForce(new Vector2(0f, Jumpforce), ForceMode2D.Impulse);
                    duploPulo = false;
                }
            }
            //rig.AddForce(new Vector2(0f, Jumpforce), ForceMode2D.Impulse);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D Colisor)
    {
        if (Colisor.gameObject.layer == 6) // se o game object estiver tocando no layer 6, vai executar.
        {
            isJumping = false;
        }
    }
    
    private void OnCollisionExit2D(Collision2D Colisor) // se o game object estiver tocando no layer 6, vai executar.
    {
        if (Colisor.gameObject.layer == 6)
        {
            isJumping = true;
        }
        
    }
}
