using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarGameOver : MonoBehaviour {

    public GameObject CamaraGameOver;

	// Use this for initialization
	void Start ()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
	}

    void PersonajeHaMuerto(Notification notification)
    {
        CamaraGameOver.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
