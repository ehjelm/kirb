using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptChange : MonoBehaviour
{
    public Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Swim")
        {
            GetComponent<RaceRun>().enabled = false;
            GetComponent<RaceSwim>().enabled = true;
            rb.isKinematic = true;
            Debug.Log("ass");
        }
        else if (other.gameObject.tag == "Fly")
        {
            GetComponent<RaceSwim>().enabled = false;
            GetComponent<RaceFly>().enabled = true;
            rb.isKinematic = true;
            Debug.Log("dass");
        }
    }
}
