using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

	//Destroy already passed platforms
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeHaMuerto");
            GameObject personaje = GameObject.Find("Personaje");
            personaje.SetActive(false);
        }

        Destroy(collision.gameObject);
    }
}
