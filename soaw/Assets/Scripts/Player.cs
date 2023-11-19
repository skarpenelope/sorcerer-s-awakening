using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //movimento
    public float velocidade;
    [SerializeField]
    private Rigidbody2D rig;
    
    //DASH
    public float speeddash;
    public float timedash;
    public float velocidadeDash;
    
    //Pulo
    public float Jumpforce;
    
    //pulo duplo
    public bool duploPulo;
    public bool isJumping;
    
    //animações
    private Animator anim;
    
    //atirar
    public GameObject laserJogador;
    public Transform localdolaser;
    
    //MANA
    public int manaAtual;
    public int manaMax;

    public Slider barrademana;

    public bool temMana;

    public int CustoTiro;
    
    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        //ManaJogador mana = GetComponent<ManaJogador>();

        manaAtual = manaMax;
        temMana = true;


    }
    
    void Update()
    {
        MovimentoJogador();
        Pulo();
        Atirando();
    }

    public void MovimentoJogador()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f,0f); //input; ao apertar a ou d, o personagem vai movimentar no eixo x, eixo y e z estão sem nada.
        transform.position += movimento * Time.deltaTime * velocidade; //posição vai ser somado ao movimento que pode ser +1, para direita, ou -1, para esquerda.

        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        
        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }
        
    }

    public void Dash()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.rig.velocity = new Vector2(this.velocidadeDash, 0);
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
                anim.SetBool("jump", true);
                anim.SetBool("walk", false);
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
        if (Colisor.gameObject.layer == 6) // se o game object estiver tocando no layer 6, no chão, não vai acontecer nada.
        {
            isJumping = false;
            anim.SetBool("jump", false);
        }
        
        //GAME OVER

        if (Colisor.gameObject.tag == "Morte")
        {
            Debug.Log("morreu");
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
    }
    
    private void OnCollisionExit2D(Collision2D Colisor) // se o game object não estiver tocando no layer 6, vai executar.
    {
        if (Colisor.gameObject.layer == 6)
        {
            isJumping = true;
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //PARA GANHAR VIDA SE COLETAR
        if (col.gameObject.CompareTag("vida"))
        {
            gameObject.GetComponent<VidaDoJogador>().MoreLife();
            Destroy(col.gameObject);
        }



    }
    
    public void GanharMana(int ManaParaGanhar)
    {
        if (manaAtual + ManaParaGanhar <= manaMax)
        {
            manaAtual += ManaParaGanhar;
        }
        else
        {
            manaAtual = manaMax;
        }

        barrademana.value = manaAtual;
    }

    public void QuantidadeMana()
    {
        if (manaAtual > 0)
        {
            temMana = true;
        }
        if(manaAtual <= 0)
        {
            temMana = false;
        }
    }

    public void Atirando()
    {
        if (Input.GetKeyDown(KeyCode.Q) && temMana == true)
        {
            anim.SetBool("ataque", true);
            Instantiate(laserJogador, localdolaser.position, localdolaser.rotation);
            //anim.SetBool("walk", false);

            manaAtual -= CustoTiro;
            barrademana.value = manaAtual;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            anim.SetBool("ataque", false);
            //anim.SetBool("walk", true);
        }

        if (temMana == false)
        {
            return;
        }
    }

    public void SofrendoDano()
    {
        anim.SetBool("dano", true);
    }

    public void Vida()
    {
        
    }
    
   
}
