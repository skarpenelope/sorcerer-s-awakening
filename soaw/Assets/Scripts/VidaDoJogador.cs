using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{
    public int vidaMax;
    public int vidaAtual;

    public Slider barraDeVida;

    public Animator anim;

    private BoxCollider2D bc;
    
    
    void Start()
    {
        vidaAtual = vidaMax;
        barraDeVida.maxValue = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucarJogador(int danoParaReceber)
    {
        vidaAtual -= danoParaReceber;
        barraDeVida.value = vidaAtual;

        if (vidaAtual <= 0)
        {
            Debug.Log("gameover");
            GameController.instance.ShowGameOver();
            Destroy(this.gameObject);
        }
    }

    public void GanharVida(int vidaParaReceber)
    {
        if (vidaAtual + vidaParaReceber <= vidaMax)
        {
            vidaAtual += vidaParaReceber;
                
        }
        else
        {
            vidaAtual = vidaMax;
        }

        barraDeVida.value = vidaAtual;
    }

    public void MoreLife()
    {
        vidaAtual++;
        UpdateLife();
    }

    public void UpdateLife()
    {
        barraDeVida.value = vidaAtual;
    }
}
