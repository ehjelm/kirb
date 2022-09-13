using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // julkiset variablet jota on mahdollista muuttaa Unityn käyttöliittymässä
    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb;


    //Start kutsutaan kerran ennen ensimmäistä "ruudun" = framen päivitystä
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update kutsutaan kerran per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);


        //jos painaa "Jump" eli välilyöntinappulaa ja isJumping boolean on ei, pelaaja hyppää lisäämällä rigidbodyyn voimaa 
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    //tarkistaa jos pelaaja osuu maahan "Ground", jos osuu "isJumpig" boolean on ei
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

    }

    //tarkistaa jos pelaaja osuu maahan "Ground", jos ei osu "isJumpig" boolean on kyllä
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
