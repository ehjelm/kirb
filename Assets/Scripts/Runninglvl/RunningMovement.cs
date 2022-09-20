using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningMovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb;

    public AudioSource jumpSound;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AudioSource jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);


        //jos painaa "Jump" eli v�lily�ntinappulaa ja isJumping boolean on ei, pelaaja hypp�� lis��m�ll� rigidbodyyn voimaa 
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            jumpSound.Play();

        }
    }


    //tunnistaa kun pelaaja koskee triggeriin
    private void OnTriggerEnter2D(Collider2D other)
    {
        //jos pelaaja osuu objektiin tagattu "Obstacle"(putket)
        if (other.gameObject.tag == "Enemy")
        {
            //etsii pelist� scriptin "RunningManager" ja trigger�i funktion "Game Over"
            FindObjectOfType<RunningManager>().GameOver();
        }
        //jos pelaaja osuu objektiin tagattu "SWMScoring"(putkien v�li)
        else if (other.gameObject.tag == "Score")
        {
            //etsii pelist� scriptin "RunningManager" ja trigger�i funktion "IncreaseScore"
            FindObjectOfType<RunningManager>().IncreaseScore();

            FindObjectOfType<RunningManager>().RunningScore();
        }
    }


}
