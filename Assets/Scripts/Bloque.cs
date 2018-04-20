using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {
    private bool haColisionado = false;
    public int puntosGanados = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!haColisionado && collision.collider.gameObject.tag =="Patas")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
            haColisionado = true;
        }
    }
}
