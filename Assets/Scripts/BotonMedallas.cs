using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class BotonMedallas : MonoBehaviour {
    AudioSource audioSource;
    private TextMesh textoBoton;


    private void Awake()
    {
        textoBoton = GetComponent<TextMesh>();
    }
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        textoBoton.color = Social.localUser.authenticated ? Color.white : Color.gray;
    }
    private void OnMouseDown()
    {
        audioSource.Play();

        if (Social.localUser.authenticated)
        {
            ((PlayGamesPlatform)Social.Active).ShowAchievementsUI();
        }
        else
        {
            Social.localUser.Authenticate((bool success) => { });
        }
    }
}
