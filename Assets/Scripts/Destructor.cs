using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

	//Destroy already passed platforms
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //TODO: show score, show max score!
            Debug.Break();
        }

        Destroy(collision.gameObject);
    }
}
