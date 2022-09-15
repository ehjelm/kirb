using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;

    // kameran vasen reuna
    private float leftEdge;

    private void Start()
    {
        //lasketaan vasen reuna 
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 5f;
    }

    private void Update()
    {
        // liikkuu vasemmalle speed variablen nopeudella
        transform.position += Vector3.left * speed * Time.deltaTime;

        // jos peliobjekti menee vasemman reunan yli se tuhoutuu
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
