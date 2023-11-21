using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulapula : MonoBehaviour
{
    public float Jumpforce;

    private Animator anim;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("jump");
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, Jumpforce), ForceMode2D.Impulse);
        }
    }
}
