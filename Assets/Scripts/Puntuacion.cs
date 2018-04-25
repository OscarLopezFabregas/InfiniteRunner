using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {
    private int key = 0;
    private int _puntuacion = 0;
    public int puntuacion
    {
        get { return _puntuacion ^ key; }
        set
        {
            key = Random.Range(0, int.MaxValue);
            _puntuacion = value ^ key;
        }
    }
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
            EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
            EstadoJuego.estadoJuego.Guardar();
        }
        //Send score to google play games
        Social.ReportScore(puntuacion, "CgkI4Zrw5d4FEAIQBg", (bool success) => { });
        //Check Achievements
        if(puntuacion>=25)
        {
            Social.ReportProgress("CgkI4Zrw5d4FEAIQAQ", 100.0, (bool success) => { });
        }
        if (puntuacion >= 50)
        {
            Social.ReportProgress("CgkI4Zrw5d4FEAIQAg", 100.0, (bool success) => { });
        }
        if (puntuacion >= 100)
        {
            Social.ReportProgress("CgkI4Zrw5d4FEAIQAw", 100.0, (bool success) => { });
        }
        if (puntuacion >= 150)
        {
            Social.ReportProgress("CgkI4Zrw5d4FEAIQBA", 100.0, (bool success) => { });
        }
        if (puntuacion >= 200)
        {
            Social.ReportProgress("CgkI4Zrw5d4FEAIQBQ", 100.0, (bool success) => { });
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
