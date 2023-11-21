using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMana : MonoBehaviour
{
    // movimentar

    public float amplitude;
    public float speed;
    private Vector3 startPos;

    public int manaParaDar;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    { 
        float newY = startPos.y + amplitude * speed * Mathf.Sin(speed * Time.time);

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
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
