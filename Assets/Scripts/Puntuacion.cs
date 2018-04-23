using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {
     int puntuacion = 0;
    public TextMesh marcador;

	// Use this for initialization
	void Start ()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        ActualizarMarcador();
	}

    void PersonajeHaMuerto(Notification notification)
    {
        if(puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima)
        {
            Debug.Log("Puntuacion Maxima Superada!");
            EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
            EstadoJuego.estadoJuego.Guardar();
        }
        else
        {
            Debug.Log("No superada");
        }
    }

	void IncrementarPuntos(Notification notification)
    {
        int puntosAIncrementar = (int)notification.data;
        puntuacion += puntosAIncrementar;
        ActualizarMarcador();
    }
    void ActualizarMarcador()
    {
        marcador.text = puntuacion.ToString();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
