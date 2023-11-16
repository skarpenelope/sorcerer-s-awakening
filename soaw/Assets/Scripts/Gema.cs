using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : MonoBehaviour
{
    private SpriteRenderer sprite;
    private CircleCollider2D circle;

    public int ScoreAzul;
    public int ScoreAmarelo;
    public int ScoreVerde;

    //public GameObject collected;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //sprite.enabled = false;
            //circle.enabled = false;
            //collected.SetActive(true);

            GameController.instance.totalScoreAzul += ScoreAzul;
            GameController.instance.totalScoreAmarelo += ScoreAmarelo;
            GameController.instance.totalScoreVerde += ScoreVerde;
            GameController.instance.UpdateScore();
            
            Destroy(gameObject);
        }
        
        
    }
}
