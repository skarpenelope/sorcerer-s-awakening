using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBolhas : MonoBehaviour
{
    public float TempoAtualBolhas;
    public float tempoEntreBolhas;

    public GameObject bolhas;

    public Transform LocalBolhas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtirarLaser();
    }
    
    public void AtirarLaser()
    {
        TempoAtualBolhas -= Time.deltaTime;

        if (TempoAtualBolhas <= 0)
        {
            Instantiate(bolhas, LocalBolhas.position, Quaternion.Euler(0f,0f,180f));
            TempoAtualBolhas = tempoEntreBolhas;
            //anim.SetBool("ataqueClerigo", true);
        }
        if(TempoAtualBolhas > 0)
        {
            //anim.SetBool("ataqueClerigo", false);
        }
    }
}
