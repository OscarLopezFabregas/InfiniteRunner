using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public bool iniciarEnMovimiento = false;
    public float velocidad = 0.1f;
    Renderer _renderer;
    private bool enMovimiento = false;
    private float tiempoInicio = 0;
	// Use this for initialization
	void Start ()
    {
        _renderer = GetComponent<Renderer>();
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        if(iniciarEnMovimiento)
        {
            PersonajeEmpiezaACorrer();
        }
    }

    void PersonajeHaMuerto()
    {
        enMovimiento = false;
    }

    void PersonajeEmpiezaACorrer()
    {
        enMovimiento = true;
        tiempoInicio = Time.time;
    }

	// Update is called once per frame
	void Update ()
    {
        if(enMovimiento)
        _renderer.material.SetTextureOffset("_MainTex", new Vector2((velocidad*(Time.time-tiempoInicio))%1, 0));
	}
}
