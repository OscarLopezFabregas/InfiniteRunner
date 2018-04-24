using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarGameOver : MonoBehaviour {

    public GameObject CamaraGameOver;
    private AudioSource audioSource;
    public AudioClip gameOverClip;
	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
	}

    void PersonajeHaMuerto(Notification notification)
    {
        audioSource.Stop();
        audioSource.clip = gameOverClip;
        audioSource.loop = false;
        audioSource.Play();

        CamaraGameOver.SetActive(true);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
