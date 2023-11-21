using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaJogador : MonoBehaviour
{
    public int manaAtual;
    public int manaMax;

    public Slider barrademana;
    
    
    void Start()
    {
        manaAtual = manaMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GanharMana(int ManaParaGanhar)
    {
        if (manaAtual + ManaParaGanhar <= manaMax)
        {
            manaAtual += ManaParaGanhar;
        }

        barrademana.value = manaAtual;
    }
}
