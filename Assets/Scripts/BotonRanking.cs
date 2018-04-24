using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class BotonRanking : MonoBehaviour {
    AudioSource audioSource;
    private TextMesh textoBoton;

    private void Awake()
    {
        textoBoton = GetComponent<TextMesh>();
    }
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        textoBoton.color = Social.localUser.authenticated ? Color.white : Color.gray;
    }

    private void OnMouseDown()
    {
        audioSource.Play();

        if(Social.localUser.authenticated)
        {
            ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI("CgkI4Zrw5d4FEAIQBg ");
        }
        else
        {
            Social.localUser.Authenticate((bool success) => { });
        }
    }
}
