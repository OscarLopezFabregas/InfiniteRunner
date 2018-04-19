using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour {

    public float fuerzaSalto = 100f;
    private Rigidbody2D rb2d;
    private bool enSuelo = true;
    public Transform comprobadorSuelo;
    float comprobadorRadio = 0.07f;
    public LayerMask mascaraSuelo;

    private bool dobleSalto = false;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Use this for initialization
    void Start ()
    {
       
	}

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
        animator.SetBool("isGrounded", enSuelo);
        if(enSuelo)
        {
            dobleSalto = false;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if ((enSuelo || !dobleSalto) && Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, fuerzaSalto);
            //rb2d.AddForce(new Vector2(0, fuerzaSalto));
            if(!dobleSalto && !enSuelo)
            {
                dobleSalto = true;
            }
        } 
	}
}
