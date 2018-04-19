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
    public float velocidad = 1f;

    private bool dobleSalto = false;

    private Animator animator;

    private bool corriendo = false;

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
        if(corriendo)
        {
            rb2d.velocity = new Vector2(velocidad, rb2d.velocity.y);
        }
        animator.SetFloat("VelX", rb2d.velocity.x);
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
        if(Input.GetMouseButtonDown(0))
        {
            if(corriendo)
            {
                if (enSuelo || !dobleSalto)
                {
                    rb2d.velocity = new Vector2(rb2d.velocity.x, fuerzaSalto);
                    //rb2d.AddForce(new Vector2(0, fuerzaSalto));
                    if (!dobleSalto && !enSuelo)
                    {
                        dobleSalto = true;
                    }
                }
            }
            else
            {
                corriendo = true;

            }
        }

     
	}
}
