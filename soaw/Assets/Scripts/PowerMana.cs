using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMana : MonoBehaviour
{

    public int manaParaDar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.CompareTag("Player"))
        {
            colisor.gameObject.GetComponent<ManaJogador>().GanharMana(manaParaDar);
            Destroy(this.gameObject);
        }
    }
}
