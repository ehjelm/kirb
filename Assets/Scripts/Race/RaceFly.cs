using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFly : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 moveV;
    public float speed;

    public AudioSource scoreFX;
    public AudioSource lose;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        AudioSource scoreFX = GetComponent<AudioSource>();
        AudioSource lose = GetComponent<AudioSource>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(1, Input.GetAxisRaw("Vertical"));
        moveV = moveInput * speed;

        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveV * Time.fixedDeltaTime);
        
    }



    //jos pelaaja osuu viholliseen, GameOver ___ triggeröityy, ja jos pelaaja osuu scoreen, tulee score
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            FindObjectOfType<RaceManager>().GameOver();

            lose.Play();
        }
    }
}
