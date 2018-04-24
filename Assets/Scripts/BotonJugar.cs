using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour {
    

    private void Start()
    {
      
    }
    private void OnMouseDown()
    {
       Camera.main.GetComponent<AudioSource>().Stop();
       GetComponent<AudioSource>().Play();
        Invoke("CargarJuego", GetComponent<AudioSource>().clip.length + 0.1f);
        
    }
    void CargarJuego()
    {
        SceneManager.LoadScene("main");
    }
}
