using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmingMovement : MonoBehaviour
{

    private Vector3 _target;
    public Camera Camera;
    public bool FollowMouse;
    public bool acceleration;
    public float speed = 2.0f;

    

    public void Update()
    {
        
        _target = Camera.ScreenToWorldPoint(Input.mousePosition);
        _target.z = 0;

        var delta = speed * Time.deltaTime;
        if (acceleration)
        {
            delta *= Vector3.Distance(transform.position, _target);
        }

        transform.position = Vector3.MoveTowards(transform.position, _target, delta);
    }

    //tunnistaa kun pelaaja koskee triggeriin
    private void OnTriggerEnter2D(Collider2D other)
    {
        //jos pelaaja osuu objektiin tagattu "Obstacle"(putket)
        if (other.gameObject.tag == "Obstacle")
        {
            //etsii pelistä scriptin "Swimming manager" ja triggeröi funktion "Game Over"
            FindObjectOfType<SwimmingManager>().GameOver();
        }
        //jos pelaaja osuu objektiin tagattu "SWMScoring"(putkien väli)
        else if (other.gameObject.tag == "SWMScoring")
        {
            //etsii pelistä scriptin "Swimming manager" ja triggeröi funktion "IncreaseScore"
            FindObjectOfType<SwimmingManager>().IncreaseScore();

            FindObjectOfType<SwimmingManager>().SwimmingScore();
        }
    }
}
