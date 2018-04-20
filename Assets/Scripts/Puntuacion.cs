using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {
     int puntuacion = 0;

	// Use this for initialization
	void Start ()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");	
	}
	void IncrementarPuntos(Notification notification)
    {
        int puntosAIncrementar = (int)notification.data;
        puntuacion += puntosAIncrementar;
        Debug.Log("Incrementando"+puntosAIncrementar+"puntos.Total:"+puntuacion);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
