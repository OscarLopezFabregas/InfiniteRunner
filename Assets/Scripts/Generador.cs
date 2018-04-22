using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

    public GameObject[] obj;
    public float tiempoMin = 1.5f;
    public float tiempoMax = 3f;
    private bool fin = false;

	// Use this for initialization
	void Start ()
    {
        // Generar();
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
	}
	
    void PersonajeEmpiezaACorrer(Notification notification)
    {
        Generar();
    }

    void PersonajeHaMuerto()
    {
        fin = true;
    }

    // Update is called once per frame
    void Update ()
    {
	}
    
   
    void Generar()
    {
        if(!fin)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
        }
      
    }
}
