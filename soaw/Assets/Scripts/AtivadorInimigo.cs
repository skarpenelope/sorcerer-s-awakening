using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivadorInimigo : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.gameObject.CompareTag("Player"))
      {
         gameObject.GetComponent<InimigoAtirador>().AtirarLaser();
      }
   }
}
