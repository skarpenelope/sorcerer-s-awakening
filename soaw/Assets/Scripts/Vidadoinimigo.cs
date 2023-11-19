using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidadoinimigo : MonoBehaviour
{
    public int vidaMax;
    public int vidaAtual;

    private Animator anim;
    void Start()
    {
        vidaAtual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucarInimigo(int DanoParaReceber)
    {
        vidaAtual -= DanoParaReceber;

        if (vidaAtual <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
