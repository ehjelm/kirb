using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceSwim : MonoBehaviour
{

    Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }


    //tunnistaa kun pelaaja koskee triggeriin
    private void OnTriggerEnter2D(Collider2D other)
    {
        //jos pelaaja osuu objektiin tagattu "Obstacle"(putket)
        if (other.gameObject.tag == "Enemy")
        {
            //etsii pelistä scriptin "Swimming manager" ja triggeröi funktion "Game Over"
            FindObjectOfType<RaceManager>().GameOver();
        }
    }
}
