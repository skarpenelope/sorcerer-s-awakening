using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaJogador : MonoBehaviour
{
    public int manaAtual;
    public int manaMax;

    public Slider barrademana;

    public bool temMana;
    
    void Start()
    {
        manaAtual = manaMax;

        temMana = true;
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
        else
        {
            temMana = false;
        }
    }
}
