using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptChange : MonoBehaviour
{
    public Rigidbody2D rb;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 1f;
        rb.gravityScale = 1f;
        rb.angularDrag = 0.05f;

        
    }



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Swim")
        {
            GetComponent<RaceRun>().enabled = false;
            GetComponent<RaceSwim>().enabled = true;
            rb.mass = 0f;
            rb.gravityScale = 0f;
            rb.angularDrag = 0f;

        }
        else if (other.gameObject.tag == "Fly")
        {
            GetComponent<RaceSwim>().enabled = false;
            GetComponent<RaceFly>().enabled = true;
            //rb.isKinematic = true;
            
        }
        else if (other.gameObject.tag == "Run")
        {
            GetComponent<RaceRun>().enabled = true;
            GetComponent<RaceSwim>().enabled = false;
            GetComponent<RaceFly>().enabled = false;
            rb.mass = 1f;
            rb.gravityScale = 1f;
            rb.angularDrag = 0.05f;
        }
    }
}
